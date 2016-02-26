namespace ChatApplicationClient
{
    partial class chat_form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.client_send = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.topic_txt = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.name_txt = new System.Windows.Forms.Label();
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
            this.topic_list = new System.Windows.Forms.ListView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.client_recieve = new System.Windows.Forms.TextBox();
            this.tabBox = new System.Windows.Forms.TabControl();
<<<<<<< HEAD
            this.name = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.tabBox.SuspendLayout();
=======
            this.tabPage1.SuspendLayout();
            this.tabBox.SuspendLayout();
=======
            this.client_recieve = new System.Windows.Forms.TextBox();
            this.tabBox = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.topic_list = new System.Windows.Forms.ListView();
            this.tabBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
            this.SuspendLayout();
            // 
            // client_send
            // 
<<<<<<< HEAD
            this.client_send.Location = new System.Drawing.Point(12, 295);
            this.client_send.Multiline = true;
            this.client_send.Name = "client_send";
            this.client_send.Size = new System.Drawing.Size(267, 41);
            this.client_send.TabIndex = 1;
            this.client_send.TextChanged += new System.EventHandler(this.client_send_TextChanged);
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(204, 342);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(75, 25);
=======
            this.client_send.Location = new System.Drawing.Point(12, 272);
            this.client_send.Multiline = true;
            this.client_send.Name = "client_send";
            this.client_send.Size = new System.Drawing.Size(267, 38);
            this.client_send.TabIndex = 1;
<<<<<<< HEAD
            this.client_send.TextChanged += new System.EventHandler(this.client_send_TextChanged);
=======
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(204, 316);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(75, 23);
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
            this.send_btn.TabIndex = 2;
            this.send_btn.Text = "send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // topic_txt
            // 
            this.topic_txt.AutoSize = true;
<<<<<<< HEAD
            this.topic_txt.Location = new System.Drawing.Point(12, 50);
            this.topic_txt.Name = "topic_txt";
            this.topic_txt.Size = new System.Drawing.Size(39, 13);
=======
            this.topic_txt.Location = new System.Drawing.Point(12, 46);
            this.topic_txt.Name = "topic_txt";
            this.topic_txt.Size = new System.Drawing.Size(47, 12);
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
            this.topic_txt.TabIndex = 3;
            this.topic_txt.Text = "default";
            this.topic_txt.Click += new System.EventHandler(this.label1_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(204, 4);
            this.logout_btn.Name = "logout_btn";
<<<<<<< HEAD
            this.logout_btn.Size = new System.Drawing.Size(75, 25);
=======
            this.logout_btn.Size = new System.Drawing.Size(75, 23);
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
            this.logout_btn.TabIndex = 4;
            this.logout_btn.Text = "logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            // 
            // name_txt
            // 
            this.name_txt.AutoSize = true;
<<<<<<< HEAD
            this.name_txt.Location = new System.Drawing.Point(12, 10);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(33, 13);
            this.name_txt.TabIndex = 5;
            this.name_txt.Text = "name";
            // 
            // topic_list
            // 
            this.topic_list.Location = new System.Drawing.Point(312, 50);
            this.topic_list.Name = "topic_list";
            this.topic_list.Size = new System.Drawing.Size(121, 286);
            this.topic_list.TabIndex = 8;
            this.topic_list.UseCompatibleStateImageBehavior = false;
            this.topic_list.DoubleClick += new System.EventHandler(this.topic_list_DoubleClick);
=======
            this.name_txt.Location = new System.Drawing.Point(12, 9);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(29, 12);
            this.name_txt.TabIndex = 5;
            this.name_txt.Text = "name";
<<<<<<< HEAD
            // 
            // topic_list
            // 
            this.topic_list.Location = new System.Drawing.Point(312, 46);
            this.topic_list.Name = "topic_list";
            this.topic_list.Size = new System.Drawing.Size(121, 264);
            this.topic_list.TabIndex = 8;
            this.topic_list.UseCompatibleStateImageBehavior = false;
            this.topic_list.DoubleClick += new System.EventHandler(this.topic_list_DoubleClick);
=======
            this.name_txt.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // client_recieve
            // 
            this.client_recieve.Location = new System.Drawing.Point(4, 3);
            this.client_recieve.Multiline = true;
            this.client_recieve.Name = "client_recieve";
            this.client_recieve.Size = new System.Drawing.Size(255, 187);
            this.client_recieve.TabIndex = 6;
            this.client_recieve.TextChanged += new System.EventHandler(this.client_recieve_TextChanged);
            // 
            // tabBox
            // 
            this.tabBox.Controls.Add(this.tabPage1);
            this.tabBox.Controls.Add(this.tabPage2);
            this.tabBox.Location = new System.Drawing.Point(12, 46);
            this.tabBox.Name = "tabBox";
            this.tabBox.SelectedIndex = 0;
            this.tabBox.Size = new System.Drawing.Size(271, 219);
            this.tabBox.TabIndex = 7;
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.client_recieve);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
<<<<<<< HEAD
            this.tabPage1.Size = new System.Drawing.Size(263, 211);
=======
            this.tabPage1.Size = new System.Drawing.Size(263, 193);
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
            // client_recieve
            // 
            this.client_recieve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.client_recieve.Location = new System.Drawing.Point(3, 3);
            this.client_recieve.Multiline = true;
            this.client_recieve.Name = "client_recieve";
<<<<<<< HEAD
            this.client_recieve.Size = new System.Drawing.Size(257, 205);
=======
            this.client_recieve.Size = new System.Drawing.Size(257, 187);
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
            this.client_recieve.TabIndex = 6;
            this.client_recieve.TextChanged += new System.EventHandler(this.client_recieve_TextChanged);
            // 
            // tabBox
            // 
            this.tabBox.Controls.Add(this.tabPage1);
<<<<<<< HEAD
            this.tabBox.Location = new System.Drawing.Point(12, 50);
            this.tabBox.Name = "tabBox";
            this.tabBox.SelectedIndex = 0;
            this.tabBox.Size = new System.Drawing.Size(271, 237);
            this.tabBox.TabIndex = 7;
            this.tabBox.Tag = "";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(51, 10);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 9;
            this.name.Text = "label1";
            // 
            // chat_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 380);
            this.Controls.Add(this.name);
=======
            this.tabBox.Location = new System.Drawing.Point(12, 46);
            this.tabBox.Name = "tabBox";
            this.tabBox.SelectedIndex = 0;
            this.tabBox.Size = new System.Drawing.Size(271, 219);
            this.tabBox.TabIndex = 7;
            this.tabBox.Tag = "";
=======
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(263, 193);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // topic_list
            // 
            this.topic_list.Location = new System.Drawing.Point(312, 46);
            this.topic_list.Name = "topic_list";
            this.topic_list.Size = new System.Drawing.Size(121, 264);
            this.topic_list.TabIndex = 8;
            this.topic_list.UseCompatibleStateImageBehavior = false;
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
            // 
            // chat_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 351);
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
            this.Controls.Add(this.topic_list);
            this.Controls.Add(this.tabBox);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.topic_txt);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.client_send);
            this.Name = "chat_form";
            this.Text = "Form1";
<<<<<<< HEAD
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabBox.ResumeLayout(false);
=======
<<<<<<< HEAD
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabBox.ResumeLayout(false);
=======
            this.tabBox.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox client_send;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Label topic_txt;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label name_txt;
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
        private System.Windows.Forms.ListView topic_list;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox client_recieve;
        private System.Windows.Forms.TabControl tabBox;
<<<<<<< HEAD
        private System.Windows.Forms.Label name;
=======
=======
        private System.Windows.Forms.TextBox client_recieve;
        private System.Windows.Forms.TabControl tabBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView topic_list;
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
    }
}

