namespace explorator
{
    partial class sharing_test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.start_button = new System.Windows.Forms.Button();
            this.prm_0 = new System.Windows.Forms.CheckBox();
            this.u_id = new System.Windows.Forms.TextBox();
            this.prm_1 = new System.Windows.Forms.CheckBox();
            this.prm_2 = new System.Windows.Forms.CheckBox();
            this.prm_3 = new System.Windows.Forms.CheckBox();
            this.f_id = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stop_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.getperm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(16, 184);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // prm_0
            // 
            this.prm_0.AutoSize = true;
            this.prm_0.Location = new System.Drawing.Point(12, 30);
            this.prm_0.Name = "prm_0";
            this.prm_0.Size = new System.Drawing.Size(61, 17);
            this.prm_0.TabIndex = 1;
            this.prm_0.Text = "rename";
            this.prm_0.UseVisualStyleBackColor = true;
            // 
            // u_id
            // 
            this.u_id.Location = new System.Drawing.Point(158, 50);
            this.u_id.Name = "u_id";
            this.u_id.Size = new System.Drawing.Size(100, 20);
            this.u_id.TabIndex = 2;
            // 
            // prm_1
            // 
            this.prm_1.AutoSize = true;
            this.prm_1.Location = new System.Drawing.Point(11, 53);
            this.prm_1.Name = "prm_1";
            this.prm_1.Size = new System.Drawing.Size(55, 17);
            this.prm_1.TabIndex = 1;
            this.prm_1.Text = "delete";
            this.prm_1.UseVisualStyleBackColor = true;
            // 
            // prm_2
            // 
            this.prm_2.AutoSize = true;
            this.prm_2.Location = new System.Drawing.Point(11, 76);
            this.prm_2.Name = "prm_2";
            this.prm_2.Size = new System.Drawing.Size(51, 17);
            this.prm_2.TabIndex = 1;
            this.prm_2.Text = "show";
            this.prm_2.UseVisualStyleBackColor = true;
            // 
            // prm_3
            // 
            this.prm_3.AutoSize = true;
            this.prm_3.Location = new System.Drawing.Point(11, 99);
            this.prm_3.Name = "prm_3";
            this.prm_3.Size = new System.Drawing.Size(44, 17);
            this.prm_3.TabIndex = 1;
            this.prm_3.Text = "add";
            this.prm_3.UseVisualStyleBackColor = true;
            // 
            // f_id
            // 
            this.f_id.Location = new System.Drawing.Point(158, 96);
            this.f_id.Name = "f_id";
            this.f_id.Size = new System.Drawing.Size(100, 20);
            this.f_id.TabIndex = 3;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Checked = true;
            this.error.CheckState = System.Windows.Forms.CheckState.Checked;
            this.error.Location = new System.Drawing.Point(11, 7);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(80, 17);
            this.error.TabIndex = 4;
            this.error.Text = "checkBox1";
            this.error.UseVisualStyleBackColor = true;
            this.error.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "File ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(197, 184);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 0;
            this.stop_button.Text = "stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(113, 184);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 9;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // getperm
            // 
            this.getperm.Location = new System.Drawing.Point(112, 213);
            this.getperm.Name = "getperm";
            this.getperm.Size = new System.Drawing.Size(75, 23);
            this.getperm.TabIndex = 9;
            this.getperm.Text = "getperm";
            this.getperm.UseVisualStyleBackColor = true;
            this.getperm.Click += new System.EventHandler(this.getperm_Click);
            // 
            // sharing_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.getperm);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.f_id);
            this.Controls.Add(this.u_id);
            this.Controls.Add(this.prm_3);
            this.Controls.Add(this.prm_2);
            this.Controls.Add(this.prm_1);
            this.Controls.Add(this.prm_0);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Name = "sharing_test";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.sharing_test_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.sharing_test_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.CheckBox prm_0;
        private System.Windows.Forms.TextBox u_id;
        private System.Windows.Forms.CheckBox prm_1;
        private System.Windows.Forms.CheckBox prm_2;
        private System.Windows.Forms.CheckBox prm_3;
        private System.Windows.Forms.TextBox f_id;
        private System.Windows.Forms.CheckBox error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button getperm;
    }
}

