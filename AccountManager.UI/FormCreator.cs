using AccountManager.Core.Consts;
using AccountManager.Core.Domains;
using AccountManager.Core.Enums;
using AccountManager.UI.Events;
using AccountManager.UI.Extensions;
using AccountManager.UI.Handlers;
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountManager.UI
{
    public partial class FormCreator : Form
    {
        public ChromiumWebBrowser _browser;

        public FormCreator()
        {
            InitializeComponent();

            _browser = new ChromiumWebBrowser(App.MailboxUrl)
            {
                RequestHandler = new CustomRequestHandler(this.OnResourceLoadComplete),
                JsDialogHandler = new CustomJsDialogHandler(),
                Dock = DockStyle.Fill
            };

            _browser.IsBrowserInitializedChanged += this.OnInitializedChanged;
            _browser.AddressChanged += this.OnAddressChanged;
            _browser.FrameLoadEnd += this.OnFrameLoadEnd;

            GroupBoxBrowser.Controls.Add(_browser);

            foreach (var item in GroupBoxInformations.Controls.OfType<Control>())
                if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = 0;
        }

        private void TimerReader_Tick(object sender, EventArgs e) 
        {
            this.ReaderTick(); 
        }

        private void TextBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) ||
                char.IsLetter(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar) ||
                char.IsSurrogate(e.KeyChar) ||
                char.IsSeparator(e.KeyChar) ||
                char.IsSymbol(e.KeyChar))
                return;

            e.Handled = true;
        }

        private void BirthDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxDay.Items.Clear();
            if (int.TryParse(ComboBoxYear.Text, out int year) && int.TryParse(ComboBoxMonth.Text, out int month))
                for (int i = 1; i <= new DateTime(year, month, 1).AddMonths(1).AddSeconds(-1).Day; i++)
                    ComboBoxDay.Items.Add(i.ToString("D2"));

            if (ComboBoxDay.Items.Count > 0)
                ComboBoxDay.SelectedIndex = 0;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Cef.GetGlobalCookieManager().DeleteCookies();

            if (ButtonStart.Text == "Stop")
            {
                ButtonStart.Text = "Start";

                if (App.Account != null)
                    App.Account.UpdateStatus(false);

                return;
            }

            ButtonStart.Text = "Stop";

            var inputs = new[]
            {
                TextBoxRow.Text,
                ComboBoxYear.Text,
                ComboBoxMonth.Text,
                ComboBoxDay.Text,
                ComboBoxAddress.Text,
                ComboBoxQuestion.Text,
                TextBoxEmail.Text,
                TextBoxUsername.Text,
                TextBoxPassword.Text,
                TextBoxAnswer.Text,
            };

            if (inputs.Any(x => string.IsNullOrEmpty(x)))
            {
                MessageBox.Show("Please enter your information.");
                return;
            }

            if (!int.TryParse(TextBoxRow.Text, out int row))
            {
                MessageBox.Show("You entered an invalid row number.");
                return;
            }

            if (!int.TryParse(ComboBoxYear.Text, out int year) ||
                !int.TryParse(ComboBoxMonth.Text, out int month) ||
                !int.TryParse(ComboBoxDay.Text, out int day))
            {
                MessageBox.Show("Please enter a valid date of birth.");
                return;
            }

            App.Account = new Account(row,
                TextBoxEmail.Text,
                TextBoxUsername.Text,
                TextBoxPassword.Text,
                new DateTime(year, month, day),
                ComboBoxAddress.Text,
                ComboBoxQuestion.Text,
                TextBoxAnswer.Text);

            App.Account.UpdateStatus(true);

            _browser.LoadUrl(App.MailboxUrl);
        }

        private void LabelRefreshEMail_Click(object sender, EventArgs e)
        {
            if (!App.BrowserIsReady) return;

            try
            {
                Cef.GetGlobalCookieManager().DeleteCookies();

                if (App.Account != null)
                    App.Account.UpdateStep(StepType.ResetMailInbox);
                else if (_browser.Address == App.MailboxUrl)
                    _browser.ClickElement("#logout");
                else
                    _browser.LoadUrl(App.MailboxUrl);
            }
            catch (Exception) { }
        }

        private void FormCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            var main = new FormMain();
            main.Show();
        }
    }
}
