namespace WindowsFormsApp1
{
    partial class login_Form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.sign_up_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.log_in = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.error_login = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sign_up = new System.Windows.Forms.Button();
            this.username_box = new System.Windows.Forms.TextBox();
            this.confirm_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.confirm_password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.password_sign = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.error_sign_up = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sign_up_button);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.log_in);
            this.panel1.Controls.Add(this.password);
            this.panel1.Location = new System.Drawing.Point(65, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 250);
            this.panel1.TabIndex = 0;
            // 
            // sign_up_button
            // 
            this.sign_up_button.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sign_up_button.Location = new System.Drawing.Point(5, 200);
            this.sign_up_button.Name = "sign_up_button";
            this.sign_up_button.Size = new System.Drawing.Size(150, 50);
            this.sign_up_button.TabIndex = 4;
            this.sign_up_button.Text = "Sign Up";
            this.sign_up_button.UseVisualStyleBackColor = true;
            this.sign_up_button.Click += new System.EventHandler(this.sign_up_button_Click);
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_button.Location = new System.Drawing.Point(30, 145);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(100, 50);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Log In";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(20, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 33);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(20, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(120, 33);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // log_in
            // 
            this.log_in.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.log_in.Location = new System.Drawing.Point(30, 10);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(100, 23);
            this.log_in.TabIndex = 0;
            this.log_in.Text = "Login";
            this.log_in.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password.Location = new System.Drawing.Point(30, 75);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 23);
            this.password.TabIndex = 0;
            this.password.Text = "Password";
            this.password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // error_login
            // 
            this.error_login.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.error_login.ForeColor = System.Drawing.Color.Crimson;
            this.error_login.Location = new System.Drawing.Point(25, 35);
            this.error_login.Name = "error_login";
            this.error_login.Size = new System.Drawing.Size(250, 25);
            this.error_login.TabIndex = 1;
            this.error_login.Text = "Invalid login or password!";
            this.error_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.error_login.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.sign_up);
            this.panel2.Controls.Add(this.username_box);
            this.panel2.Controls.Add(this.confirm_box);
            this.panel2.Controls.Add(this.password_box);
            this.panel2.Controls.Add(this.confirm_password);
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.password_sign);
            this.panel2.Location = new System.Drawing.Point(65, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 270);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // sign_up
            // 
            this.sign_up.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sign_up.Location = new System.Drawing.Point(5, 215);
            this.sign_up.Name = "sign_up";
            this.sign_up.Size = new System.Drawing.Size(150, 50);
            this.sign_up.TabIndex = 4;
            this.sign_up.Text = "Sign Up";
            this.sign_up.UseVisualStyleBackColor = true;
            this.sign_up.Click += new System.EventHandler(this.sign_up_Click);
            // 
            // username_box
            // 
            this.username_box.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username_box.Location = new System.Drawing.Point(20, 40);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(120, 33);
            this.username_box.TabIndex = 1;
            this.username_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // confirm_box
            // 
            this.confirm_box.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirm_box.Location = new System.Drawing.Point(20, 170);
            this.confirm_box.Name = "confirm_box";
            this.confirm_box.PasswordChar = '*';
            this.confirm_box.Size = new System.Drawing.Size(120, 33);
            this.confirm_box.TabIndex = 3;
            this.confirm_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password_box.Location = new System.Drawing.Point(20, 105);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new System.Drawing.Size(120, 33);
            this.password_box.TabIndex = 2;
            this.password_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // confirm_password
            // 
            this.confirm_password.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirm_password.Location = new System.Drawing.Point(0, 140);
            this.confirm_password.Name = "confirm_password";
            this.confirm_password.Size = new System.Drawing.Size(160, 23);
            this.confirm_password.TabIndex = 0;
            this.confirm_password.Text = "Confirm Password";
            this.confirm_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username.Location = new System.Drawing.Point(30, 10);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 23);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_sign
            // 
            this.password_sign.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password_sign.Location = new System.Drawing.Point(30, 75);
            this.password_sign.Name = "password_sign";
            this.password_sign.Size = new System.Drawing.Size(100, 23);
            this.password_sign.TabIndex = 0;
            this.password_sign.Text = "Password";
            this.password_sign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back_button.Location = new System.Drawing.Point(9, 282);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(50, 23);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Visible = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // error_sign_up
            // 
            this.error_sign_up.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.error_sign_up.ForeColor = System.Drawing.Color.Crimson;
            this.error_sign_up.Location = new System.Drawing.Point(25, 8);
            this.error_sign_up.Name = "error_sign_up";
            this.error_sign_up.Size = new System.Drawing.Size(250, 25);
            this.error_sign_up.TabIndex = 5;
            this.error_sign_up.Text = "Username is not unique";
            this.error_sign_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.error_sign_up.Visible = false;
            // 
            // login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.error_sign_up);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.error_login);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UniFIle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label error_login;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label log_in;
        private System.Windows.Forms.Button sign_up_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sign_up;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.TextBox confirm_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label confirm_password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password_sign;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label error_sign_up;
    }
}

