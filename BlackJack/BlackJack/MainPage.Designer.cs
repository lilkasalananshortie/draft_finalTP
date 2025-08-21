namespace BlackJack
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            tittleBlackjack = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tittleBlackjack
            // 
            tittleBlackjack.AutoSize = true;
            tittleBlackjack.Font = new Font("Yu Gothic UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            tittleBlackjack.Location = new Point(12, 9);
            tittleBlackjack.Name = "tittleBlackjack";
            tittleBlackjack.Size = new Size(279, 65);
            tittleBlackjack.TabIndex = 0;
            tittleBlackjack.Text = "BLACKJACK";
            tittleBlackjack.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 99);
            button2.Name = "button2";
            button2.Size = new Size(210, 119);
            button2.TabIndex = 2;
            button2.Text = "PLAY NOW!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += playBtn;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-33, -21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(993, 694);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 615);
            Controls.Add(button2);
            Controls.Add(tittleBlackjack);
            Controls.Add(pictureBox1);
            Name = "MainPage";
            Text = "BlackJack Powered by BULEX";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tittleBlackjack;
        private Button button2;
        private PictureBox pictureBox1;
    }
}
