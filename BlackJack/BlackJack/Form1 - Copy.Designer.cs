namespace BlackJack
{
    partial class Form1
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
            tittleBlackjack = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // tittleBlackjack
            // 
            tittleBlackjack.AutoSize = true;
            tittleBlackjack.Font = new Font("Yu Gothic UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            tittleBlackjack.Location = new Point(390, 51);
            tittleBlackjack.Name = "tittleBlackjack";
            tittleBlackjack.Size = new Size(279, 65);
            tittleBlackjack.TabIndex = 0;
            tittleBlackjack.Text = "BLACKJACK";
            tittleBlackjack.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(595, 471);
            button1.Name = "button1";
            button1.Size = new Size(150, 55);
            button1.TabIndex = 1;
            button1.Text = "Deposit / Withdraw";
            button1.UseVisualStyleBackColor = true;
            button1.Click += playBtn;
            // 
            // button2
            // 
            button2.Location = new Point(304, 471);
            button2.Name = "button2";
            button2.Size = new Size(157, 55);
            button2.TabIndex = 2;
            button2.Text = "PLAY NOW!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DepWidBtn;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 615);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tittleBlackjack);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tittleBlackjack;
        private Button button1;
        private Button button2;
    }
}
