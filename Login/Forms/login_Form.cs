using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Login;

namespace WindowsFormsApp1
{
    public partial class login_Form : Form
    {
        DB dB = new DB("account.db");
        int ID;
        public login_Form()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            login();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login()
        {
            if (dB.VerifyPassword(textBox2.Text , textBox1.Text))
            {
                OpenPanel(true);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                error_login.Text = "Invalid login or password!";
                error_login.Visible = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }

        private void sign_up_button_Click(object sender, EventArgs e)
        {
            back_button.Visible = true;
            panel2.Visible = true;
            panel1.Visible = false;
            error_login.Visible = false;
            //Form2 form2 = new Form2(this);
            //form2.Show();
            //this.Visible = false;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            back_button.Visible = false;
            panel1.Visible = true;
            error_sign_up.Visible = false;
        }

        private void OpenPanel(bool admin)
        {
            this.Visible = false;
            user_panel UP = new user_panel(textBox2.Text, admin, this, dB.get_ID(textBox2.Text), textBox1.Text);
            UP.Show();

        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            string login = username_box.Text.ToUpper();
            if ((password_box.Text == "") || (confirm_box.Text == "") || (username_box.Text == ""))
            {
                error_sign_up.Text = "Each fields are required";
                error_sign_up.Visible = true;
            }
            else if ((dB.Query("Select ID from accounts_list where login = '" + login + "'") != ""))
            {
                error_sign_up.Text = "Username is not unique!";
                error_sign_up.Visible = true;
            } 
            else if ((password_box.Text != confirm_box.Text) || (password_box.Text == ""))
            {
                error_sign_up.Text = "Passwords do not match!";
                error_sign_up.Visible = true;
            }
            else
            {
                dB.CreateNewUser(login, password_box.Text);
                error_sign_up.Visible = false;
                error_login.Text = "Your account is created";
                error_login.Visible = true;
                username_box.Text = "";
                panel2.Visible = false;
                panel1.Visible = true;
                back_button.Visible = false;
            }
            password_box.Text = "";
            confirm_box.Text = "";
        }
    }
}
