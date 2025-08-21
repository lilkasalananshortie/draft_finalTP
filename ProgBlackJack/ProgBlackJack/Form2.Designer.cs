namespace ProgBlackJack
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label3 = new Label();
            signupPasswordTextbox = new TextBox();
            signupUsernameTextbox = new TextBox();
            loginPanel = new Panel();
            label2 = new Label();
            forgotPassLink = new LinkLabel();
            label7 = new Label();
            switchTosignupButton = new Button();
            loginPasswordTextbox = new TextBox();
            loginButton = new Button();
            passwrordLabel = new Label();
            label1 = new Label();
            loginLabel = new Label();
            loginusernameTextbox = new TextBox();
            signupPanel = new Panel();
            label10 = new Label();
            getHelpLink = new LinkLabel();
            label8 = new Label();
            switchToLoginButton = new Button();
            signupButton = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            mainMenuPanel = new Panel();
            wellcomeLabel = new Label();
            depositButton = new Button();
            widthdrawButton = new Button();
            balanceLabel = new Label();
            label9 = new Label();
            topBarPanel = new Panel();
            sandwichPicBox = new PictureBox();
            loginPanel.SuspendLayout();
            signupPanel.SuspendLayout();
            topBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sandwichPicBox).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(314, 9);
            label3.Name = "label3";
            label3.Size = new Size(306, 45);
            label3.TabIndex = 2;
            label3.Text = "Black Jack Deluxe";
            // 
            // signupPasswordTextbox
            // 
            signupPasswordTextbox.Font = new Font("Segoe UI", 12F);
            signupPasswordTextbox.Location = new Point(142, 209);
            signupPasswordTextbox.Name = "signupPasswordTextbox";
            signupPasswordTextbox.Size = new Size(189, 29);
            signupPasswordTextbox.TabIndex = 5;
            signupPasswordTextbox.TextChanged += passwordTextbox_TextChanged;
            // 
            // signupUsernameTextbox
            // 
            signupUsernameTextbox.Font = new Font("Segoe UI", 12F);
            signupUsernameTextbox.Location = new Point(142, 165);
            signupUsernameTextbox.Name = "signupUsernameTextbox";
            signupUsernameTextbox.Size = new Size(189, 29);
            signupUsernameTextbox.TabIndex = 6;
            signupUsernameTextbox.TextChanged += usernameTextbox_TextChanged;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.DarkSlateGray;
            loginPanel.Controls.Add(label2);
            loginPanel.Controls.Add(forgotPassLink);
            loginPanel.Controls.Add(label7);
            loginPanel.Controls.Add(switchTosignupButton);
            loginPanel.Controls.Add(loginPasswordTextbox);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(passwrordLabel);
            loginPanel.Controls.Add(label1);
            loginPanel.Controls.Add(loginLabel);
            loginPanel.Controls.Add(loginusernameTextbox);
            loginPanel.Location = new Point(26, 94);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(413, 445);
            loginPanel.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 76);
            label2.Name = "label2";
            label2.Size = new Size(306, 45);
            label2.TabIndex = 9;
            label2.Text = "Black Jack Deluxe";
            // 
            // forgotPassLink
            // 
            forgotPassLink.AutoSize = true;
            forgotPassLink.Location = new Point(169, 303);
            forgotPassLink.Name = "forgotPassLink";
            forgotPassLink.Size = new Size(60, 15);
            forgotPassLink.TabIndex = 7;
            forgotPassLink.TabStop = true;
            forgotPassLink.Text = "linkLabel1";
            forgotPassLink.LinkClicked += forgotPassLink_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(253, 343);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 6;
            label7.Text = "Create account? ";
            // 
            // switchTosignupButton
            // 
            switchTosignupButton.Font = new Font("Segoe UI", 11F);
            switchTosignupButton.Location = new Point(276, 366);
            switchTosignupButton.Name = "switchTosignupButton";
            switchTosignupButton.Size = new Size(81, 31);
            switchTosignupButton.TabIndex = 5;
            switchTosignupButton.Text = "Sign-up";
            switchTosignupButton.UseVisualStyleBackColor = true;
            switchTosignupButton.Click += switchTosignupButton_Click;
            // 
            // loginPasswordTextbox
            // 
            loginPasswordTextbox.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginPasswordTextbox.Location = new Point(123, 209);
            loginPasswordTextbox.Name = "loginPasswordTextbox";
            loginPasswordTextbox.Size = new Size(189, 27);
            loginPasswordTextbox.TabIndex = 4;
            loginPasswordTextbox.TextChanged += loginPasswordTextbox_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(236, 255);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(76, 29);
            loginButton.TabIndex = 3;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // passwrordLabel
            // 
            passwrordLabel.AutoSize = true;
            passwrordLabel.Font = new Font("Segoe UI", 12F);
            passwrordLabel.Location = new Point(34, 209);
            passwrordLabel.Name = "passwrordLabel";
            passwrordLabel.Size = new Size(87, 21);
            passwrordLabel.TabIndex = 3;
            passwrordLabel.Text = "Password : ";
            passwrordLabel.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(29, 173);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 2;
            label1.Text = "Username : ";
            label1.Click += label1_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 15F);
            loginLabel.Location = new Point(169, 121);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(61, 28);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Login";
            // 
            // loginusernameTextbox
            // 
            loginusernameTextbox.Font = new Font("Segoe UI", 12F);
            loginusernameTextbox.Location = new Point(123, 165);
            loginusernameTextbox.Name = "loginusernameTextbox";
            loginusernameTextbox.Size = new Size(189, 29);
            loginusernameTextbox.TabIndex = 0;
            loginusernameTextbox.TextChanged += loginusernameTextbox_TextChanged;
            // 
            // signupPanel
            // 
            signupPanel.BackColor = Color.DarkKhaki;
            signupPanel.Controls.Add(label10);
            signupPanel.Controls.Add(getHelpLink);
            signupPanel.Controls.Add(label8);
            signupPanel.Controls.Add(switchToLoginButton);
            signupPanel.Controls.Add(signupButton);
            signupPanel.Controls.Add(label6);
            signupPanel.Controls.Add(label5);
            signupPanel.Controls.Add(label4);
            signupPanel.Controls.Add(signupUsernameTextbox);
            signupPanel.Controls.Add(signupPasswordTextbox);
            signupPanel.Location = new Point(29, 94);
            signupPanel.Name = "signupPanel";
            signupPanel.Size = new Size(407, 445);
            signupPanel.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Impact", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(61, 76);
            label10.Name = "label10";
            label10.Size = new Size(306, 45);
            label10.TabIndex = 10;
            label10.Text = "Black Jack Deluxe";
            // 
            // getHelpLink
            // 
            getHelpLink.AutoSize = true;
            getHelpLink.Location = new Point(115, 303);
            getHelpLink.Name = "getHelpLink";
            getHelpLink.Size = new Size(193, 15);
            getHelpLink.TabIndex = 10;
            getHelpLink.TabStop = true;
            getHelpLink.Text = "Get help from our customer service";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(208, 343);
            label8.Name = "label8";
            label8.Size = new Size(123, 20);
            label8.TabIndex = 8;
            label8.Text = "Already Sign-up?";
            // 
            // switchToLoginButton
            // 
            switchToLoginButton.Font = new Font("Segoe UI", 11F);
            switchToLoginButton.Location = new Point(239, 366);
            switchToLoginButton.Name = "switchToLoginButton";
            switchToLoginButton.Size = new Size(75, 32);
            switchToLoginButton.TabIndex = 7;
            switchToLoginButton.Text = "Log-In";
            switchToLoginButton.UseVisualStyleBackColor = true;
            switchToLoginButton.Click += switchToLoginButton_Click;
            // 
            // signupButton
            // 
            signupButton.Location = new Point(249, 255);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(82, 31);
            signupButton.TabIndex = 4;
            signupButton.Text = "Sign-Up";
            signupButton.UseVisualStyleBackColor = true;
            signupButton.Click += signupButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(165, 121);
            label6.Name = "label6";
            label6.Size = new Size(82, 28);
            label6.TabIndex = 4;
            label6.Text = "Sign-up";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(48, 173);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 4;
            label5.Text = "Username :";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(53, 209);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 4;
            label4.Text = "Password :";
            // 
            // mainMenuPanel
            // 
            mainMenuPanel.BackColor = Color.PaleGoldenrod;
            mainMenuPanel.Dock = DockStyle.Fill;
            mainMenuPanel.Location = new Point(0, 0);
            mainMenuPanel.Name = "mainMenuPanel";
            mainMenuPanel.Size = new Size(936, 598);
            mainMenuPanel.TabIndex = 8;
            mainMenuPanel.Paint += mainMenuPanel_Paint;
            // 
            // wellcomeLabel
            // 
            wellcomeLabel.AutoSize = true;
            wellcomeLabel.Font = new Font("Segoe UI", 13F);
            wellcomeLabel.Location = new Point(389, 18);
            wellcomeLabel.Name = "wellcomeLabel";
            wellcomeLabel.Size = new Size(100, 25);
            wellcomeLabel.TabIndex = 0;
            wellcomeLabel.Text = "WELCOME ";
            wellcomeLabel.Click += wellcomeLabel_Click;
            // 
            // depositButton
            // 
            depositButton.Font = new Font("Segoe UI", 13F);
            depositButton.Location = new Point(705, 12);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(109, 34);
            depositButton.TabIndex = 4;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = true;
            // 
            // widthdrawButton
            // 
            widthdrawButton.Font = new Font("Segoe UI", 13F);
            widthdrawButton.Location = new Point(581, 12);
            widthdrawButton.Name = "widthdrawButton";
            widthdrawButton.Size = new Size(109, 34);
            widthdrawButton.TabIndex = 3;
            widthdrawButton.Text = "Withdraw";
            widthdrawButton.UseVisualStyleBackColor = true;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI", 13F);
            balanceLabel.Location = new Point(834, 9);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(75, 25);
            balanceLabel.TabIndex = 1;
            balanceLabel.Text = "Balance:";
            balanceLabel.Click += balanceLabel_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(77, 9);
            label9.Name = "label9";
            label9.Size = new Size(306, 45);
            label9.TabIndex = 9;
            label9.Text = "Black Jack Deluxe";
            // 
            // topBarPanel
            // 
            topBarPanel.BackColor = Color.DodgerBlue;
            topBarPanel.Controls.Add(wellcomeLabel);
            topBarPanel.Controls.Add(label9);
            topBarPanel.Controls.Add(widthdrawButton);
            topBarPanel.Controls.Add(depositButton);
            topBarPanel.Controls.Add(sandwichPicBox);
            topBarPanel.Controls.Add(balanceLabel);
            topBarPanel.Dock = DockStyle.Top;
            topBarPanel.Location = new Point(0, 0);
            topBarPanel.Name = "topBarPanel";
            topBarPanel.Size = new Size(936, 65);
            topBarPanel.TabIndex = 9;
            topBarPanel.Paint += topBarPanel_Paint;
            // 
            // sandwichPicBox
            // 
            sandwichPicBox.BackColor = SystemColors.ActiveBorder;
            sandwichPicBox.ErrorImage = Properties.Resources.menu_icon_isolated_on_white_background_web_menu_icon_700_195257701;
            sandwichPicBox.Image = Properties.Resources.menu_icon_isolated_on_white_background_web_menu_icon_700_195257701;
            sandwichPicBox.InitialImage = Properties.Resources.menu_icon_isolated_on_white_background_web_menu_icon_700_195257701;
            sandwichPicBox.Location = new Point(6, 6);
            sandwichPicBox.Name = "sandwichPicBox";
            sandwichPicBox.Size = new Size(56, 51);
            sandwichPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            sandwichPicBox.TabIndex = 0;
            sandwichPicBox.TabStop = false;
            sandwichPicBox.WaitOnLoad = true;
            sandwichPicBox.Click += sandwichPicBox_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(936, 598);
            Controls.Add(topBarPanel);
            Controls.Add(mainMenuPanel);
            Controls.Add(loginPanel);
            Controls.Add(label3);
            Controls.Add(signupPanel);
            ForeColor = Color.Tomato;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "BlackJack Deluxe";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            signupPanel.ResumeLayout(false);
            signupPanel.PerformLayout();
            topBarPanel.ResumeLayout(false);
            topBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sandwichPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox signupPasswordTextbox;
        private TextBox signupUsernameTextbox;
        private Panel loginPanel;
        private TextBox loginusernameTextbox;
        private Panel signupPanel;
        private Label passwrordLabel;
        private Label label1;
        private Label loginLabel;
        private Label label5;
        private Label label4;
        private TextBox loginPasswordTextbox;
        private Label label6;
        private Label label7;
        private Button switchTosignupButton;
        private Label label8;
        private Button switchToLoginButton;
        private Button loginButton;
        private Button signupButton;
        private Panel mainMenuPanel;
        private Label wellcomeLabel;
        private Button widthdrawButton;
        private Label balanceLabel;
        private Button depositButton;
        private LinkLabel forgotPassLink;
        private Label label2;
        private Label label10;
        private LinkLabel getHelpLink;
        private Label label9;
        private Panel topBarPanel;
        private PictureBox sandwichPicBox;
    }
}