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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeeperForm));
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl2 = new PassKeeper.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_Syte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label_Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SyteName = new System.Windows.Forms.TextBox();
            this.textBox_SyteLogin = new System.Windows.Forms.TextBox();
            this.textBox_SytePassword = new System.Windows.Forms.TextBox();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 4000;
            // 
            // button_Exit
            // 
            this.button_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Exit.BackgroundImage")));
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_Exit.Location = new System.Drawing.Point(418, 0);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(26, 26);
            this.button_Exit.TabIndex = 17;
            this.toolTip.SetToolTip(this.button_Exit, "Закрыть приложение");
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Back
            // 
            this.button_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Back.BackgroundImage")));
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_Back.Location = new System.Drawing.Point(354, 0);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(26, 26);
            this.button_Back.TabIndex = 19;
            this.toolTip.SetToolTip(this.button_Back, "Выйти из аккаунта");
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(386, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 20;
            this.toolTip.SetToolTip(this.button1, "Свернуть");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(0, 32);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(442, 392);
            this.tabControl2.TabIndex = 18;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.textBox_Search);
            this.tabPage3.Controls.Add(this.button_Search);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(434, 363);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Посмотреть пароль";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Syte,
            this.Column_Login,
            this.Column_Password,
            this.Column_Data,
            this.Column_ID});
            this.dataGridView1.Location = new System.Drawing.Point(0, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(438, 323);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
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
            // 
            // Column_Password
            // 
            this.Column_Password.HeaderText = "Пароль";
            this.Column_Password.Name = "Column_Password";
            this.Column_Password.ReadOnly = true;
            // 
            // Column_Data
            // 
            this.Column_Data.HeaderText = "Дата добавления";
            this.Column_Data.Name = "Column_Data";
            this.Column_Data.ReadOnly = true;
            // 
            // Column_ID
            // 
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            this.Column_ID.Visible = false;
            // 
            // textBox_Search
            // 
            this.textBox_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Search.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_Search.Location = new System.Drawing.Point(3, 12);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(297, 26);
            this.textBox_Search.TabIndex = 2;
            this.textBox_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Search_KeyDown);
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button_Search.Location = new System.Drawing.Point(307, 12);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(105, 26);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "Поиск";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tabPage4.Controls.Add(this.label_Status);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.button_Add);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.textBox_SyteName);
            this.tabPage4.Controls.Add(this.textBox_SyteLogin);
            this.tabPage4.Controls.Add(this.textBox_SytePassword);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(434, 363);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Добавить пароль";
            // 
            // label_Status
            // 
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Status.Location = new System.Drawing.Point(97, 196);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(235, 33);
            this.label_Status.TabIndex = 7;
            this.label_Status.Text = "Ожидание ввода данных.";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название сайта";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button_Add.Location = new System.Drawing.Point(34, 252);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(350, 33);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Добавить пароль";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин";
            // 
            // textBox_SyteName
            // 
            this.textBox_SyteName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox_SyteName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_SyteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SyteName.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_SyteName.Location = new System.Drawing.Point(137, 51);
            this.textBox_SyteName.Name = "textBox_SyteName";
            this.textBox_SyteName.Size = new System.Drawing.Size(247, 26);
            this.textBox_SyteName.TabIndex = 1;
            // 
            // textBox_SyteLogin
            // 
            this.textBox_SyteLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox_SyteLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_SyteLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SyteLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_SyteLogin.Location = new System.Drawing.Point(137, 94);
            this.textBox_SyteLogin.Name = "textBox_SyteLogin";
            this.textBox_SyteLogin.Size = new System.Drawing.Size(247, 26);
            this.textBox_SyteLogin.TabIndex = 2;
            // 
            // textBox_SytePassword
            // 
            this.textBox_SytePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox_SytePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_SytePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SytePassword.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_SytePassword.Location = new System.Drawing.Point(137, 139);
            this.textBox_SytePassword.Name = "textBox_SytePassword";
            this.textBox_SytePassword.Size = new System.Drawing.Size(247, 26);
            this.textBox_SytePassword.TabIndex = 3;
            // 
            // KeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(444, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.button_Exit);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeeperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Хранитель паролей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KeeperForm_FormClosing);
            this.Load += new System.EventHandler(this.KeeperForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KeeperForm_MouseDown);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_SytePassword;
        private System.Windows.Forms.TextBox textBox_SyteLogin;
        private System.Windows.Forms.TextBox textBox_SyteName;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button button_Exit;
        private TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Syte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button1;
        /* private System.Windows.Forms.DataGridViewTextBoxColumn ID_column;
private System.Windows.Forms.DataGridViewTextBoxColumn Column_Added;
private System.Windows.Forms.DataGridViewTextBoxColumn Column_Password;
private System.Windows.Forms.DataGridViewTextBoxColumn Column_Login;
private System.Windows.Forms.DataGridViewTextBoxColumn Column_Syte;*/
    }
}