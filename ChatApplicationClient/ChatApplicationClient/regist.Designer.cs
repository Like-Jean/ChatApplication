namespace ChatApplicationClient
{
    partial class regist
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.regist_bnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(77, 13);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(179, 21);
            this.name_txt.TabIndex = 2;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(77, 43);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(179, 21);
            this.password_txt.TabIndex = 3;
            // 
            // regist_bnt
            // 
            this.regist_bnt.Location = new System.Drawing.Point(180, 71);
            this.regist_bnt.Name = "regist_bnt";
            this.regist_bnt.Size = new System.Drawing.Size(75, 23);
            this.regist_bnt.TabIndex = 4;
            this.regist_bnt.Text = "regist";
            this.regist_bnt.UseVisualStyleBackColor = true;
            this.regist_bnt.Click += new System.EventHandler(this.regist_bnt_Click);
            // 
            // regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 106);
            this.Controls.Add(this.regist_bnt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "regist";
            this.Text = "regist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button regist_bnt;
    }
}