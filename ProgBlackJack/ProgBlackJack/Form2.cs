using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace ProgBlackJack
{
    public partial class Form2 : Form
    {
        //VARIABLES
        private string registeredUsername = "";
        private string registeredPassword = "";
        private decimal balance = 0.00m;

        public Form2()
        {
            InitializeComponent();
            loginPanel.Visible = true;


            //DEFAULT SHIT
            loginPanel.BringToFront();
            signupPanel.Hide();
            mainMenuPanel.Hide();
            topBarPanel.Hide();
        }

        //LOGIN BUTTON LOGEK
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = loginusernameTextbox.Text;
            string password = loginPasswordTextbox.Text;

            if (string.IsNullOrWhiteSpace(registeredUsername) || string.IsNullOrWhiteSpace(registeredPassword))
            {
                MessageBox.Show("No account registered. Please sign up first.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username == registeredUsername && password == registeredPassword)
            {

                mainMenu();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginPasswordTextbox.Text = "";
            }
        }


        //SIGN-UP BUTTON LOGEK
        private void signupButton_Click(object sender, EventArgs e)
        {
            string username = signupUsernameTextbox.Text;
            string password = signupPasswordTextbox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            registeredUsername = username;
            registeredPassword = password;

            MessageBox.Show("Sign Up successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            signupPanel.Hide();
            loginPanel.Show();

            signupUsernameTextbox.Text = "";
            signupPasswordTextbox.Text = "";
        }



        //SWITCH TO SIGN-UP 
        private void switchTosignupButton_Click(object sender, EventArgs e)
        {
            signupPanel.Visible = true;
            loginPanel.Hide();
        }

        //SWITCH TO LOG IN
        private void switchToLoginButton_Click(object sender, EventArgs e)
        {
            loginPanel.Show();
            signupPanel.Hide();
        }

        private void mainMenu()
        {
            MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            wellcomeLabel.Text = $"Welcome, {registeredUsername}!";
            balanceLabel.Text = $"Available Balance: ₱{balance:F2}";
            mainMenuPanel.Show();
            loginPanel.Hide();
            topBarPanel.Show();
        }

        //CHECKER
        private void loginusernameTextbox_TextChanged(object sender, EventArgs e)
        {
            loginButton.Enabled = !string.IsNullOrWhiteSpace(loginusernameTextbox.Text) && !string.IsNullOrWhiteSpace(loginPasswordTextbox.Text);
        }

        private void loginPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            loginButton.Enabled = !string.IsNullOrWhiteSpace(loginusernameTextbox.Text) && !string.IsNullOrWhiteSpace(loginPasswordTextbox.Text);
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
            signupButton.Enabled = !string.IsNullOrWhiteSpace(signupUsernameTextbox.Text) && !string.IsNullOrWhiteSpace(signupPasswordTextbox.Text);
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            signupButton.Enabled = !string.IsNullOrWhiteSpace(signupUsernameTextbox.Text) && !string.IsNullOrWhiteSpace(signupPasswordTextbox.Text);
        }


        //EXTRA
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void wellcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void forgotPassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void balanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void sandwichPicBox_Click(object sender, EventArgs e)
        {

        }

        private void topBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

