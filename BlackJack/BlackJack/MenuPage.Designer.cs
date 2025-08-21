namespace BlackJack
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(823, 105);
            button1.Name = "button1";
            button1.Size = new Size(205, 105);
            button1.TabIndex = 0;
            button1.Text = "PLAY VIP ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += vipBtn;
            // 
            // button2
            // 
            button2.Location = new Point(808, 516);
            button2.Name = "button2";
            button2.Size = new Size(220, 78);
            button2.TabIndex = 1;
            button2.Text = "Go back to home page";
            button2.UseVisualStyleBackColor = true;
            button2.Click += extBtn;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 23F);
            label1.Location = new Point(199, 31);
            label1.Name = "label1";
            label1.Size = new Size(820, 42);
            label1.TabIndex = 2;
            label1.Text = "<--LOG IN / REGIS PAGE / ADS / BACKBTN / VIEWPLAN -->";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 30F);
            button3.Location = new Point(71, 105);
            button3.Name = "button3";
            button3.Size = new Size(164, 67);
            button3.TabIndex = 3;
            button3.Text = "Log in";
            button3.UseVisualStyleBackColor = true;
            button3.Click += loginBtn;
            // 
            // button4
            // 
            button4.Location = new Point(353, 105);
            button4.Name = "button4";
            button4.Size = new Size(170, 121);
            button4.TabIndex = 4;
            button4.Text = "Register";
            button4.UseVisualStyleBackColor = true;
            button4.Click += RegisterBtn;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 620);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "BlackJack Powered by BULEX";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
    }
}