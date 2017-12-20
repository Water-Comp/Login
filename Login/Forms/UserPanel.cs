using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using explorator;

namespace Login
{
    public partial class user_panel : Form
    {
        string password;
        int U_ID;
        private login_Form main = null;
        bool admin;
        string login;
        List<string> elements = new List<string>();
        Stack<string> path = new Stack<string>();

        public user_panel(string Login, bool admin1, login_Form form, int u_id, string pass)
        {
            password = pass;
            U_ID = u_id;
            login = Login;
            InitializeComponent();
            tytul.Text = "Witaj " + Login;
            source.Text = Login + "://";
            main = form as login_Form;
            admin = admin1;
            if(!admin)
            {
                button3.Text = "Zarządzaj kontem";
            }
            foreach(string element in SerchCild("main"))
            {
                elements.Add(element);
            }
            explorer.DataSource = null;
            explorer.DataSource = elements;
            path.Push("main");
            System.Console.WriteLine(password);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void user_panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            content.SelectedCard = "Card2";
        }
        
        private string[] SerchCild(string parent)
        {
            DB db = new DB("files.db");
            string result =  db.Query("select Name from structure where Mother_Folder = '" + parent + "'");
            char litera = 'a';
            string[] outer;
            int tmp = db.CountResults("select Name from structure where Mother_Folder = '" + parent + "'");
            outer = new string[tmp];
            int j = 0;
            for(int i = 0; i < result.Length; i++)
            {
                litera = result[i];
                if (litera != ' ') outer[j] += litera;
                else
                {
                    j++;
                    i += 2;
                }
            }
            return outer;
        }
        

        private void explorer_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            content.SelectedCard = "Card1";
        }

        private void explorer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        public void ChildFile()
        {
            Console.WriteLine(explorer.SelectedIndex);
            if (explorer.SelectedIndex != -1)
            {
                Console.WriteLine("x");
                string selected = explorer.SelectedItem.ToString();
                path.Push(selected);
                elements.Clear();
                foreach (string element in SerchCild(selected))
                {
                    elements.Add(element);
                }
                explorer.DataSource = null;
                explorer.DataSource = elements;
            }
        }

        public void GoBack()
        {
            string tmp = path.Pop();
            if (tmp == "main")
            {
                path.Push("main");
            }
            else
            {
                elements.Clear();
                tmp = path.Peek();
                foreach (string element in SerchCild(tmp))
                {
                    elements.Add(element);
                }
                explorer.DataSource = null;
                explorer.DataSource = elements;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void explorer_MouseUp(object sender, MouseEventArgs e)
        {
            ChildFile();
        }

        private void tmp_test_Click(object sender, EventArgs e)
        {
            sharing_test sharing_Test = new sharing_test(this, tmp_test, U_ID);
            sharing_Test.Show();
        }
    }
}
