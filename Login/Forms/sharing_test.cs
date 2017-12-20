using Login;
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

namespace explorator
{
    public partial class sharing_test : Form
    {
        private user_panel main = null;
        private Button point = null;
        static DB dB = new DB("files.db");
        Sharing Sharing = new Sharing(dB);
        List<CheckBox> boxes = new List<CheckBox>();

        public sharing_test(user_panel main, Button tmp, int id)
        {
            main = main as user_panel;
            point = tmp;
            InitializeComponent();
            u_id.Text = id.ToString();
        }

        public void InitializeBoxes()
        {
            boxes.Add(prm_0);
            boxes.Add(prm_1);
            boxes.Add(prm_2);
            boxes.Add(prm_3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            error.Visible = false;
            List<bool> check = new List<bool>();
            for(int i = 0; i < boxes.Count; i++)
            {
                //System.Console.WriteLine("x");
                check.Add(boxes[i].Checked);
            }

            int file_id = 0;
            int us_id = 0 ;
            if (Int32.TryParse(f_id.Text, out file_id) && Int32.TryParse(u_id.Text, out us_id))
            {
                if(Sharing.Start(file_id, us_id, check) == false)
                {
                    error.Text = "Permission set is already used";
                    error.Visible = true;
                }
            }
            else
            {
                error.Text = "Convert error";
                error.Visible = true;
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            error.Visible = false;
            int file_id = 0;
            int us_id = 0;
            if (Int32.TryParse(f_id.Text, out file_id) && Int32.TryParse(u_id.Text, out us_id))
            {
                Sharing.Stop(file_id, us_id);
            }
            else
            {
                error.Text = "Convert error";
                error.Visible = true;
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            error.Visible = false;
            List<bool> check = new List<bool>();
            for (int i = 0; i < boxes.Count; i++)
            {
                //System.Console.WriteLine("x");
                check.Add(boxes[i].Checked);
            }

            int file_id = 0;
            int us_id = 0;
            if (Int32.TryParse(f_id.Text, out file_id) && Int32.TryParse(u_id.Text, out us_id))
            {
                if(Sharing.Update(file_id, us_id, check) == false)
                {
                    error.Text = "Permission set does not exist";
                    error.Visible = true;
                }
            }
            else
            {
                error.Text = "Convert error";
                error.Visible = true;
            }
        }

        private void sharing_test_Shown(object sender, EventArgs e)
        {
            point.Enabled = false;
        }

        private void sharing_test_FormClosed(object sender, FormClosedEventArgs e)
        {
            point.Enabled = true;
        }

        private void getperm_Click(object sender, EventArgs e)
        {
            InitializeBoxes();
            int file_id = 0;
            int us_id = 0;
            if (Int32.TryParse(f_id.Text, out file_id) && Int32.TryParse(u_id.Text, out us_id))
            {
                List<bool> permission = new List<bool>();
                permission = Sharing.Get_Perm(file_id, us_id);
                for(int i = 0; i < permission.Count; i++)
                {
                    boxes[i].Checked = permission[i];
                }
            }
            else
            {
                error.Text = "Convert error";
                error.Visible = true;
            }
        }
    }
}
