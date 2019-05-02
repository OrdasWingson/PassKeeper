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
            this.label_status = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Registration = new System.Windows.Forms.Button();
            this.textBox_NewLogin = new System.Windows.Forms.TextBox();
            this.textBox_NewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_status
            // 
            this.label_status.Location = new System.Drawing.Point(84, 164);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(228, 32);
            this.label_status.TabIndex = 15;
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(318, 164);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(112, 32);
            this.button_Back.TabIndex = 14;
            this.button_Back.Text = "Назад";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Registration
            // 
            this.button_Registration.BackColor = System.Drawing.SystemColors.Control;
            this.button_Registration.Location = new System.Drawing.Point(318, 90);
            this.button_Registration.Name = "button_Registration";
            this.button_Registration.Size = new System.Drawing.Size(112, 47);
            this.button_Registration.TabIndex = 13;
            this.button_Registration.Text = "Добавить";
            this.button_Registration.UseVisualStyleBackColor = false;
            this.button_Registration.Click += new System.EventHandler(this.button_Registration_Click);
            // 
            // textBox_NewLogin
            // 
            this.textBox_NewLogin.Location = new System.Drawing.Point(87, 90);
            this.textBox_NewLogin.Name = "textBox_NewLogin";
            this.textBox_NewLogin.Size = new System.Drawing.Size(225, 20);
            this.textBox_NewLogin.TabIndex = 12;
            // 
            // textBox_NewPassword
            // 
            this.textBox_NewPassword.Location = new System.Drawing.Point(87, 117);
            this.textBox_NewPassword.Name = "textBox_NewPassword";
            this.textBox_NewPassword.Size = new System.Drawing.Size(225, 20);
            this.textBox_NewPassword.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "ПАРОЛЬ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "ЛОГИН";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите желаемые ЛОГИН и ПАРОЛЬ и нажмите добавить.\r\nПосле успешного добавления в" +
    "ернитесь в меню аутентификации нажав \r\nкнопку назад. ";
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 218);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Registration);
            this.Controls.Add(this.textBox_NewLogin);
            this.Controls.Add(this.textBox_NewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewUserForm";
            this.Text = "NewUserForm";
            this.Load += new System.EventHandler(this.NewUserForm_Load);
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
    }
}