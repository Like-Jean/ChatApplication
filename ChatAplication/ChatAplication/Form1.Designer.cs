namespace ChatAplication
{
    partial class Form1
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
            this.start_btn = new System.Windows.Forms.Button();
            this.server_recv = new System.Windows.Forms.ListBox();
<<<<<<< HEAD
            this.add_topic_btn = new System.Windows.Forms.Button();
            this.stop_bnt = new System.Windows.Forms.Button();
            this.server_topicList = new System.Windows.Forms.ListView();
            this.add_text = new System.Windows.Forms.TextBox();
=======
            this.server_topicList = new System.Windows.Forms.ListBox();
            this.add_topic_btn = new System.Windows.Forms.Button();
            this.stop_bnt = new System.Windows.Forms.Button();
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(13, 1);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // server_recv
            // 
            this.server_recv.FormattingEnabled = true;
            this.server_recv.ItemHeight = 12;
            this.server_recv.Location = new System.Drawing.Point(13, 30);
            this.server_recv.Name = "server_recv";
<<<<<<< HEAD
            this.server_recv.Size = new System.Drawing.Size(233, 148);
            this.server_recv.TabIndex = 5;
            this.server_recv.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // add_topic_btn
            // 
            this.add_topic_btn.Location = new System.Drawing.Point(252, 2);
=======
            this.server_recv.Size = new System.Drawing.Size(259, 148);
            this.server_recv.TabIndex = 5;
            this.server_recv.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // server_topicList
            // 
            this.server_topicList.FormattingEnabled = true;
            this.server_topicList.ItemHeight = 12;
            this.server_topicList.Location = new System.Drawing.Point(293, 30);
            this.server_topicList.Name = "server_topicList";
            this.server_topicList.Size = new System.Drawing.Size(120, 148);
            this.server_topicList.TabIndex = 6;
            // 
            // add_topic_btn
            // 
            this.add_topic_btn.Location = new System.Drawing.Point(293, 1);
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
            this.add_topic_btn.Name = "add_topic_btn";
            this.add_topic_btn.Size = new System.Drawing.Size(75, 23);
            this.add_topic_btn.TabIndex = 7;
            this.add_topic_btn.Text = "add topic";
            this.add_topic_btn.UseVisualStyleBackColor = true;
            this.add_topic_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // stop_bnt
            // 
            this.stop_bnt.Location = new System.Drawing.Point(112, 1);
            this.stop_bnt.Name = "stop_bnt";
            this.stop_bnt.Size = new System.Drawing.Size(75, 23);
            this.stop_bnt.TabIndex = 8;
            this.stop_bnt.Text = "stop";
            this.stop_bnt.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
            // server_topicList
            // 
            this.server_topicList.Location = new System.Drawing.Point(252, 30);
            this.server_topicList.Name = "server_topicList";
            this.server_topicList.Size = new System.Drawing.Size(181, 148);
            this.server_topicList.TabIndex = 9;
            this.server_topicList.UseCompatibleStateImageBehavior = false;
            this.server_topicList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // add_text
            // 
            this.add_text.Location = new System.Drawing.Point(333, 4);
            this.add_text.Name = "add_text";
            this.add_text.Size = new System.Drawing.Size(100, 21);
            this.add_text.TabIndex = 10;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(445, 190);
            this.Controls.Add(this.add_text);
            this.Controls.Add(this.server_topicList);
            this.Controls.Add(this.stop_bnt);
            this.Controls.Add(this.add_topic_btn);
=======
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(445, 190);
            this.Controls.Add(this.stop_bnt);
            this.Controls.Add(this.add_topic_btn);
            this.Controls.Add(this.server_topicList);
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
            this.Controls.Add(this.server_recv);
            this.Controls.Add(this.start_btn);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
<<<<<<< HEAD
            this.PerformLayout();
=======
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3

        }

        #endregion

        private System.Windows.Forms.TextBox server_recieve;
        private System.Windows.Forms.TextBox server_send;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.ListBox server_recv;
<<<<<<< HEAD
        private System.Windows.Forms.Button add_topic_btn;
        private System.Windows.Forms.Button stop_bnt;
        private System.Windows.Forms.ListView server_topicList;
        private System.Windows.Forms.TextBox add_text;
=======
        private System.Windows.Forms.ListBox server_topicList;
        private System.Windows.Forms.Button add_topic_btn;
        private System.Windows.Forms.Button stop_bnt;
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
    }
}

