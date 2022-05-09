using AccountManager.Core.Consts;
using AccountManager.Core.Enums;
using AccountManager.Core.Services;
using AccountManager.UI.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountManager.UI.Events
{
    public static class TimerEvents
    {
        public static void ReaderTick(this FormCreator form)
        {
            try
            {
                if (App.Account != null && App.Account.Step == StepType.GameAccountCaptchaError && App.Account.IsCanDoAction && form._browser.Address == App.GameAccountRegisterCompleteUrl)
                {
                    var ocrService = new OcrService();
                    var captchaText = ocrService.RecognitionFromUrl(App.Account.CaptchaUrl, App.Account.CaptchaLanguageRow);

                    App.Account.UpdateCaptcha(captchaText);
                    App.Account.UpdateStep(StepType.GameAccountCaptcha);
                    App.BrowserIsReady = true;
                }

                if (!App.BrowserIsReady) return;

                form.ButtonStart.Enabled = App.BrowserIsReady && !string.IsNullOrEmpty(form.TextBoxEmail.Text) && form.TextBoxEmail.Text != "...";

                if (form._browser.Address.Contains("mail.tm"))
                    form._browser.GetElementValue("#address").ContinueWith(x =>
                    {
                        var mailAddress = x?.Result?.Result?.ToString();
                        if (!string.IsNullOrEmpty(mailAddress) && form.TextBoxEmail.InvokeRequired)
                            form.TextBoxEmail.Invoke(new MethodInvoker(delegate { form.TextBoxEmail.Text = mailAddress; }));

                        if (App.Account != null)
                        {
                            App.Account.UpdateMail(mailAddress);

                            if (form.TextBoxRow.InvokeRequired)
                                form.TextBoxRow.Invoke(new MethodInvoker(delegate { form.TextBoxRow.Text = App.Account.Row.ToString(); }));
                        }
                    });

                if (App.Account == null || !App.Account.IsCanDoAction) return;

                if (App.Account.Step == StepType.MailInboxEmailWaiting && App.Account.IsCanDoAction && form._browser.Address.Contains("mail.tm"))
                {
                    form._browser.ClickElement("nav a:last-child");
                    App.Account.UpdateAction();
                }

                if (App.Account.Step == StepType.GameAccountCaptcha && App.Account.IsCanDoAction && form._browser.Address == App.GameAccountRegisterCompleteUrl)
                {
                    form._browser.SetElementValue("[name='word']", App.Account.Captcha, 500);
                    form._browser.CallFunction("blur()", 1000);
                    form._browser.CallFunction("goSubmit()", 2000);

                    App.Account.UpdateAction();
                    App.Account.UpdateStep(StepType.GameAccountCaptchaCompleted);
                }

                if (App.Account.Step == StepType.ResetMailInbox && form._browser.Address == App.MailboxUrl)
                {
                    form._browser.ClickElement("#logout", 100);
                    App.Account.UpdateAction(4000);
                    App.Account.UpdateStep(StepType.MailInbox);
                    form._browser.Redirect(App.MailboxUrl, 1000);
                }
            }
            catch (Exception) { }
        }
    }
}