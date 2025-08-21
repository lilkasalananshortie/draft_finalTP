using System.Windows.Forms.VisualStyles;

namespace BlackJack
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
          

        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void playBtn(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormClosed += (s, args) => this.Show();
            form2.Show();
            this.Hide();
        }


        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
