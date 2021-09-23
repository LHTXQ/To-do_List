
namespace To_do_List
{
    partial class MainWindow
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.Label label_finaltimelabel;
            System.Windows.Forms.Label label_todotitlelabel;
            System.Windows.Forms.GroupBox GroupBox2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CheckBox_NotifyIcon = new System.Windows.Forms.CheckBox();
            this.CheckBox_Sound = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Richtextbox1 = new System.Windows.Forms.RichTextBox();
            this.ContextMenuStrip_richtextbox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤消ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_addtodo = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStrip_notifyicon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.捐赠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_importfile = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_exportfile = new System.Windows.Forms.Button();
            this.Timer_FlickerNotifyIcon = new System.Windows.Forms.Timer(this.components);
            this.TextBox_todo_title = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ContextMenuStrip_DataGridView1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除待办ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TodoTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label_Statistics = new System.Windows.Forms.Label();
            this.FileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.contextMenuStrip_MainWindow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.捐赠toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer_AlarmDetect = new System.Windows.Forms.Timer(this.components);
            this.Timer_SoundAlarm = new System.Windows.Forms.Timer(this.components);
            this.NowTime = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label_finaltimelabel = new System.Windows.Forms.Label();
            label_todotitlelabel = new System.Windows.Forms.Label();
            GroupBox2 = new System.Windows.Forms.GroupBox();
            GroupBox2.SuspendLayout();
            this.ContextMenuStrip_richtextbox.SuspendLayout();
            this.ContextMenuStrip_notifyicon.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.ContextMenuStrip_DataGridView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileSystemWatcher1)).BeginInit();
            this.contextMenuStrip_MainWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.CausesValidation = false;
            label1.Name = "label1";
            // 
            // label_finaltimelabel
            // 
            resources.ApplyResources(label_finaltimelabel, "label_finaltimelabel");
            label_finaltimelabel.CausesValidation = false;
            label_finaltimelabel.Name = "label_finaltimelabel";
            // 
            // label_todotitlelabel
            // 
            resources.ApplyResources(label_todotitlelabel, "label_todotitlelabel");
            label_todotitlelabel.CausesValidation = false;
            label_todotitlelabel.Name = "label_todotitlelabel";
            // 
            // GroupBox2
            // 
            resources.ApplyResources(GroupBox2, "GroupBox2");
            GroupBox2.BackColor = System.Drawing.Color.Transparent;
            GroupBox2.Controls.Add(this.CheckBox_NotifyIcon);
            GroupBox2.Controls.Add(this.CheckBox_Sound);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.TabStop = false;
            // 
            // CheckBox_NotifyIcon
            // 
            resources.ApplyResources(this.CheckBox_NotifyIcon, "CheckBox_NotifyIcon");
            this.CheckBox_NotifyIcon.Checked = true;
            this.CheckBox_NotifyIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_NotifyIcon.Name = "CheckBox_NotifyIcon";
            this.CheckBox_NotifyIcon.UseVisualStyleBackColor = true;
            this.CheckBox_NotifyIcon.CheckedChanged += new System.EventHandler(this.CheckBox_NotifyIcon_CheckedChanged);
            // 
            // CheckBox_Sound
            // 
            resources.ApplyResources(this.CheckBox_Sound, "CheckBox_Sound");
            this.CheckBox_Sound.Checked = true;
            this.CheckBox_Sound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_Sound.Name = "CheckBox_Sound";
            this.CheckBox_Sound.UseVisualStyleBackColor = true;
            this.CheckBox_Sound.CheckedChanged += new System.EventHandler(this.CheckBox_Sound_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.CausesValidation = false;
            this.label2.Name = "label2";
            // 
            // Richtextbox1
            // 
            this.Richtextbox1.AcceptsTab = true;
            this.Richtextbox1.AutoWordSelection = true;
            this.Richtextbox1.BackColor = System.Drawing.Color.Ivory;
            this.Richtextbox1.ContextMenuStrip = this.ContextMenuStrip_richtextbox;
            this.Richtextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Richtextbox1.EnableAutoDragDrop = true;
            resources.ApplyResources(this.Richtextbox1, "Richtextbox1");
            this.Richtextbox1.Name = "Richtextbox1";
            this.Richtextbox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.Richtextbox1_LinkClicked);
            this.Richtextbox1.Enter += new System.EventHandler(this.Richtextbox1_Enter);
            // 
            // ContextMenuStrip_richtextbox
            // 
            this.ContextMenuStrip_richtextbox.AllowMerge = false;
            this.ContextMenuStrip_richtextbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.粘贴ToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.剪切ToolStripMenuItem,
            this.全选ToolStripMenuItem,
            this.撤消ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.ContextMenuStrip_richtextbox.Name = "contextMenuStrip_richtextbox";
            this.ContextMenuStrip_richtextbox.ShowImageMargin = false;
            this.ContextMenuStrip_richtextbox.ShowItemToolTips = false;
            resources.ApplyResources(this.ContextMenuStrip_richtextbox, "ContextMenuStrip_richtextbox");
            this.ContextMenuStrip_richtextbox.TabStop = true;
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            resources.ApplyResources(this.粘贴ToolStripMenuItem, "粘贴ToolStripMenuItem");
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            resources.ApplyResources(this.复制ToolStripMenuItem, "复制ToolStripMenuItem");
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            resources.ApplyResources(this.剪切ToolStripMenuItem, "剪切ToolStripMenuItem");
            this.剪切ToolStripMenuItem.Click += new System.EventHandler(this.剪切ToolStripMenuItem_Click);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            resources.ApplyResources(this.全选ToolStripMenuItem, "全选ToolStripMenuItem");
            this.全选ToolStripMenuItem.Click += new System.EventHandler(this.全选ToolStripMenuItem_Click);
            // 
            // 撤消ToolStripMenuItem
            // 
            this.撤消ToolStripMenuItem.Name = "撤消ToolStripMenuItem";
            resources.ApplyResources(this.撤消ToolStripMenuItem, "撤消ToolStripMenuItem");
            this.撤消ToolStripMenuItem.Click += new System.EventHandler(this.撤消ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            resources.ApplyResources(this.删除ToolStripMenuItem, "删除ToolStripMenuItem");
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // button_addtodo
            // 
            resources.ApplyResources(this.button_addtodo, "button_addtodo");
            this.button_addtodo.Name = "button_addtodo";
            this.button_addtodo.UseVisualStyleBackColor = true;
            this.button_addtodo.Click += new System.EventHandler(this.Addtodo_button_Click);
            // 
            // NotifyIcon
            // 
            resources.ApplyResources(this.NotifyIcon, "NotifyIcon");
            this.NotifyIcon.ContextMenuStrip = this.ContextMenuStrip_notifyicon;
            this.NotifyIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseUp);
            // 
            // ContextMenuStrip_notifyicon
            // 
            this.ContextMenuStrip_notifyicon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.捐赠ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.ContextMenuStrip_notifyicon.Name = "contextMenuStrip1";
            this.ContextMenuStrip_notifyicon.ShowItemToolTips = false;
            resources.ApplyResources(this.ContextMenuStrip_notifyicon, "ContextMenuStrip_notifyicon");
            this.ContextMenuStrip_notifyicon.TabStop = true;
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Image = global::To_do_List.Properties.Resources.todolist_png;
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            resources.ApplyResources(this.关于ToolStripMenuItem, "关于ToolStripMenuItem");
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 捐赠ToolStripMenuItem
            // 
            this.捐赠ToolStripMenuItem.Image = global::To_do_List.Properties.Resources.todolist_png;
            this.捐赠ToolStripMenuItem.Name = "捐赠ToolStripMenuItem";
            resources.ApplyResources(this.捐赠ToolStripMenuItem, "捐赠ToolStripMenuItem");
            this.捐赠ToolStripMenuItem.Click += new System.EventHandler(this.捐赠ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = global::To_do_List.Properties.Resources.todolist_png;
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            resources.ApplyResources(this.退出ToolStripMenuItem, "退出ToolStripMenuItem");
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // button_importfile
            // 
            resources.ApplyResources(this.button_importfile, "button_importfile");
            this.button_importfile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_importfile.Name = "button_importfile";
            this.button_importfile.UseVisualStyleBackColor = false;
            this.button_importfile.Click += new System.EventHandler(this.Button_importfile_Click);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "openFileDialog1";
            // 
            // button_exportfile
            // 
            resources.ApplyResources(this.button_exportfile, "button_exportfile");
            this.button_exportfile.Name = "button_exportfile";
            this.button_exportfile.UseVisualStyleBackColor = true;
            this.button_exportfile.Click += new System.EventHandler(this.Button_exportfile_Click);
            // 
            // Timer_FlickerNotifyIcon
            // 
            this.Timer_FlickerNotifyIcon.Interval = 320;
            this.Timer_FlickerNotifyIcon.Tick += new System.EventHandler(this.Timer_flickernotifyicon_Tick);
            // 
            // TextBox_todo_title
            // 
            resources.ApplyResources(this.TextBox_todo_title, "TextBox_todo_title");
            this.TextBox_todo_title.Name = "TextBox_todo_title";
            // 
            // DateTimePicker1
            // 
            resources.ApplyResources(this.DateTimePicker1, "DateTimePicker1");
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker1.MinDate = new System.DateTime(1949, 10, 1, 0, 0, 0, 0);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Value = new System.DateTime(2021, 7, 7, 7, 0, 0, 0);
            // 
            // GroupBox1
            // 
            resources.ApplyResources(this.GroupBox1, "GroupBox1");
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(label_todotitlelabel);
            this.GroupBox1.Controls.Add(label_finaltimelabel);
            this.GroupBox1.Controls.Add(this.TextBox_todo_title);
            this.GroupBox1.Controls.Add(this.DateTimePicker1);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // ContextMenuStrip_DataGridView1
            // 
            this.ContextMenuStrip_DataGridView1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除待办ToolStripMenuItem1});
            this.ContextMenuStrip_DataGridView1.Name = "contextMenuStrip_checklistbox";
            this.ContextMenuStrip_DataGridView1.ShowImageMargin = false;
            this.ContextMenuStrip_DataGridView1.ShowItemToolTips = false;
            resources.ApplyResources(this.ContextMenuStrip_DataGridView1, "ContextMenuStrip_DataGridView1");
            this.ContextMenuStrip_DataGridView1.TabStop = true;
            // 
            // 删除待办ToolStripMenuItem1
            // 
            this.删除待办ToolStripMenuItem1.Name = "删除待办ToolStripMenuItem1";
            resources.ApplyResources(this.删除待办ToolStripMenuItem1, "删除待办ToolStripMenuItem1");
            this.删除待办ToolStripMenuItem1.Click += new System.EventHandler(this.删除待办ToolStripMenuItem1_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumber,
            this.Status,
            this.Deadline,
            this.TodoTitle,
            this.FinishTime});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            resources.ApplyResources(this.DataGridView1, "DataGridView1");
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridView1.RowTemplate.Height = 23;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseUp);
            this.DataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            this.DataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            this.DataGridView1.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.DataGridView1_SortCompare);
            // 
            // SerialNumber
            // 
            this.SerialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SerialNumber.DefaultCellStyle = dataGridViewCellStyle9;
            resources.ApplyResources(this.SerialNumber, "SerialNumber");
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.Status, "Status");
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Deadline
            // 
            this.Deadline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Deadline.DefaultCellStyle = dataGridViewCellStyle10;
            resources.ApplyResources(this.Deadline, "Deadline");
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            this.Deadline.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TodoTitle
            // 
            this.TodoTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TodoTitle.DefaultCellStyle = dataGridViewCellStyle11;
            resources.ApplyResources(this.TodoTitle, "TodoTitle");
            this.TodoTitle.Name = "TodoTitle";
            this.TodoTitle.ReadOnly = true;
            this.TodoTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FinishTime
            // 
            this.FinishTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FinishTime.DefaultCellStyle = dataGridViewCellStyle12;
            resources.ApplyResources(this.FinishTime, "FinishTime");
            this.FinishTime.Name = "FinishTime";
            this.FinishTime.ReadOnly = true;
            this.FinishTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Label_Statistics
            // 
            resources.ApplyResources(this.Label_Statistics, "Label_Statistics");
            this.Label_Statistics.BackColor = System.Drawing.Color.Transparent;
            this.Label_Statistics.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label_Statistics.Name = "Label_Statistics";
            this.Label_Statistics.UseMnemonic = false;
            // 
            // FileSystemWatcher1
            // 
            this.FileSystemWatcher1.EnableRaisingEvents = true;
            this.FileSystemWatcher1.Filter = "To-do_List_Data.to-do_list_data";
            this.FileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.FileSystemWatcher1.SynchronizingObject = this;
            // 
            // contextMenuStrip_MainWindow
            // 
            this.contextMenuStrip_MainWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem1,
            this.捐赠toolStripMenuItem1});
            this.contextMenuStrip_MainWindow.Name = "contextMenuStrip_MainWindow";
            resources.ApplyResources(this.contextMenuStrip_MainWindow, "contextMenuStrip_MainWindow");
            // 
            // 关于ToolStripMenuItem1
            // 
            this.关于ToolStripMenuItem1.Image = global::To_do_List.Properties.Resources.todolist_png;
            this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            resources.ApplyResources(this.关于ToolStripMenuItem1, "关于ToolStripMenuItem1");
            this.关于ToolStripMenuItem1.Click += new System.EventHandler(this.关于ToolStripMenuItem1_Click);
            // 
            // 捐赠toolStripMenuItem1
            // 
            this.捐赠toolStripMenuItem1.Image = global::To_do_List.Properties.Resources.todolist_png;
            this.捐赠toolStripMenuItem1.Name = "捐赠toolStripMenuItem1";
            resources.ApplyResources(this.捐赠toolStripMenuItem1, "捐赠toolStripMenuItem1");
            this.捐赠toolStripMenuItem1.Click += new System.EventHandler(this.捐赠ToolStripMenuItem_Click);
            // 
            // Timer_AlarmDetect
            // 
            this.Timer_AlarmDetect.Enabled = true;
            this.Timer_AlarmDetect.Interval = 500;
            this.Timer_AlarmDetect.Tick += new System.EventHandler(this.AlarmDetectTimer_Tick);
            // 
            // Timer_SoundAlarm
            // 
            this.Timer_SoundAlarm.Interval = 5000;
            this.Timer_SoundAlarm.Tick += new System.EventHandler(this.Timer_SoundAlarm_Tick);
            // 
            // NowTime
            // 
            resources.ApplyResources(this.NowTime, "NowTime");
            this.NowTime.BackColor = System.Drawing.Color.Transparent;
            this.NowTime.ForeColor = System.Drawing.SystemColors.Highlight;
            this.NowTime.Name = "NowTime";
            this.NowTime.UseMnemonic = false;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip_MainWindow;
            this.Controls.Add(this.NowTime);
            this.Controls.Add(GroupBox2);
            this.Controls.Add(this.Label_Statistics);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.button_exportfile);
            this.Controls.Add(this.button_importfile);
            this.Controls.Add(this.button_addtodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.Richtextbox1);
            this.Controls.Add(this.GroupBox1);
            this.DoubleBuffered = true;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            this.ContextMenuStrip_richtextbox.ResumeLayout(false);
            this.ContextMenuStrip_notifyicon.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ContextMenuStrip_DataGridView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileSystemWatcher1)).EndInit();
            this.contextMenuStrip_MainWindow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox Richtextbox1;
        private System.Windows.Forms.Button button_addtodo;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_notifyicon;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_richtextbox;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤消ToolStripMenuItem;
        private System.Windows.Forms.Button button_importfile;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private System.Windows.Forms.Button button_exportfile;
        private System.Windows.Forms.Timer Timer_FlickerNotifyIcon;
        private System.Windows.Forms.TextBox TextBox_todo_title;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_DataGridView1;
        private System.Windows.Forms.ToolStripMenuItem 删除待办ToolStripMenuItem1;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Label Label_Statistics;
        private System.IO.FileSystemWatcher FileSystemWatcher1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_MainWindow;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 捐赠toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 捐赠ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn TodoTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishTime;
        private System.Windows.Forms.Timer Timer_AlarmDetect;
        private System.Windows.Forms.Timer Timer_SoundAlarm;
        private System.Windows.Forms.CheckBox CheckBox_NotifyIcon;
        private System.Windows.Forms.CheckBox CheckBox_Sound;
        private System.Windows.Forms.Label NowTime;
    }
}

