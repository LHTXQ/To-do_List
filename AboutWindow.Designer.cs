
namespace To_do_List
{
    partial class aboutwindow
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label Versionlabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.RichTextBox richTextBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutwindow));
            this.aboutlabel = new System.Windows.Forms.Label();
            this.aboutwindows_button = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            Versionlabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.Enabled = false;
            pictureBox1.ErrorImage = global::To_do_List.Properties.Resources.todolist_png;
            pictureBox1.Image = global::To_do_List.Properties.Resources.todolist_png;
            pictureBox1.InitialImage = global::To_do_List.Properties.Resources.todolist_png;
            pictureBox1.Location = new System.Drawing.Point(179, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(60, 60);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(179, 66);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 12);
            label1.TabIndex = 4;
            label1.Text = "待办清单";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Versionlabel
            // 
            Versionlabel.AutoSize = true;
            Versionlabel.Enabled = false;
            Versionlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Versionlabel.Font = new System.Drawing.Font("宋体", 8F);
            Versionlabel.Location = new System.Drawing.Point(160, 180);
            Versionlabel.Name = "Versionlabel";
            Versionlabel.Size = new System.Drawing.Size(91, 11);
            Versionlabel.TabIndex = 5;
            Versionlabel.Text = "版本号：1.1.1.1";
            Versionlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label2.Font = new System.Drawing.Font("宋体", 8F);
            label2.Location = new System.Drawing.Point(123, 195);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(166, 11);
            label2.TabIndex = 6;
            label2.Text = "电子邮箱地址：lhtxq@live.com";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            richTextBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            richTextBox1.Location = new System.Drawing.Point(30, 81);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new System.Drawing.Size(375, 96);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // aboutlabel
            // 
            this.aboutlabel.AutoSize = true;
            this.aboutlabel.Enabled = false;
            this.aboutlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutlabel.Font = new System.Drawing.Font("宋体", 9F);
            this.aboutlabel.Location = new System.Drawing.Point(121, 211);
            this.aboutlabel.Name = "aboutlabel";
            this.aboutlabel.Size = new System.Drawing.Size(173, 12);
            this.aboutlabel.TabIndex = 1;
            this.aboutlabel.Text = "刘汉涛   版权所有  2021-2021";
            this.aboutlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutwindows_button
            // 
            this.aboutwindows_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.aboutwindows_button.Location = new System.Drawing.Point(179, 230);
            this.aboutwindows_button.Name = "aboutwindows_button";
            this.aboutwindows_button.Size = new System.Drawing.Size(60, 23);
            this.aboutwindows_button.TabIndex = 2;
            this.aboutwindows_button.Text = "好的";
            this.aboutwindows_button.UseVisualStyleBackColor = true;
            this.aboutwindows_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // aboutwindow
            // 
            this.AcceptButton = this.aboutwindows_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.aboutwindows_button;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(richTextBox1);
            this.Controls.Add(label2);
            this.Controls.Add(Versionlabel);
            this.Controls.Add(label1);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.aboutwindows_button);
            this.Controls.Add(this.aboutlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "aboutwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aboutwindows_button;
        private System.Windows.Forms.Label aboutlabel;
    }
}