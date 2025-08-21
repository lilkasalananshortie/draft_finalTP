namespace ProgBlackJack
{
    public partial class BlackJack : Form
    {
        public BlackJack()
        {
            InitializeComponent();
        }



        private async void BlackJack_Load(object sender, EventArgs e)
        {
            
            loadingPanel.BringToFront();
            loadingPanel.Visible = true;
            laodingText.Text = "Black Jack Deluxe";
            loadingBarPanel.Style = ProgressBarStyle.Marquee;
            loadingBarPanel.MarqueeAnimationSpeed = 30;
            await Task.Delay(3000);
            loadingPanel.Visible = false;


        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            Form2 loginForm = new Form2();
            loginForm.Show();
            this.Hide();


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void loadingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadingBarPanel_Click(object sender, EventArgs e)
        {

        }

        private void laodingText_Click(object sender, EventArgs e)
        {
           
        }

        private void tittleText_Click(object sender, EventArgs e)
        {
               
        }
    }
}
