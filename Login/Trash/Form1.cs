using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void OpenPanel(bool admin)
        {
            this.Visible = false;
            user_panel UP = new user_panel(login.Text, admin, null, 0, "");
            UP.Show();

        }
        private void Ok_Click(object sender, EventArgs e)
        {
            go();
        }
        private void go()
        {
            /*string tmp;
            bool admin = false;
            string Login = login.Text;
            string Password = pass.Text;
            DB db = new DB("users.db");
            Password = db.Compute(Password);
            tmp = db.Query("select permission from users where Pass = '" + Password + "' and Name = '" + Login + "' and permission = 2");
            if (tmp != "") OpenPanel(true);
            tmp = db.Query("select permission from users where Pass = '" + Password + "' and Name = '" + Login + "' and permission = 1");
            if (tmp != "") OpenPanel(false);
            else label4.Visible = true;*/
        }
        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                go();
            }
        }

        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                go();
            }
        }
    }
}
