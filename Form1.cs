using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mad4Road
{
    public partial class Form1 : Form
    {
        public const string PASSWORD = "2FAST4U#";
        public string username;
        public int passwordIncorrectCount=0;
        public int carLoanAmount=0;
       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void welcomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            loginGroupBox.Visible = true;
            welcomePanel.Visible = false;
        }

        private void loginButton2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(passwordTextBox.Text))
            {
                passwordTextBox.Focus();
                MessageBox.Show("PLease enter a valid Password.", "Missing Pasword", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (PASSWORD == passwordTextBox.Text)
                {
                    welcomeGroupBox.Visible = true;
                    loginGroupBox.Visible = false;
                }
                else
                {
                    MessageBox.Show("Entered Password is incorrect. Please try again.", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    passwordIncorrectCount++;
                    passwordTextBox.Text = string.Empty;
                    if (passwordIncorrectCount == 2)
                    {
                        MessageBox.Show("Too many incorrect attempts.", "Closing application.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                }
            }
        }

        private void welcomeGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void interestRateLabel_Click(object sender, EventArgs e)
        {

        }

        private void repaymentLabel_Click(object sender, EventArgs e)
        {

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            displayPanel.Visible = true;
           
        }
    }
}
