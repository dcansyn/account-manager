using AccountManager.Core.Consts;
using AccountManager.Core.Enums;
using AccountManager.Core.Helpers;
using AccountManager.Core.Models;
using AccountManager.Core.Services;
using AccountManager.UI.Extensions;
using CefSharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountManager.UI.Events
{
    public static class BrowserEvents
    {
        public static void OnResourceLoadComplete(this FormCreator form, string res, IRequest request, IResponse response)
        {
            if (App.Account == null || !App.Account.Status) return;

            // Game Name Error
            if (request.Url.Contains("login_idchk.php") || 
                request.Url.Contains("nicknamechk.php") || 
                request.Url.Contains("usernamechk.php"))
            {
                if (res.StartsWith("0"))
                {
                    form.ButtonStart.Text = "Start";
                    form._browser.Redirect(App.MailboxUrl);
                    MessageBox.Show("The game name is not acceptable, please renew the e-mail and start again.");
                    App.Account = null;
                    return;
                }
            }

            // Mail Inbox Email Waiting
            if (App.Account.Step == StepType.MailInboxEmailWaiting && request.Url.Contains("mail.tm/messages"))
            {
                var mail = JsonConvert.DeserializeObject<MailModel>(res);

                if (mail?.Items?.Length > 0)
                {
                    var mgameMail = mail.Items.FirstOrDefault(x => x.Subject.Contains("MGAME"));
                    if (mgameMail == null) return;

                    form._browser.Redirect($"https://mail.tm/tr/view/{mgameMail.Id}/");
                    App.Account.UpdateStep(StepType.MailInboxEmailArrived);
                    return;
                }
            }

            // Mail Inbox Email Arrived
            if (App.Account.Step == StepType.MailInboxEmailArrived && request.Url.Contains("mail.tm/messages"))
            {
                var mail = JsonConvert.DeserializeObject<MailModel>(res);
                if (!string.IsNullOrEmpty(mail?.Text) && mail.Text.Contains("step03"))
                {
                    var gameAccountRegisterUrl = mail.Text
                        .Split(new string[] { "<br />", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                        .FirstOrDefault(x => x.Contains("step03"));

                    form._browser.Redirect(gameAccountRegisterUrl);
                    App.Account.UpdateStep(StepType.GameAccountRegister);
                    return;
                }
            }

            // Game Account Captcha Solve
            if (App.Account.Step == StepType.GameAccountRegisterCompleted && request.Url.Contains("member/checkImage"))
            {
                App.Account.UpdateCaptchaUrl(request.Url);

                var ocrService = new OcrService();
                var captchaText = ocrService.RecognitionFromUrl(request.Url);

                App.Account.UpdateCaptcha(captchaText);
                App.Account.UpdateStep(StepType.GameAccountCaptcha);
            }

            // Game Account Captcha Error
            if (request.Url.Contains("reg_proc.php") && res?.Contains("f_authText") == true)
            {
                if (App.Account.CaptchaLanguageRow <= App.OcrLanguages.Length)
                {
                    App.Account.UpdateCaptchaLanguageRow(App.Account.CaptchaLanguageRow + 1);
                    App.Account.UpdateStep(StepType.GameAccountCaptchaError);
                    return;
                }

                Cef.GetGlobalCookieManager().DeleteCookies();
                App.Account.NextAccount();
                form._browser.Redirect(App.MailboxUrl, 1500);
            }
        }

        public static void OnFrameLoadEnd(this FormCreator form, object sender, FrameLoadEndEventArgs e)
        {
            App.BrowserIsReady = true;

            if (!App.BrowserIsReady || App.Account == null || e.Url == null) return;

            // Mail Inbox
            if (App.Account.Step == StepType.MailInbox && e.Url == App.MailboxUrl)
            {
                form._browser.ClickElement("#accounts-menu", 500);

                TaskHelper.Timeout(1000, () =>
                {
                    form._browser.GetElementText(".account-blur").ContinueWith(x =>
                    {
                        var mailPassword = x?.Result?.Result?.ToString();
                        if (!string.IsNullOrEmpty(mailPassword))
                        {
                            App.Account.UpdateMailPassword(mailPassword);
                            App.Account.UpdateStep(StepType.GameEmailRegister);

                            form._browser.Redirect(App.GameEmailRegisterUrl);
                        }
                    });
                });
            }

            // Game Email Register
            if (App.Account.Step == StepType.GameEmailRegister && e.Url == App.GameEmailRegisterUrl)
            {
                form._browser.SetElementValue("#check_email", App.Account.Mail, 100);
                form._browser.CallFunction("chkemailkeyup()", 500);
                form._browser.CallFunction("popup_chk_email()", 1000);
                form._browser.ClickElement(".form_btn", 3000);

                App.Account.UpdateStep(StepType.GameEmailRegisterCompleted);
            }

            // Game Email Register Completed
            if (App.Account.Step == StepType.GameEmailRegisterCompleted && e.Url == App.GameEmailRegisterCompleteUrl)
            {
                TaskHelper.Timeout(2000, () =>
                {
                    App.Account.UpdateStep(StepType.MailInboxEmailWaiting);
                    form._browser.Redirect(App.MailboxUrl);
                });
            }

            // Game Account Register
            if (App.Account.Step == StepType.GameAccountRegister && e.Url.Contains("step03") && e.Url.Contains("key"))
            {
                // Id
                form._browser.SetElementValue("#login_id", App.Account.GameId, 100);
                form._browser.CallFunction("idkeyup()", 200);
                form._browser.CallFunction("inputUserID()", 300);

                // Nick
                form._browser.SetElementValue("#nickname", App.Account.GameId, 400);
                form._browser.CallFunction("nickkeyup()", 500);
                form._browser.CallFunction("inputnickCheck()", 600);

                // Password
                form._browser.SetElementValue("#login_password", App.Account.Password, 700);
                form._browser.CallFunction("checkpwdstatus()", 800);
                form._browser.CallFunction("inputUserPwd_F()", 900);

                // Password Confirm
                form._browser.SetElementValue("#login_password_confirm", App.Account.Password, 1000);
                form._browser.CallFunction("inputUserPwd_R()", 1100);
                form._browser.CallFunction("inputcomparePwd()", 1200);

                // Username
                form._browser.SetElementValue("#username", App.Account.Username, 1300);
                form._browser.CallFunction("inputusernameCheck()", 1400);

                // Gender
                form._browser.ClickElement("#sex[value='1']", 1500);

                // Birthdate
                form._browser.SetElementValue("#year", App.Account.BirthDate.Year.ToString(), 1600);
                form._browser.CallFunction("updateDateBox(document.querySelector('#year'))", 1700);
                form._browser.SetElementValue("#month", App.Account.BirthDate.Month.ToString("D2"), 1800);
                form._browser.CallFunction("updateDateBox(document.querySelector('#month'))", 1900);
                form._browser.SetElementValue("#day", App.Account.BirthDate.Day.ToString("D2"), 2000);

                // Address
                form._browser.SetElementValue("[name='address']", App.Account.Address, 2100);

                // Question
                form._browser.SetElementValue("[name='question']", App.Account.Question, 2200);
                form._browser.CallFunction("checkquestion()", 2300);

                // Answer
                form._browser.SetElementValue("[name='answer']", App.Account.Answer, 2400);
                form._browser.CallFunction("checkanswer()", 2500);

                // Policy
                form._browser.SetElementChecked("#label_agreement", true, 2600);

                // Submit
                form._browser.CallFunction("goSubmit()", 3000);

                App.Account.UpdateStep(StepType.GameAccountRegisterCompleted);
            }

            // Game Account Completed
            if (App.Account.Step == StepType.GameAccountCaptchaCompleted && e.Url == App.GameAccountCompleteUrl)
            {
                Cef.GetGlobalCookieManager().DeleteCookies();
                StorageHelper.SaveClient();
                App.Account.NextAccount();

                form._browser.Redirect(App.MailboxUrl, 1500);
            }
        }

        public static void OnAddressChanged(this FormCreator form, object sender, AddressChangedEventArgs e)
        {
            App.BrowserIsReady = false;

            if (e.Address.Contains("mgame.jp"))
                form._browser.ChangeAcceptLanguage("ja");
            else
                form._browser.ChangeAcceptLanguage("tr");

            if (form.TextBoxNavigate.InvokeRequired)
                form.TextBoxNavigate.Invoke(new MethodInvoker(delegate { form.TextBoxNavigate.Text = e.Address; }));
        }

        public static void OnInitializedChanged(this FormCreator form, object sender, EventArgs e)
        {
            form._browser.ChangeAcceptLanguage("tr");
        }
    }
}
