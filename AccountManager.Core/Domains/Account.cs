using AccountManager.Core.Consts;
using AccountManager.Core.Enums;
using System;

namespace AccountManager.Core.Domains
{
    public class Account
    {
        public string GameId => Username + Row;
        public int Row { get; protected set; }
        public string Mail { get; protected set; }
        public string MailPassword { get; protected set; }
        public string Username { get; protected set; }
        public string Password { get; protected set; }
        public DateTime BirthDate { get; protected set; }
        public string Address { get; protected set; }
        public string Question { get; protected set; }
        public string Answer { get; protected set; }
        public string Captcha { get; protected set; }
        public string CaptchaUrl { get; protected set; }
        public int CaptchaLanguageRow { get; protected set; } = 0;

        public StepType Step { get; protected set; }
        public bool Status { get; protected set; }

        public DateTime LastActionTime { get; protected set; } = DateTime.Now;
        public bool IsCanDoAction => DateTime.Now > LastActionTime;

        public Account(int row, string mail, string username, string password, DateTime birthDate, string address, string question, string answer)
        {
            Row = row;
            Mail = mail;
            Username = username;
            Password = password;
            BirthDate = birthDate;
            Address = address;
            Question = question;
            Answer = answer;
            
            Step = StepType.MailInbox;
        }
        
        public void UpdateStep(StepType step)
        {
            Step = step;
        }

        public void UpdateAction(int miliseconds = 2000)
        {
            LastActionTime = DateTime.Now.AddMilliseconds(miliseconds);
        }

        public void NextAccount()
        {
            Step = StepType.ResetMailInbox;
            Captcha = null;
            MailPassword = null;
            Row++;

            UpdateCaptchaLanguageRow(0);
            UpdateAction(1000);
        }

        public void UpdateMailPassword(string mailPassword)
        {
            MailPassword = mailPassword;
        }

        public void UpdateMail(string mail)
        {
            Mail = mail;
        }

        public void UpdateStatus(bool status)
        {
            Status = status;
        }

        public void UpdateCaptcha(string captcha)
        {
            Captcha = captcha;
        }

        public void UpdateCaptchaUrl(string captchaUrl)
        {
            CaptchaUrl = captchaUrl;
        }

        public void UpdateCaptchaLanguageRow(int captchaLanguageRow)
        {
            CaptchaLanguageRow = captchaLanguageRow;
        }
    }
}
