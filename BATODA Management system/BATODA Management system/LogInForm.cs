using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BATODA_Management_system
{
    public partial class LogInForm : Form
        
    {
        Timer timer = new Timer();
        MainScreenForm mainScreenForm;
        public LogInForm()
        {
            
            InitializeComponent();
            loadingPanel.Dock = DockStyle.Fill;
            loadingPanel.Visible = true;
            loadingPanel.BringToFront();
            logoPanel.Hide();

            timer.Interval = 2000;
            timer.Tick += Timer_Tick;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
           timer.Stop();
           loadingPanel.Visible = false;
           logoPanel.Visible = true;
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
           timer.Start();
           loadingPanel.Visible = true;   
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();
            this.Hide();
        }
    }
}
