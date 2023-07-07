namespace AccountManager.UI
{
    partial class FormCreator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreator));
            this.TimerReader = new System.Windows.Forms.Timer(this.components);
            this.GroupBoxInformations = new System.Windows.Forms.GroupBox();
            this.ComboBoxQuestion = new System.Windows.Forms.ComboBox();
            this.LabelQuestion = new System.Windows.Forms.Label();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.ComboBoxAddress = new System.Windows.Forms.ComboBox();
            this.TextBoxRow = new System.Windows.Forms.TextBox();
            this.LabelRow = new System.Windows.Forms.Label();
            this.LabelAnswer = new System.Windows.Forms.Label();
            this.TextBoxAnswer = new System.Windows.Forms.TextBox();
            this.ComboBoxDay = new System.Windows.Forms.ComboBox();
            this.ComboBoxMonth = new System.Windows.Forms.ComboBox();
            this.ComboBoxYear = new System.Windows.Forms.ComboBox();
            this.LabelBirthDate = new System.Windows.Forms.Label();
            this.LabelRefreshEMail = new System.Windows.Forms.Label();
            this.LabelEMail = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxNavigate = new System.Windows.Forms.TextBox();
            this.GroupBoxBrowser = new System.Windows.Forms.GroupBox();
            this.GroupBoxInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerReader
            // 
            this.TimerReader.Enabled = true;
            this.TimerReader.Interval = 2000;
            this.TimerReader.Tick += new System.EventHandler(this.TimerReader_Tick);
            // 
            // GroupBoxInformations
            // 
            this.GroupBoxInformations.Controls.Add(this.ComboBoxQuestion);
            this.GroupBoxInformations.Controls.Add(this.LabelQuestion);
            this.GroupBoxInformations.Controls.Add(this.LabelAddress);
            this.GroupBoxInformations.Controls.Add(this.ComboBoxAddress);
            this.GroupBoxInformations.Controls.Add(this.TextBoxRow);
            this.GroupBoxInformations.Controls.Add(this.LabelRow);
            this.GroupBoxInformations.Controls.Add(this.LabelAnswer);
            this.GroupBoxInformations.Controls.Add(this.TextBoxAnswer);
            this.GroupBoxInformations.Controls.Add(this.ComboBoxDay);
            this.GroupBoxInformations.Controls.Add(this.ComboBoxMonth);
            this.GroupBoxInformations.Controls.Add(this.ComboBoxYear);
            this.GroupBoxInformations.Controls.Add(this.LabelBirthDate);
            this.GroupBoxInformations.Controls.Add(this.LabelRefreshEMail);
            this.GroupBoxInformations.Controls.Add(this.LabelEMail);
            this.GroupBoxInformations.Controls.Add(this.TextBoxEmail);
            this.GroupBoxInformations.Controls.Add(this.ButtonStart);
            this.GroupBoxInformations.Controls.Add(this.LabelPassword);
            this.GroupBoxInformations.Controls.Add(this.TextBoxPassword);
            this.GroupBoxInformations.Controls.Add(this.LabelUserName);
            this.GroupBoxInformations.Controls.Add(this.TextBoxUsername);
            this.GroupBoxInformations.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxInformations.Name = "GroupBoxInformations";
            this.GroupBoxInformations.Size = new System.Drawing.Size(216, 339);
            this.GroupBoxInformations.TabIndex = 1012;
            this.GroupBoxInformations.TabStop = false;
            this.GroupBoxInformations.Text = "Informations";
            // 
            // ComboBoxQuestion
            // 
            this.ComboBoxQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxQuestion.FormattingEnabled = true;
            this.ComboBoxQuestion.Items.AddRange(new object[] {
            "卒業した小学校は？",
            "好きな食べ物は？",
            "嫌いな食べ物は？",
            "父親の名前は？",
            "母親の名前は？",
            "初恋の人の名前は？",
            "過去に一番はまったゲームは？",
            "ペットの名前は？"});
            this.ComboBoxQuestion.Location = new System.Drawing.Point(6, 229);
            this.ComboBoxQuestion.Name = "ComboBoxQuestion";
            this.ComboBoxQuestion.Size = new System.Drawing.Size(204, 21);
            this.ComboBoxQuestion.TabIndex = 1068;
            // 
            // LabelQuestion
            // 
            this.LabelQuestion.AutoSize = true;
            this.LabelQuestion.Location = new System.Drawing.Point(6, 213);
            this.LabelQuestion.Name = "LabelQuestion";
            this.LabelQuestion.Size = new System.Drawing.Size(83, 13);
            this.LabelQuestion.TabIndex = 1067;
            this.LabelQuestion.Text = "Secret Question";
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Location = new System.Drawing.Point(6, 173);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(45, 13);
            this.LabelAddress.TabIndex = 1066;
            this.LabelAddress.Text = "Address";
            // 
            // ComboBoxAddress
            // 
            this.ComboBoxAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAddress.FormattingEnabled = true;
            this.ComboBoxAddress.Items.AddRange(new object[] {
            "北海道",
            "青森県",
            "岩手県",
            "宮城県",
            "秋田県",
            "山形県",
            "福島県",
            "茨城県",
            "栃木県",
            "群馬県",
            "埼玉県",
            "千葉県",
            "東京都",
            "神奈川県",
            "新潟県",
            "富山県",
            "石川県",
            "福井県",
            "山梨県",
            "長野県",
            "岐阜県",
            "静岡県",
            "愛知県",
            "三重県",
            "滋賀県",
            "京都府",
            "大阪府",
            "兵庫県",
            "奈良県",
            "和歌山県",
            "鳥取県",
            "島根県",
            "岡山県",
            "広島県",
            "山口県",
            "徳島県",
            "香川県",
            "愛媛県",
            "高知県",
            "福岡県",
            "佐賀県",
            "長崎県",
            "熊本県",
            "大分県",
            "宮崎県",
            "鹿児島県",
            "沖縄県"});
            this.ComboBoxAddress.Location = new System.Drawing.Point(6, 189);
            this.ComboBoxAddress.Name = "ComboBoxAddress";
            this.ComboBoxAddress.Size = new System.Drawing.Size(204, 21);
            this.ComboBoxAddress.TabIndex = 1065;
            // 
            // TextBoxRow
            // 
            this.TextBoxRow.Location = new System.Drawing.Point(180, 71);
            this.TextBoxRow.Name = "TextBoxRow";
            this.TextBoxRow.Size = new System.Drawing.Size(30, 20);
            this.TextBoxRow.TabIndex = 1064;
            this.TextBoxRow.Text = "1";
            this.TextBoxRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelRow
            // 
            this.LabelRow.AutoSize = true;
            this.LabelRow.Location = new System.Drawing.Point(177, 55);
            this.LabelRow.Name = "LabelRow";
            this.LabelRow.Size = new System.Drawing.Size(25, 13);
            this.LabelRow.TabIndex = 1063;
            this.LabelRow.Text = "Sıra";
            // 
            // LabelAnswer
            // 
            this.LabelAnswer.AutoSize = true;
            this.LabelAnswer.Location = new System.Drawing.Point(6, 253);
            this.LabelAnswer.Name = "LabelAnswer";
            this.LabelAnswer.Size = new System.Drawing.Size(121, 13);
            this.LabelAnswer.TabIndex = 1060;
            this.LabelAnswer.Text = "Secret Question Answer";
            // 
            // TextBoxAnswer
            // 
            this.TextBoxAnswer.Location = new System.Drawing.Point(6, 269);
            this.TextBoxAnswer.Name = "TextBoxAnswer";
            this.TextBoxAnswer.Size = new System.Drawing.Size(204, 20);
            this.TextBoxAnswer.TabIndex = 1059;
            this.TextBoxAnswer.Text = "cansyn";
            // 
            // ComboBoxDay
            // 
            this.ComboBoxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDay.FormattingEnabled = true;
            this.ComboBoxDay.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922"});
            this.ComboBoxDay.Location = new System.Drawing.Point(148, 149);
            this.ComboBoxDay.Name = "ComboBoxDay";
            this.ComboBoxDay.Size = new System.Drawing.Size(62, 21);
            this.ComboBoxDay.TabIndex = 1058;
            // 
            // ComboBoxMonth
            // 
            this.ComboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMonth.FormattingEnabled = true;
            this.ComboBoxMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.ComboBoxMonth.Location = new System.Drawing.Point(80, 149);
            this.ComboBoxMonth.Name = "ComboBoxMonth";
            this.ComboBoxMonth.Size = new System.Drawing.Size(62, 21);
            this.ComboBoxMonth.TabIndex = 1057;
            this.ComboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.BirthDate_SelectedIndexChanged);
            // 
            // ComboBoxYear
            // 
            this.ComboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxYear.FormattingEnabled = true;
            this.ComboBoxYear.Items.AddRange(new object[] {
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922"});
            this.ComboBoxYear.Location = new System.Drawing.Point(6, 149);
            this.ComboBoxYear.Name = "ComboBoxYear";
            this.ComboBoxYear.Size = new System.Drawing.Size(68, 21);
            this.ComboBoxYear.TabIndex = 1056;
            this.ComboBoxYear.SelectedIndexChanged += new System.EventHandler(this.BirthDate_SelectedIndexChanged);
            // 
            // LabelBirthDate
            // 
            this.LabelBirthDate.AutoSize = true;
            this.LabelBirthDate.Location = new System.Drawing.Point(6, 133);
            this.LabelBirthDate.Name = "LabelBirthDate";
            this.LabelBirthDate.Size = new System.Drawing.Size(54, 13);
            this.LabelBirthDate.TabIndex = 1055;
            this.LabelBirthDate.Text = "Birth Date";
            // 
            // LabelRefreshEMail
            // 
            this.LabelRefreshEMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelRefreshEMail.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.LabelRefreshEMail.Location = new System.Drawing.Point(196, 32);
            this.LabelRefreshEMail.Name = "LabelRefreshEMail";
            this.LabelRefreshEMail.Size = new System.Drawing.Size(14, 20);
            this.LabelRefreshEMail.TabIndex = 1054;
            this.LabelRefreshEMail.Text = "q";
            this.LabelRefreshEMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelRefreshEMail.Click += new System.EventHandler(this.LabelRefreshEMail_Click);
            // 
            // LabelEMail
            // 
            this.LabelEMail.AutoSize = true;
            this.LabelEMail.Location = new System.Drawing.Point(6, 16);
            this.LabelEMail.Name = "LabelEMail";
            this.LabelEMail.Size = new System.Drawing.Size(32, 13);
            this.LabelEMail.TabIndex = 1053;
            this.LabelEMail.Text = "Email";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(6, 32);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.ReadOnly = true;
            this.TextBoxEmail.Size = new System.Drawing.Size(184, 20);
            this.TextBoxEmail.TabIndex = 1052;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(6, 295);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(204, 38);
            this.ButtonStart.TabIndex = 1051;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(6, 94);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(84, 13);
            this.LabelPassword.TabIndex = 1050;
            this.LabelPassword.Text = "Game Password";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(6, 110);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(204, 20);
            this.TextBoxPassword.TabIndex = 40;
            this.TextBoxPassword.Text = "Pass223";
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Location = new System.Drawing.Point(6, 55);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(91, 13);
            this.LabelUserName.TabIndex = 1020;
            this.LabelUserName.Text = "Game User Name";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(6, 71);
            this.TextBoxUsername.MaxLength = 9;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(168, 20);
            this.TextBoxUsername.TabIndex = 10;
            this.TextBoxUsername.Text = "kosyn";
            this.TextBoxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxUsername_KeyPress);
            // 
            // TextBoxNavigate
            // 
            this.TextBoxNavigate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNavigate.Location = new System.Drawing.Point(234, 549);
            this.TextBoxNavigate.Name = "TextBoxNavigate";
            this.TextBoxNavigate.ReadOnly = true;
            this.TextBoxNavigate.Size = new System.Drawing.Size(780, 20);
            this.TextBoxNavigate.TabIndex = 1013;
            // 
            // GroupBoxBrowser
            // 
            this.GroupBoxBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxBrowser.Location = new System.Drawing.Point(234, 12);
            this.GroupBoxBrowser.Name = "GroupBoxBrowser";
            this.GroupBoxBrowser.Size = new System.Drawing.Size(780, 531);
            this.GroupBoxBrowser.TabIndex = 1014;
            this.GroupBoxBrowser.TabStop = false;
            this.GroupBoxBrowser.Text = "Browser";
            // 
            // FormCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 581);
            this.Controls.Add(this.TextBoxNavigate);
            this.Controls.Add(this.GroupBoxBrowser);
            this.Controls.Add(this.GroupBoxInformations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreator";
            this.Text = "Account Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCreator_FormClosing);
            this.GroupBoxInformations.ResumeLayout(false);
            this.GroupBoxInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TimerReader;
        private System.Windows.Forms.GroupBox GroupBoxInformations;
        private System.Windows.Forms.Label LabelRefreshEMail;
        private System.Windows.Forms.Label LabelEMail;
        public System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label LabelPassword;
        public System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelUserName;
        public System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.GroupBox GroupBoxBrowser;
        private System.Windows.Forms.Label LabelBirthDate;
        private System.Windows.Forms.ComboBox ComboBoxDay;
        private System.Windows.Forms.ComboBox ComboBoxMonth;
        private System.Windows.Forms.ComboBox ComboBoxYear;
        private System.Windows.Forms.Label LabelAnswer;
        public System.Windows.Forms.TextBox TextBoxAnswer;
        public System.Windows.Forms.TextBox TextBoxNavigate;
        public System.Windows.Forms.TextBox TextBoxRow;
        private System.Windows.Forms.Label LabelRow;
        public System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.ComboBox ComboBoxQuestion;
        private System.Windows.Forms.Label LabelQuestion;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.ComboBox ComboBoxAddress;
    }
}