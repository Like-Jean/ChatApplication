namespace ChatApplicationClient
{
    partial class login_form
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
            this.name_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.regist_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(13, 13);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(29, 12);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "name";
            this.name_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(13, 38);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 12);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "password";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(73, 13);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(199, 21);
            this.name_txt.TabIndex = 2;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(73, 38);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(199, 21);
            this.password_txt.TabIndex = 3;
            // 
            // regist_btn
            // 
            this.regist_btn.Location = new System.Drawing.Point(15, 83);
            this.regist_btn.Name = "regist_btn";
            this.regist_btn.Size = new System.Drawing.Size(75, 23);
            this.regist_btn.TabIndex = 4;
            this.regist_btn.Text = "regist";
            this.regist_btn.UseVisualStyleBackColor = true;
            this.regist_btn.Click += new System.EventHandler(this.regist_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(196, 82);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 115);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.regist_btn);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.name_label);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button regist_btn;
        private System.Windows.Forms.Button login_btn;
    }
}