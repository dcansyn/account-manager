namespace AccountManager.UI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.GroupBoxNavigate = new System.Windows.Forms.GroupBox();
            this.ButtonLoadUrl = new System.Windows.Forms.Button();
            this.TextBoxUrl = new System.Windows.Forms.TextBox();
            this.GroupBoxBrowser = new System.Windows.Forms.GroupBox();
            this.MenuGlobal = new System.Windows.Forms.MenuStrip();
            this.MenuAccountCreator = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxNavigate.SuspendLayout();
            this.MenuGlobal.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxNavigate
            // 
            this.GroupBoxNavigate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxNavigate.Controls.Add(this.ButtonLoadUrl);
            this.GroupBoxNavigate.Controls.Add(this.TextBoxUrl);
            this.GroupBoxNavigate.Location = new System.Drawing.Point(12, 39);
            this.GroupBoxNavigate.Name = "GroupBoxNavigate";
            this.GroupBoxNavigate.Size = new System.Drawing.Size(776, 52);
            this.GroupBoxNavigate.TabIndex = 0;
            this.GroupBoxNavigate.TabStop = false;
            // 
            // ButtonLoadUrl
            // 
            this.ButtonLoadUrl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonLoadUrl.Location = new System.Drawing.Point(694, 12);
            this.ButtonLoadUrl.Name = "ButtonLoadUrl";
            this.ButtonLoadUrl.Size = new System.Drawing.Size(76, 32);
            this.ButtonLoadUrl.TabIndex = 1;
            this.ButtonLoadUrl.Text = "Go";
            this.ButtonLoadUrl.UseVisualStyleBackColor = true;
            this.ButtonLoadUrl.Click += new System.EventHandler(this.ButtonLoadUrl_Click);
            // 
            // TextBoxUrl
            // 
            this.TextBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxUrl.Location = new System.Drawing.Point(10, 19);
            this.TextBoxUrl.Name = "TextBoxUrl";
            this.TextBoxUrl.Size = new System.Drawing.Size(678, 20);
            this.TextBoxUrl.TabIndex = 0;
            // 
            // GroupBoxBrowser
            // 
            this.GroupBoxBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxBrowser.Location = new System.Drawing.Point(12, 97);
            this.GroupBoxBrowser.Name = "GroupBoxBrowser";
            this.GroupBoxBrowser.Size = new System.Drawing.Size(776, 381);
            this.GroupBoxBrowser.TabIndex = 1;
            this.GroupBoxBrowser.TabStop = false;
            this.GroupBoxBrowser.Text = "Browser";
            // 
            // MenuGlobal
            // 
            this.MenuGlobal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MenuGlobal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAccountCreator});
            this.MenuGlobal.Location = new System.Drawing.Point(0, 0);
            this.MenuGlobal.Name = "MenuGlobal";
            this.MenuGlobal.Size = new System.Drawing.Size(800, 24);
            this.MenuGlobal.TabIndex = 4;
            this.MenuGlobal.Text = "menuStrip1";
            // 
            // MenuAccountCreator
            // 
            this.MenuAccountCreator.Name = "MenuAccountCreator";
            this.MenuAccountCreator.Size = new System.Drawing.Size(106, 20);
            this.MenuAccountCreator.Text = "Account Creator";
            this.MenuAccountCreator.Click += new System.EventHandler(this.MenuAccountCreator_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.GroupBoxBrowser);
            this.Controls.Add(this.GroupBoxNavigate);
            this.Controls.Add(this.MenuGlobal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuGlobal;
            this.Name = "FormMain";
            this.Text = "Account Manager Web Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.GroupBoxNavigate.ResumeLayout(false);
            this.GroupBoxNavigate.PerformLayout();
            this.MenuGlobal.ResumeLayout(false);
            this.MenuGlobal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxNavigate;
        private System.Windows.Forms.GroupBox GroupBoxBrowser;
        private System.Windows.Forms.MenuStrip MenuGlobal;
        private System.Windows.Forms.ToolStripMenuItem MenuAccountCreator;
        private System.Windows.Forms.Button ButtonLoadUrl;
        private System.Windows.Forms.TextBox TextBoxUrl;
    }
}

