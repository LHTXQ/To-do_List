using System;
//using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
//using System.Text.RegularExpressions;
using System.Media;
using Microsoft.Win32;

namespace To_do_List
{
    public partial class MainWindow : Form
    {
        internal static string Version = "1.2.1.1";//程序版本，更改后仍需修改MainWindow函数中的数据文件版本号判断。
        public static int LineCount = 0;//统计数据文件（To-do_List_Data.to-do_list_data）内容行数，从 1 起计。
        int TodoCount = 0;//统计未完成项数。
        string[,] TodoList = new string[300005,5];//读取数据文件（To-do_List_Data.to-do_list_data）内容并将其写入该数组。如果TodoList[n,0]为Deleted，则表示该项已被删除，可重用。
        int TodoID;//待办项唯一编号，从文件中读取赋值。只加不减。
        FiltrateSortAndAlarm Alarm;
        Boolean Ready = false;//程序操作DataGridView完成状态标识。



        public MainWindow()
        {
            if (!File.Exists(@Application.StartupPath.ToString() + "\\To-do_List\\To-do_List_Data.to-do_list_data"))
            {
                //在软件所在目录下创建To-do_List文件夹并写入To-do_List_Data.to-do_list_data的文本文件。
                try
                {
                    if (Directory.Exists(@Application.StartupPath.ToString() + "\\To-do_List") == false)
                    {
                        Directory.CreateDirectory(@Application.StartupPath.ToString() + "\\To-do_List");
                    }
                    //byte[] info = new UTF8Encoding(true).GetBytes("这是待办清单的数据文件，请勿修改或删除。");
                    //File.Create(@Application.StartupPath.ToString() + "\\To-do_List\\To-do_List_Data.to-do_list_data").Write(info,0,info.Length);
                    //换了个写入的实现方法。
                    StreamWriter write = File.CreateText(@Application.StartupPath.ToString() + "\\To-do_List\\To-do_List_Data.to-do_list_data");
                    write.WriteLine(Version + "\n这是待办清单的数据文件，请勿修改或删除。\t" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "\tTrue\tTrue\n---------------------------------------------------------------\n0\tNull\n---------------------------------------------------------------");
                    write.Close();
                }
                catch
                {
                    MessageBox.Show("在写入必需的数据文件时遇到错误，请检查软件权限。\n\n请在排除权限问题后再使用本软件。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.NotifyIcon.Dispose();
                    Application.Exit();
                    Environment.Exit(0);
                }
            }

            //
            InitializeComponent();
            //初始化组件。

            //
            try
            {
                FileInfo FileInfor = new FileInfo(@Application.StartupPath.ToString() + "\\To-do_List\\To-do_List_Data.to-do_list_data");
                if ((FileInfor.Length / 1024.0) >= 100000)
                {
                    MessageBox.Show("数据文件大小超出限制而无法读取，其可能已被篡改。\n\n请备份并删除原文件后再使用本软件。如其中有重要内容，请联系作者尝试恢复。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.NotifyIcon.Dispose();
                    Application.Exit();
                    Environment.Exit(0);
                }
            }
            catch
            {
                MessageBox.Show("读取数据文件信息失败，其可能已被篡改。\n\n请备份并删除原文件后再使用本软件。如其中有重要内容，请联系作者尝试恢复。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.NotifyIcon.Dispose();
                Application.Exit();
                Environment.Exit(0);
            }
            StreamReader reader = new StreamReader(@Application.StartupPath.ToString() + "\\To-do_List\\To-do_List_Data.to-do_list_data");
            do
            {
                if (LineCount == 300005)
                {
                    MessageBox.Show("数据文件大小超出限制而无法读取，其可能已被篡改。\n\n请备份并删除原文件后再使用本软件。如其中有重要内容，请联系作者尝试恢复。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.NotifyIcon.Dispose();
                    Application.Exit();
                    Environment.Exit(0);
                }
                string[] strArr = reader.ReadLine().Split(new[] { "\t" }, StringSplitOptions.None);
                for(int i = 0;i<= strArr.GetUpperBound(0);i++)
                {
                    TodoList[LineCount, i] = strArr[i];
                }
                LineCount++;
            } while (!reader.EndOfStream);//读取数据文件中的待办任务。
            reader.Close();
            reader.Dispose();
            if (TodoList[0,0] != "1.0.0.0" && TodoList[0, 0] != "1.0.1.1" && TodoList[0, 0] != "1.1.1.1" && TodoList[0, 0] != "1.2.1.1")
            {
                MessageBox.Show("无法识别数据文件，因为数据文件版本不在该版本程序支持范围内。\n\n请备份并删除原文件后再使用本软件。如其中有重要内容，请联系作者尝试恢复。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.NotifyIcon.Dispose();
                Application.Exit();
                Environment.Exit(0);
            }
            //
            if (TodoList[3,1] != "Null")
            {
                if(System.IO.File.Exists(@Application.StartupPath.ToString() + "\\To-do_List\\" + TodoList[3,1]))
                {
                    try
                    {
                        this.BackgroundImage = Image.FromFile(@Application.StartupPath.ToString() + "\\To-do_List\\" + TodoList[3,1]);
                    }
                    catch
                    {
                        MessageBox.Show("载入背景图像失败，请检查文件流格式是否正确。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("未找到背景图像文件，请确保数据目录中存在名为 "+ TodoList[3, 1] + " 的文件。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }//载入背景图像
            //
            int.TryParse(TodoList[3,0], out TodoID);
            if(TodoID >= 300000)
            {
                MessageBox.Show("待办项总数超过限制！\n\n无法继续添加待办。如需继续添加待办，请备份并删除数据文件后重新打开本软件。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button_addtodo.Enabled = false;
                button_addtodo.Visible = false;
            }
            this.DateTimePicker1.Value = DateTime.Now;
            if(LineCount > 5)
            {
                try
                {
                    for (int i = 5; i <= LineCount-1; i++)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        int index = this.DataGridView1.Rows.Add(row);
                        if (TodoList[i, 1] == "False")
                        {
                            TodoCount++;
                        }
                        this.DataGridView1.Rows[index].Cells[0].Value = TodoList[i, 0];
                        this.DataGridView1.Rows[index].Cells[1].Value = TodoList[i, 1];
                        this.DataGridView1.Rows[index].Cells[2].Value = TodoList[i, 2];
                        this.DataGridView1.Rows[index].Cells[3].Value = TodoList[i, 3];
                        this.DataGridView1.Rows[index].Cells[4].Value = TodoList[i, 4];
                    }
                }
                catch
                {
                    MessageBox.Show("数据文件格式错误，其可能已被修改或未正常保存。\n\n请备份并删除原文件后再使用本软件。如其中有重要内容，请联系作者尝试恢复。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.NotifyIcon.Dispose();
                    Application.Exit();
                    Environment.Exit(0);
                }
            }
            if (this.DataGridView1.RowCount > 0)
            {
                this.DataGridView1.Sort(this.DataGridView1.Columns[1], ListSortDirection.Ascending);
                //this.DataGridView1.ClearSelection();
                //this.DataGridView1.Rows[0].Selected=true;
            } //若有待办任务，则选中第一项。
            else
            {
                Richtextbox1.BackColor = SystemColors.Window;
                Richtextbox1.ReadOnly = false;
                button_addtodo.Enabled = true;
                Richtextbox1.Text = "：)  欢迎使用待办清单！\n\n在窗口空白位置或状态栏图标处点击鼠标右键进入“关于”以查看更多信息。";
            }
            if(TodoList[1,2] == "False")
            {
                CheckBox_Sound.Checked = false;
            }
            if (TodoList[1, 3] == "False")
            {
                CheckBox_NotifyIcon.Checked = false;
            }
            this.Label_Statistics.Text = "（总计 " + (LineCount - 5).ToString() + " 项，还有 " + TodoCount.ToString() +" 项待办）";
            FiltrateSortAndAlarm Alarm = new FiltrateSortAndAlarm();
            Alarm.Filtrate(TodoList);
            Ready = true;
        }
 
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutwindow a = new aboutwindow();
            a.ShowDialog();
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            this.DataGridView1.Height = this.Height - 180;
            this.Richtextbox1.Height = this.DataGridView1.Height;
            this.Richtextbox1.Width = this.Width-403;
            this.TextBox_todo_title.Width = this.Richtextbox1.Width - 63;
            this.button_exportfile.Location = new Point(this.Width / 2 - 35, this.Height - 73);
            this.button_importfile.Location = new Point(this.Width / 4 - 35, this.Height - 73);
            this.button_addtodo.Location = new Point(this.Width /4 * 3 - 35, this.Height - 73);
        }

        private void Addtodo_button_Click(object sender, EventArgs e)//添加待办按钮。
        {
            if(TextBox_todo_title.Text== "Help")
            {
                if(!File.Exists(@Application.StartupPath.ToString() + "\\To-do_List\\To-do_List.Help.to-do"))
                {
                    try
                    {
                        //BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create))
                        Byte[] Help = Properties.Resources.To_do_List_Help;
                        File.Create(@Application.StartupPath.ToString() + "\\To-do_List\\To-do_List.Help.to-do").Write(Help, 0, Help.Length);
                        File.Create(@Application.StartupPath.ToString() + "\\To-do_List\\To-do_List.Help.to-do").Dispose();
                    }
                    catch
                    {
                        Richtextbox1.Text = "*********************\n>>>>>错误<<<<<\n无法创建帮助文件，因此你无法查看帮助内容。\n*********************";
                    }
                }
                try
                {
                    Richtextbox1.LoadFile(@Application.StartupPath.ToString() + "\\To-do_List\\To-do_List.Help.to-do", RichTextBoxStreamType.RichText);
                }
                catch
                {
                    Richtextbox1.Text = "*********************\n>>>>>错误<<<<<\n读取帮助文件失败，可能正在生成帮助文件，请在 30 秒或更长时间后重试，此期间请勿关闭软件。\n*********************";
                }
            }//打开帮助内容。
            else if(TextBox_todo_title.Text == "AutoRun=True" || TextBox_todo_title.Text == "AutoRun=False")
            {
                if(TextBox_todo_title.Text == "AutoRun=True")
                {
                    MessageBox.Show("由于涉及到修改注册表，此举可能会被某些安全软件拦截，请选择允许。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        RegistryKey Reg;
                        Reg = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                        Reg.SetValue("To-do_List", Application.ExecutablePath);
                        Reg.Close();
                        Richtextbox1.Text = "设置开机自动启动成功！";
                    }
                    catch
                    {
                        Richtextbox1.Text = "设置开机自动启动失败！";
                    }
                }
                else
                {
                    MessageBox.Show("由于涉及到修改注册表，此举可能会被某些安全软件拦截，请选择允许。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        RegistryKey Reg;
                        Reg = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                        Reg.DeleteValue("To-do_List", false);
                        Reg.Close();
                        Richtextbox1.Text = "取消开机自动启动成功！";
                    }
                    catch
                    {
                        Richtextbox1.Text = "取消开机自动启动失败！";
                    }
                }
            }//打开或关闭开机自动启动。
            else if(TextBox_todo_title.Text.Split('=')[0] == "SetBackgroundImage")
            {
                if(TextBox_todo_title.Text.Split('=')[1] == "Null")
                {
                    if(TodoList[3, 1] != "Null")
                    {
                        TodoList[3, 1] = "Null";
                        try
                        {
                            StreamWriter write = File.CreateText(@Application.StartupPath.ToString() + "\\To-do_List\\To-do_List_Data.to-do_list_data");
                            for (int i = 0; i <= LineCount - 1; i++)
                            {
                                write.WriteLine(TodoList[i, 0] + "\t" + TodoList[i, 1] + "\t" + TodoList[i, 2] + "\t" + TodoList[i, 3] + "\t" + TodoList[i, 4]);
                            }
                            write.Close();
                            write.Dispose();
                        }
                        catch
                        {
                            MessageBox.Show("写入数据时遇到错误，请检查软件权限或数据文件有效性。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    this.BackgroundImage = null;
                    Richtextbox1.Text = "清除背景图像成功！\n\n如需设置背景图像，请在数据目录（To-do_List）中放入图像文件（支持*.jpg|*.jpeg|*.gif|*.bmp|*.wmf|*.png）并执行SetBackgroundImage=xxx命令，其中“xxx”为包含后缀的图像文件名。\n\n完整命令示例：\nSetBackgroundImage=BackgroundImage.jpg";
                }
                else
                {
                    string Suffix = TextBox_todo_title.Text.Split('=')[1].Split('.')[TextBox_todo_title.Text.Split('=')[1].Split('.').Length - 1];
                    if(Suffix == "jpg" || Suffix == "jpeg" || Suffix == "gif" || Suffix == "bmp" || Suffix == "wmf" || Suffix == "png")
                    {
                        if (System.IO.File.Exists(@Application.StartupPath.ToString() + "\\To-do_List\\" + TextBox_todo_title.Text.Split('=')[1]))
                        {
                            TodoList[3, 1] = TextBox_todo_title.Text.Split('=')[1];
                            try
                            {
                                StreamWriter write = File.CreateText(@Application.StartupPath.ToString() + "\\To-do_List\\To-do_List_Data.to-do_list_data");
                                for (int i = 0; i <= LineCount - 1; i++)
                                {
                                    write.WriteLine(TodoList[i, 0] + "\t" + TodoList[i, 1] + "\t" + TodoList[i, 2] + "\t" + TodoList[i, 3] + "\t" + TodoList[i, 4]);
                                }
                                write.Close();
                                write.Dispose();
                            }
                            catch
                            {
                                MessageBox.Show("写入数据时遇到错误，请检查软件权限或数据文件有效性。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            try
                            {
                                this.BackgroundImage = Image.FromFile(@Application.StartupPath.ToString() + "\\To-do_List\\" + TextBox_todo_title.Text.Split('=')[1]);
                                Richtextbox1.Text = "设置背景图像成功！\n\n如需更改背景图像，请在数据目录（To-do_List）中放入图像文件（支持*.jpg|*.jpeg|*.gif|*.bmp|*.wmf|*.png）并执行SetBackgroundImage=xxx命令或重新打开软件，其中“xxx”为包含后缀的图像文件名。\n\n完整命令示例：\nSetBackgroundImage=BackgroundImage.jpg";
                            }
                            catch
                            {
                                MessageBox.Show("载入背景图像失败，请检查文件流格式是否正确。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("未找到背景图像文件，请确保数据目录（To-do_List）中存在名为 " + TextBox_todo_title.Text.Split('=')[1] + " 的文件。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("请输入正确指定背景图像文件的命令！\n\n完整命令示例：\nSetBackgroundImage=BackgroundImage.jpg\n\n仅支持*.jpg|*.jpeg|*.gif|*.bmp|*.wmf|*.png格式的图像文件。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }//设置背景图像
            else
            {
                try
                {
                    Alarm.Stop();
                }
                catch (NullReferenceException)
                {

                }
                Ready = false;
                TodoID++;
                LineCount++;
                TodoCount++;

                Richtextbox1.SaveFile(@Application.StartupPath.ToString() + "\\To-do_List\\" + TodoID + ".to-do", RichTextBoxStreamType.RichText);
                DataGridViewRow row = new DataGridViewRow();
                int index = this.DataGridView1.Rows.Add(row);
                this.DataGridView1.Rows[index].Cells[0].Value = TodoID;
                this.DataGridView1.Rows[index].Cells[1].Value = false;
                this.DataGridView1.Rows[index].Cells[2].Value = this.DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm");
                this.DataGridView1.Rows[index].Cells[3].Value = this.TextBox_todo_title.Text;
                this.DataGridView1.Rows[index].Cells[4].Value = "";

                TodoList[3, 0] = TodoID.ToString();
                TodoList[LineCount - 1, 0] = TodoID.ToString();
                TodoList[LineCount - 1, 1] = "False";
                TodoList[LineCount - 1, 2] = this.DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm");
                TodoList[LineCount - 1, 3] = this.TextBox_todo_title.Text;
                TodoList[LineCount - 1, 4] = "";
                try
                {
                    //StreamWriter write = File.AppendText(@Application.StartupPath.ToString() + "\\To-do_List\\To-do_List_Data.to-do_list_data");
                    StreamWriter write = File.CreateText(@Application.StartupPath.ToString() + "\\To-do_List\\To-do_List_Data.to-do_list_data");
                    for (int i = 0; i <= LineCount - 1; i++)
                    {
                        write.WriteLine(TodoList[i, 0] + "\t" + TodoList[i, 1] + "\t" + TodoList[i, 2] + "\t" + TodoList[i, 3] + "\t" + TodoList[i, 4]);
                    }
                    write.Close();
                    write.Dispose();
                }
                catch
                {
                    MessageBox.Show("写入数据时遇到错误，请检查软件权限或数据文件有效性。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.DataGridView1.ClearSelection();
                this.DataGridView1.Sort(this.DataGridView1.Columns[1], ListSortDirection.Ascending);
                this.DataGridView1.Rows[0].Selected = true;
                this.TextBox_todo_title.Clear();
                this.DateTimePicker1.Value = DateTime.Now;
                this.Label_Statistics.Text = "（总计 " + (LineCount - 5).ToString() + " 项，还有 " + TodoCount.ToString() + " 项待办）";
                if (TodoID >= 300000)
                {
                    MessageBox.Show("待办项数超过限制！\n\n无法继续添加待办。如需继续添加待办，请备份并删除数据文件后重新打开本软件。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    button_addtodo.Enabled = false;
                    button_addtodo.Visible = false;
                }
                DataGridView1.Focus();
                Alarm = new FiltrateSortAndAlarm();
                Alarm.Filtrate(TodoList);
                Ready = true;
            }//添加待办。
        }
        private Boolean AskExitSoftware()
        {
            if(Richtextbox1.BackColor == SystemColors.Window && Richtextbox1.TextLength != 0)
            {
                DialogResult ask = MessageBox.Show("详情框中有已编辑但未保存的内容，是否不保存并退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (ask == DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
            /*
            DialogResult ask = MessageBox.Show("将自动保存所有更改，确定退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ask==DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
            *///暂取消退出时的二次确认。

            //return true;
        }
        private void ExitSoftware(Boolean a)//boolean a是用来判断关闭操作是由窗口关闭按钮触发还是由状态图标触发，true为窗口关闭按钮触发。
        {
            //退出前需保存所有内容。
            this.NotifyIcon.Dispose();
            if(a==true)
            {
                //保存操作。
                
                //
            }
            else
            {
                //保存操作。
                
                //
                //Application.Exit();该项会重复触发窗口关闭事件。
                Environment.Exit(0);
            }
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean ask = this.AskExitSoftware();
            if (ask == true)
            {
                this.ExitSoftware(false);
            }
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Richtextbox1.Paste();
            }
            catch
            {

            }
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Richtextbox1.Copy();
            }
            catch
            {

            }
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Richtextbox1.Cut();
            }
            catch
            {

            }
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Richtextbox1.SelectAll();
            }
            catch
            {

            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Richtextbox1.SelectedText="";
            }
            catch
            {

            }
        }

        private void 撤消ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Richtextbox1.Undo();
            }
            catch
            {

            }
        }

        private void Richtextbox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(e.LinkText);
            }
            catch
            {
                
            }
        }

        private void Button_importfile_Click(object sender, EventArgs e)
        {
            DataGridView1.ClearSelection();
            Richtextbox1.BackColor = SystemColors.Window;
            button_addtodo.Enabled = true;
            try
            {
                this.OpenFileDialog1.Title = "请选择要导入的待办数据文件";
                this.OpenFileDialog1.Filter = "待办数据文件|*.to-do|富文本文件|*.rtf";
                this.OpenFileDialog1.FileName = "";
                if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filepath = OpenFileDialog1.FileName.ToString();
                    //StreamReader sr = new StreamReader(filepath, true);
                    //string text = sr.ReadToEnd();
                    //sr.Close();
                    //this.richtextbox1.Text = text;
                    Richtextbox1.LoadFile(filepath,RichTextBoxStreamType.RichText);
                }
            }
            catch
            {
                MessageBox.Show("导入数据失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_exportfile_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog1.DefaultExt = "to-do";
                SaveFileDialog1.Filter = "待办数据文件|*.to-do|富文本文件|*.rtf";
                if (this.SaveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string FileName = this.SaveFileDialog1.FileName;
                if (FileName.Length > 0)
                {
                    FileName = this.SaveFileDialog1.FileName;
                    Richtextbox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    MessageBox.Show("文件导出成功！","提示");
                }
            }
            catch
            {
                MessageBox.Show("导出数据失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Boolean ask = this.AskExitSoftware();
            if(ask==false)
            {
                e.Cancel = true;
            }
            else
            {
                this.ExitSoftware(true);
            }
        }
        
        FormWindowState FormState;
        private void NotifyIcon_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.WindowState != FormWindowState.Minimized)
                {
                    FormState = this.WindowState;
                    this.WindowState = FormWindowState.Minimized;
                    this.Hide();
                }
                else
                {
                    this.Show();
                    this.WindowState = FormState;// FormWindowState.Normal;
                }
            }
        }

        //
        internal static Boolean Notify_Status = false;//托盘图标闪烁状态。
        private uint NotifyIcon_Switch = 0;//托盘图标闪烁实现所需参数。
        private void Timer_flickernotifyicon_Tick(object sender, EventArgs e)//托盘图标闪烁实现。
        {
            if(CheckBox_NotifyIcon.Checked == true)
            {
                switch (NotifyIcon_Switch)
                {
                    case 0:
                        this.NotifyIcon.Icon = Properties.Resources.yellow_ico;
                        NotifyIcon_Switch = 1;
                        break;
                    case 2:
                        this.NotifyIcon.Icon = Properties.Resources.orange_ico;
                        NotifyIcon_Switch = 3;
                        break;
                    case 1:
                        this.NotifyIcon.Icon = Properties.Resources.todolist_ico;
                        NotifyIcon_Switch = 2;
                        break;
                    default:
                        this.NotifyIcon.Icon = Properties.Resources.todolist_ico;
                        NotifyIcon_Switch = 0;
                        break;
                }
            }
        }
        //

        private void 删除待办ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("此操作不可恢复，确认删除该待办？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ask == DialogResult.OK)
            {
                try
                {
                    Alarm.Stop();
                }
                catch (NullReferenceException)
                {

                }
                Ready = false;
                try
                {
                    File.Delete(@Application.StartupPath.ToString() + "\\To-do_List\\" + this.DataGridView1.SelectedRows[0].Cells[0].Value + ".to-do");
                    for(int i = 5; i <= LineCount-1;i++)
                    {
                        if(TodoList[i,0] == this.DataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            TodoList[i, 0] = "Deleted";
                            break;
                        }
                    }
                    for (int i = 5; i <= LineCount; i++)
                    {
                        if (TodoList[i, 0] == "Deleted")
                        {
                            TodoList[i, 0] = TodoList[i + 1, 0];
                            TodoList[i, 1] = TodoList[i + 1, 1];
                            TodoList[i, 2] = TodoList[i + 1, 2];
                            TodoList[i, 3] = TodoList[i + 1, 3];
                            TodoList[i, 4] = TodoList[i + 1, 4];
                            for(int j = i+1;j <= LineCount;j++)
                            {
                                TodoList[j, 0] = TodoList[j + 1, 0];
                                TodoList[j, 1] = TodoList[j + 1, 1];
                                TodoList[j, 2] = TodoList[j + 1, 2];
                                TodoList[j, 3] = TodoList[j + 1, 3];
                                TodoList[j, 4] = TodoList[j + 1, 4];
                            }
                            break;
                        }
                    }
                    LineCount--;
                    //
                    TodoID = 0;
                    for(int i = 5;i <= LineCount - 1; i++)
                    {
                        if(Convert.ToInt32(TodoList[i,0]) > TodoID)
                        {
                            TodoID = Convert.ToInt32(TodoList[i, 0]);
                        }
                    }
                    TodoList[3, 0] = TodoID.ToString();
                    //
                    StreamWriter write = File.CreateText(@Application.StartupPath.ToString() + "\\To-do_List\\To-do_List_Data.to-do_list_data");
                    for(int i=0;i <= LineCount-1;i++)
                    {
                        write.WriteLine(TodoList[i, 0] + "\t" + TodoList[i, 1] + "\t" + TodoList[i, 2] + "\t" + TodoList[i, 3] + "\t" + TodoList[i, 4]);
                    }
                    write.Close();
                    write.Dispose();
                }
                catch
                {
                    MessageBox.Show("在删除待办时遇到错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.DataGridView1.Rows.Remove(this.DataGridView1.SelectedRows[0]);
                if (this.DataGridView1.RowCount > 0)
                {
                    this.DataGridView1.ClearSelection();
                    this.DataGridView1.Sort(this.DataGridView1.Columns[1], ListSortDirection.Ascending);
                    this.DataGridView1.Rows[0].Selected = true;
                }
                TodoCount = 0;
                for (int i = 5;i <= LineCount;i++)
                {
                    if(TodoList[i,1] == "False")
                    {
                        TodoCount++;
                    }
                }
                this.Label_Statistics.Text = "（总计 " + (LineCount - 5).ToString() + " 项，还有 " + TodoCount.ToString() + " 项待办）";
                Alarm = new FiltrateSortAndAlarm();
                Alarm.Filtrate(TodoList);
                Ready = true;
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(Ready==true && e.ColumnIndex==1)
            {
                try
                {
                    Alarm.Stop();
                }
                catch (NullReferenceException)
                {

                }
                if (this.DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == "True")
                {
                    this.DataGridView1.Rows[e.RowIndex].Cells[4].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                    TodoCount--;
                }
                else
                {
                    this.DataGridView1.Rows[e.RowIndex].Cells[4].Value = "";
                    TodoCount++;
                }
                for (int i = 5; i <= LineCount - 1; i++)
                {
                    if (TodoList[i, 0] == this.DataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                    {
                        TodoList[i, 1] = this.DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        TodoList[i, 4] = this.DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        break;
                    }
                }
                try
                {
                    StreamWriter write = File.CreateText(@Application.StartupPath.ToString() + "\\To-do_List\\To-do_List_Data.to-do_list_data");
                    for (int i = 0; i <= LineCount - 1; i++)
                    {
                        write.WriteLine(TodoList[i, 0] + "\t" + TodoList[i, 1] + "\t" + TodoList[i, 2] + "\t" + TodoList[i, 3] + "\t" + TodoList[i, 4]);
                    }
                    write.Close();
                    write.Dispose();
                }
                catch
                {
                    MessageBox.Show("在更新待办数据文件时遇到错误，无法保存数据！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Label_Statistics.Text = "（总计 " + (LineCount-5).ToString() + " 项，还有 " + TodoCount.ToString() + " 项待办）";
                Alarm = new FiltrateSortAndAlarm();
                Alarm.Filtrate(TodoList);
            }
        }

        private void DataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                this.DataGridView1.ClearSelection();
                this.DataGridView1.Rows[e.RowIndex].Selected = true;
                this.ContextMenuStrip_DataGridView1.Show(Cursor.Position);
                Richtextbox1.BackColor = Color.Ivory;
                button_addtodo.Enabled = false;
                try
                {
                    if (e.RowIndex >= 0)
                    {
                        Richtextbox1.LoadFile(@Application.StartupPath.ToString() + "\\To-do_List\\" + this.DataGridView1.Rows[e.RowIndex].Cells[0].Value + ".to-do", RichTextBoxStreamType.RichText);
                    }
                }
                catch
                {
                    Richtextbox1.Text = "*********************\n>>>>>错误<<<<<\n无法读取当前待办详情，请检查文件有效性。\n*********************";
                }
            }
        }
        
        private void GroupBox1_Enter(object sender, EventArgs e)
        {
            if(this.DataGridView1.SelectedRows.Count != 0)
            {
                this.DataGridView1.ClearSelection();
                Richtextbox1.Text = "";
            }
            Richtextbox1.BackColor = SystemColors.Window;
            button_addtodo.Enabled = true;
        }

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            aboutwindow a = new aboutwindow();
            a.ShowDialog();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Richtextbox1.BackColor = Color.Ivory;
            button_addtodo.Enabled = false;
            if(this.DataGridView1.Rows.Count > 0)
            {
                try
                {
                    Richtextbox1.LoadFile(@Application.StartupPath.ToString() + "\\To-do_List\\" + this.DataGridView1.Rows[this.DataGridView1.CurrentRow.Index].Cells[0].Value + ".to-do", RichTextBoxStreamType.RichText);
                }
                catch
                {
                    Richtextbox1.Text = "*********************\n>>>>>错误<<<<<\n无法读取当前待办详情，请检查文件有效性。\n*********************";
                }
            }
            else
            {
                Richtextbox1.Text = "";
                Richtextbox1.BackColor = SystemColors.Window;
                Richtextbox1.ReadOnly = false;
                button_addtodo.Enabled = true;
            }
        }

        private void 捐赠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonateForm d = new DonateForm();
            d.ShowDialog();
        }

        private void DataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            try
            {
                if (e.Column.Name == "Status")
                {
                    e.SortResult = (e.CellValue1.ToString() == "False" && e.CellValue2.ToString() == "True") ?
                        -1 : (e.CellValue1.ToString() == "True" && e.CellValue2.ToString() == "False") ? 1 : 0;
                }
                else if (e.Column.Name == "Deadline" || e.Column.Name == "FinishTime" || e.Column.Name == "TodoTitle")
                {
                    e.SortResult = string.Compare(e.CellValue1.ToString(), e.CellValue2.ToString());
                }
                else
                {
                    e.SortResult = (Convert.ToInt32(e.CellValue1) - Convert.ToInt32(e.CellValue2)) > 0 ?
                        1 : (Convert.ToInt32(e.CellValue1) - Convert.ToInt32(e.CellValue2)) < 0 ? -1 : 0;
                }
            }
            catch
            {

            }
            e.Handled = true;
        }

        private void Richtextbox1_Enter(object sender, EventArgs e)
        {
            if (this.DataGridView1.SelectedRows.Count == 0)
            {
                Richtextbox1.ReadOnly = false;
                Richtextbox1.BackColor = SystemColors.Window;
            }
            else
            {
                Richtextbox1.ReadOnly = true;
                Richtextbox1.BackColor = Color.Ivory;
            }
        }

        private void AlarmDetectTimer_Tick(object sender, EventArgs e)
        {
            NowTime.Text = "（当前时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "）";
            if (Notify_Status == true && Timer_FlickerNotifyIcon.Enabled == false)
            {
                Timer_FlickerNotifyIcon.Enabled = true;
                Timer_SoundAlarm.Enabled = true;
                Timer_SoundAlarm.Start();
                Timer_FlickerNotifyIcon.Start();
                this.DataGridView1.ClearSelection();
                this.DataGridView1.Sort(this.DataGridView1.Columns[1], ListSortDirection.Ascending);
                this.DataGridView1.Rows[0].Selected = true;
            }
            else if(Notify_Status == false && Timer_FlickerNotifyIcon.Enabled == true)
            {
                Timer_FlickerNotifyIcon.Stop();
                Timer_SoundAlarm.Stop();
                Timer_FlickerNotifyIcon.Enabled = false;
                Timer_SoundAlarm.Enabled = false;
                NotifyIcon.Icon = Properties.Resources.todolist_ico;
            }
        }

        private void Timer_SoundAlarm_Tick(object sender, EventArgs e)
        {
            if(CheckBox_Sound.Checked == true)
            {
                try
                {
                    SoundPlayer a = new SoundPlayer();
                    a.SoundLocation = @Application.StartupPath.ToString() + "\\To-do_List\\Notify.wav";
                    a.Play();
                }
                catch
                {
                    Stream Sound = Properties.Resources.Notify;
                    SoundPlayer a = new SoundPlayer(Sound);
                    a.Play();
                }
            }
        }

        private void CheckBox_Sound_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBox_Sound.Checked == true)
            {
                TodoList[1, 2] = "True";
            }
            else
            {
                TodoList[1, 2] = "False";
            }
            try
            {
                StreamWriter write = File.CreateText(@Application.StartupPath.ToString() + "\\To-do_List\\To-do_List_Data.to-do_list_data");
                for (int i = 0; i <= LineCount - 1; i++)
                {
                    write.WriteLine(TodoList[i, 0] + "\t" + TodoList[i, 1] + "\t" + TodoList[i, 2] + "\t" + TodoList[i, 3] + "\t" + TodoList[i, 4]);
                }
                write.Close();
                write.Dispose();
            }
            catch
            {
                MessageBox.Show("在更新待办数据文件时遇到错误，无法保存数据！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckBox_NotifyIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_NotifyIcon.Checked == true)
            {
                TodoList[1, 3] = "True";
            }
            else
            {
                TodoList[1, 3] = "False";
            }
            try
            {
                StreamWriter write = File.CreateText(@Application.StartupPath.ToString() + "\\To-do_List\\To-do_List_Data.to-do_list_data");
                for (int i = 0; i <= LineCount - 1; i++)
                {
                    write.WriteLine(TodoList[i, 0] + "\t" + TodoList[i, 1] + "\t" + TodoList[i, 2] + "\t" + TodoList[i, 3] + "\t" + TodoList[i, 4]);
                }
                write.Close();
                write.Dispose();
            }
            catch
            {
                MessageBox.Show("在更新待办数据文件时遇到错误，无法保存数据！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


public class FiltrateSortAndAlarm
{
    public string AlarmTime;

    internal void Filtrate(string[,] OriginalArr)
    {
        int UnfinishedNum = 0;
        string[] FiltratedArr = new string[To_do_List.MainWindow.LineCount];
        for (int i = 5;i <= To_do_List.MainWindow.LineCount;i++)
        {
            if(OriginalArr[i,1] == "False")
            {
                FiltratedArr[UnfinishedNum] = OriginalArr[i, 2];
                UnfinishedNum++;
            }
        }
        if(UnfinishedNum != 0)
        {
            UnfinishedNum--;
        }
        Array.Sort(FiltratedArr);
        AlarmTime = FiltratedArr[To_do_List.MainWindow.LineCount - UnfinishedNum - 1];

        //MessageBox.Show(AlarmTime);

        Alarm();
    }

    System.Timers.Timer AlarmTimer;
    private void Alarm()
    {
        if(AlarmTimer == null)
        {
            AlarmTimer = new System.Timers.Timer();
            AlarmTimer.Interval = 1000;
            AlarmTimer.Elapsed += new System.Timers.ElapsedEventHandler(AlarmTimer_Tick);
            AlarmTimer.AutoReset = true;
            AlarmTimer.Enabled = true;
        }
        AlarmTimer.Start();
    }
    private void AlarmTimer_Tick(object sender, EventArgs e)
    {
        if (AlarmTime != null && string.Compare(AlarmTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm")) <= 0)
        {
            AlarmTimer.Stop();
            //AlarmTimer.Dispose();
            To_do_List.MainWindow.Notify_Status = true;
        }
        else if(AlarmTime != null && string.Compare(AlarmTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm")) > 0)
        {
            if(To_do_List.MainWindow.Notify_Status)
            {
                To_do_List.MainWindow.Notify_Status = false;
            }
        }
        else
        {
            AlarmTimer.Stop();
            //AlarmTimer.Dispose();
            To_do_List.MainWindow.Notify_Status = false;
        }
    }

    public void Stop()
    {
        AlarmTimer.Stop();
        //AlarmTimer.Dispose();
    }
}
