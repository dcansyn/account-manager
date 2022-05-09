using AccountManager.Core.Consts;
using AccountManager.UI.Extensions;
using AccountManager.UI.Handlers;
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Windows.Forms;

namespace AccountManager.UI
{
    public partial class FormMain : Form
    {
        public ChromiumWebBrowser _browser;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _browser = new ChromiumWebBrowser(App.GameEmailRegisterUrl) { Dock = DockStyle.Fill };

            _browser.IsBrowserInitializedChanged += new EventHandler(delegate (object send, EventArgs evnt)
            {
                _browser.ChangeAcceptLanguage("ja");
            });

            _browser.AddressChanged += new EventHandler<AddressChangedEventArgs>(delegate (object send, AddressChangedEventArgs evnt)
            {
                if (TextBoxUrl.InvokeRequired)
                    TextBoxUrl.Invoke(new MethodInvoker(delegate { TextBoxUrl.Text = evnt.Address.ToString(); }));
            });

            GroupBoxBrowser.Controls.Add(_browser);
        }

        private void ButtonLoadUrl_Click(object sender, EventArgs e)
        {
            _browser.Load(TextBoxUrl.Text);
        }

        private void MenuAccountCreator_Click(object sender, EventArgs e)
        {
            var creator = new FormCreator();
            creator.Show();
            Hide();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
