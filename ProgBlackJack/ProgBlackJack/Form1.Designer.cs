namespace ProgBlackJack
{
    partial class BlackJack
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJack));
            loginButton = new Button();
            exitButton = new Button();
            loadingPanel = new Panel();
            addTextLabel = new Label();
            loadingBarPanel = new ProgressBar();
            laodingText = new Label();
            tittleText = new Label();
            loadingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.ButtonFace;
            loginButton.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.Location = new Point(419, 241);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(172, 70);
            loginButton.TabIndex = 1;
            loginButton.Text = "Login ";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(936, 571);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(83, 41);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // loadingPanel
            // 
            loadingPanel.BackColor = SystemColors.ActiveCaptionText;
            loadingPanel.Controls.Add(addTextLabel);
            loadingPanel.Controls.Add(loadingBarPanel);
            loadingPanel.Controls.Add(laodingText);
            loadingPanel.Dock = DockStyle.Left;
            loadingPanel.ForeColor = SystemColors.ActiveCaption;
            loadingPanel.Location = new Point(0, 0);
            loadingPanel.Name = "loadingPanel";
            loadingPanel.Size = new Size(1044, 633);
            loadingPanel.TabIndex = 3;
            loadingPanel.Paint += loadingPanel_Paint;
            // 
            // addTextLabel
            // 
            addTextLabel.AutoSize = true;
            addTextLabel.Font = new Font("Segoe UI", 17F);
            addTextLabel.ForeColor = SystemColors.ButtonFace;
            addTextLabel.Location = new Point(407, 352);
            addTextLabel.Name = "addTextLabel";
            addTextLabel.Size = new Size(193, 31);
            addTextLabel.TabIndex = 2;
            addTextLabel.Text = "Loading Assests...";
            // 
            // loadingBarPanel
            // 
            loadingBarPanel.Location = new Point(220, 317);
            loadingBarPanel.MarqueeAnimationSpeed = 30;
            loadingBarPanel.Name = "loadingBarPanel";
            loadingBarPanel.Size = new Size(569, 23);
            loadingBarPanel.TabIndex = 1;
            loadingBarPanel.Click += loadingBarPanel_Click;
            // 
            // laodingText
            // 
            laodingText.AutoSize = true;
            laodingText.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            laodingText.ForeColor = SystemColors.ButtonFace;
            laodingText.Location = new Point(357, 149);
            laodingText.Name = "laodingText";
            laodingText.Size = new Size(302, 48);
            laodingText.TabIndex = 0;
            laodingText.Text = "BlackJack Deluxe";
            laodingText.Click += laodingText_Click;
            // 
            // tittleText
            // 
            tittleText.AutoSize = true;
            tittleText.BackColor = SystemColors.ActiveCaptionText;
            tittleText.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tittleText.ForeColor = SystemColors.ButtonFace;
            tittleText.Location = new Point(357, 169);
            tittleText.Name = "tittleText";
            tittleText.Size = new Size(309, 48);
            tittleText.TabIndex = 4;
            tittleText.Text = "Black Jack Deluxe";
            tittleText.Click += tittleText_Click;
            // 
            // BlackJack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1043, 633);
            Controls.Add(tittleText);
            Controls.Add(loadingPanel);
            Controls.Add(exitButton);
            Controls.Add(loginButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BlackJack";
            RightToLeft = RightToLeft.No;
            Text = "Blackjack Deluxe";
            Load += BlackJack_Load;
            loadingPanel.ResumeLayout(false);
            loadingPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button loginButton;
        private Button exitButton;
        private Panel loadingPanel;
        private ProgressBar loadingBarPanel;
        private Label laodingText;
        private Label addTextLabel;
        private Label tittleText;
    }
}
