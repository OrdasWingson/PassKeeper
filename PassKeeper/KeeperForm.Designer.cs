namespace PassKeeper
{
    partial class KeeperForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_Syte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SytePassword = new System.Windows.Forms.TextBox();
            this.textBox_SyteLogin = new System.Windows.Forms.TextBox();
            this.textBox_SyteName = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(418, 293);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(410, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ПОСМОТРЕТЬ ПАРОЛЬ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Syte,
            this.Column_Login,
            this.Column_Password,
            this.Column_Added});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 264);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column_Syte
            // 
            this.Column_Syte.HeaderText = "Сайт";
            this.Column_Syte.Name = "Column_Syte";
            this.Column_Syte.ReadOnly = true;
            // 
            // Column_Login
            // 
            this.Column_Login.HeaderText = "Логин";
            this.Column_Login.Name = "Column_Login";
            this.Column_Login.ReadOnly = true;
            this.Column_Login.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Login.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_Login.Width = 110;
            // 
            // Column_Password
            // 
            this.Column_Password.HeaderText = "Пароль";
            this.Column_Password.Name = "Column_Password";
            this.Column_Password.ReadOnly = true;
            this.Column_Password.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Password.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_Password.Width = 115;
            // 
            // Column_Added
            // 
            this.Column_Added.HeaderText = "Дата добавления";
            this.Column_Added.Name = "Column_Added";
            this.Column_Added.ReadOnly = true;
            this.Column_Added.Width = 75;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox_SytePassword);
            this.tabPage2.Controls.Add(this.textBox_SyteLogin);
            this.tabPage2.Controls.Add(this.textBox_SyteName);
            this.tabPage2.Controls.Add(this.button_Add);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(410, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ДОБАВИТЬ ПАРОЛЬ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Status);
            this.groupBox1.Location = new System.Drawing.Point(14, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 76);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статус";
            // 
            // label_Status
            // 
            this.label_Status.Location = new System.Drawing.Point(20, 28);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(161, 33);
            this.label_Status.TabIndex = 7;
            this.label_Status.Text = "Ожидание ввода данных.";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название сайта";
            // 
            // textBox_SytePassword
            // 
            this.textBox_SytePassword.Location = new System.Drawing.Point(153, 107);
            this.textBox_SytePassword.Name = "textBox_SytePassword";
            this.textBox_SytePassword.Size = new System.Drawing.Size(226, 20);
            this.textBox_SytePassword.TabIndex = 3;
            // 
            // textBox_SyteLogin
            // 
            this.textBox_SyteLogin.Location = new System.Drawing.Point(153, 62);
            this.textBox_SyteLogin.Name = "textBox_SyteLogin";
            this.textBox_SyteLogin.Size = new System.Drawing.Size(226, 20);
            this.textBox_SyteLogin.TabIndex = 2;
            // 
            // textBox_SyteName
            // 
            this.textBox_SyteName.Location = new System.Drawing.Point(153, 19);
            this.textBox_SyteName.Name = "textBox_SyteName";
            this.textBox_SyteName.Size = new System.Drawing.Size(226, 20);
            this.textBox_SyteName.TabIndex = 1;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(213, 201);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(166, 33);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Добавить пароль";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(439, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.programToolStripMenuItem.Text = "Account";
            this.programToolStripMenuItem.Click += new System.EventHandler(this.programToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 4000;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 353);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KeeperForm";
            this.Text = "KeeperForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KeeperForm_FormClosing);
            this.Load += new System.EventHandler(this.KeeperForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_SytePassword;
        private System.Windows.Forms.TextBox textBox_SyteLogin;
        private System.Windows.Forms.TextBox textBox_SyteName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Syte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Added;
        private System.Windows.Forms.Button button1;
    }
}