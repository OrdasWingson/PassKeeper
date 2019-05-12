using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeeper
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }

        private void button_Registration_Click(object sender, EventArgs e)
        {
            AddUser(textBox_NewLogin.Text, textBox_NewPassword.Text);
        }

        private string Encryption(string password)
        {
            MD5 md5 = new MD5CryptoServiceProvider(); //шифрование
            byte[] bytes = Encoding.Unicode.GetBytes(password); //переводим в байты пароль
            byte[] byteHash = md5.ComputeHash(bytes); //преаброзовываем в md5
            string hash = string.Empty; //очищаем переменную
            foreach (byte b in byteHash) //записываем побайтово в  переменную
                hash += string.Format("{0:x2}", b);                       
            return hash;
                        
        }

        void AddUser(string login, string password)
        {
            if(textBox_NewLogin.Text=="" || textBox_NewPassword.Text == "")
            {
                label_status.Text = "Данные для регистрации\n заполнены не полностью.";
                //MessageBox.Show("Данные для регистрации заполнены не полностью.");
                return;
            }
            SQLiteFactory factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");
            using (SQLiteConnection connection = (SQLiteConnection)factory.CreateConnection())
            {
                
                connection.ConnectionString = "Data Source = " + Authentication_Form.dbFileName;
                connection.Open();
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = @"SELECT password FROM users WHERE login = '" + textBox_NewLogin.Text + "'";
                        command.CommandType = CommandType.Text;
                        SQLiteDataReader myReader = command.ExecuteReader();
                        command.Dispose();
                        if (!myReader.HasRows)
                        {
                            command.CommandText = @"INSERT INTO users('login','password') VALUES('" + login + "','" + Encryption(password) + "'); CREATE TABLE [" + login + @"] (
                                [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                                [syte_name] char(32) NOT NULL,
                                [login] char(50) NOT NULL,
                                [password] char(50) NOT NULL,
                                [data_added] char(10) NOT NULL                      
                                );";
                            command.CommandType = CommandType.Text;
                            command.ExecuteNonQuery();
   
                            label_status.Text = "Пользователь удачно добавлен.";
                            textBox_NewLogin.Text = "";
                            textBox_NewPassword.Text = "";
                        }
                        else
                        {
                            label_status.Text = "Такой логин уже существует.";
                            //MessageBox.Show("Такой логин уже существует.");
                        }
                        
                      
                    }
                }
                catch
                {
                    Console.WriteLine("Count not insert.");
                }
                connection.Close();
                
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            ifrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            ifrm.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewUserForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
