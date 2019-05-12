namespace PassKeeper
{
    partial class NewUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserForm));
            this.label_status = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Registration = new System.Windows.Forms.Button();
            this.textBox_NewLogin = new System.Windows.Forms.TextBox();
            this.textBox_NewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_status
            // 
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_status.Location = new System.Drawing.Point(17, 232);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(303, 37);
            this.label_status.TabIndex = 15;
            this.label_status.Text = "Ожидается ввод данных.";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Back.Location = new System.Drawing.Point(17, 284);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(303, 32);
            this.button_Back.TabIndex = 14;
            this.button_Back.Text = "Назад";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Registration
            // 
            this.button_Registration.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Registration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Registration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button_Registration.Location = new System.Drawing.Point(17, 187);
            this.button_Registration.Name = "button_Registration";
            this.button_Registration.Size = new System.Drawing.Size(303, 32);
            this.button_Registration.TabIndex = 13;
            this.button_Registration.Text = "Добавить";
            this.button_Registration.UseVisualStyleBackColor = false;
            this.button_Registration.Click += new System.EventHandler(this.button_Registration_Click);
            // 
            // textBox_NewLogin
            // 
            this.textBox_NewLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox_NewLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_NewLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_NewLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_NewLogin.Location = new System.Drawing.Point(104, 94);
            this.textBox_NewLogin.Name = "textBox_NewLogin";
            this.textBox_NewLogin.Size = new System.Drawing.Size(212, 26);
            this.textBox_NewLogin.TabIndex = 12;
            // 
            // textBox_NewPassword
            // 
            this.textBox_NewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox_NewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_NewPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_NewPassword.Location = new System.Drawing.Point(104, 137);
            this.textBox_NewPassword.Name = "textBox_NewPassword";
            this.textBox_NewPassword.Size = new System.Drawing.Size(212, 26);
            this.textBox_NewPassword.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "ПАРОЛЬ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "ЛОГИН";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите желаемые ЛОГИН и ПАРОЛЬ и нажмите добавить.\r\nПосле успешного добавления в" +
    "ернитесь в меню \r\nаутентификации нажав кнопку назад. ";
            // 
            // button_Exit
            // 
            this.button_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Exit.BackgroundImage")));
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.ForeColor = System.Drawing.Color.Teal;
            this.button_Exit.Location = new System.Drawing.Point(302, 6);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(26, 26);
            this.button_Exit.TabIndex = 16;
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(340, 341);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Registration);
            this.Controls.Add(this.textBox_NewLogin);
            this.Controls.Add(this.textBox_NewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "NewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewUserForm_FormClosing);
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewUserForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Registration;
        private System.Windows.Forms.TextBox textBox_NewLogin;
        private System.Windows.Forms.TextBox textBox_NewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Exit;
    }
}