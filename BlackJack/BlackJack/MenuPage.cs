using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void vipBtn(object sender, EventArgs e)
        {

        }

        private void extBtn(object sender, EventArgs e)
        {
            this.Close();

        }

        private void loginBtn(object sender, EventArgs e)
        {
            LoginForm form4 = new LoginForm();
            form4.FormClosed += (s, args) => this.Show();
            form4.Show();
            this.Hide();
        }

        private void RegisterBtn(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.FormClosed += (s, args) => this.Show();
            form1.Show();
            this.Hide();


        }



    }
}
