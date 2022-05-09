using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.Core.Enums
{
    public enum StepType
    {
        MailInbox,
        GameEmailRegister,
        GameEmailRegisterCompleted,
        MailInboxEmailWaiting,
        MailInboxEmailArrived,
        GameAccountRegister,
        GameAccountRegisterCompleted,
        GameAccountCaptcha,
        GameAccountCaptchaError,
        GameAccountCaptchaCompleted,
        ResetMailInbox,
    }
}
