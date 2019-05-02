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
            Encryption();

        }

        private void Encryption()
        {
            MD5 md5 = new MD5CryptoServiceProvider(); //шифрование
            byte[] bytes = Encoding.Unicode.GetBytes(textBox_NewPassword.Text); //переводим в байты пароль
            byte[] byteHash = md5.ComputeHash(bytes); //преаброзовываем в md5
            string hash = string.Empty; //очищаем переменную
            foreach (byte b in byteHash) //записываем побайтово в  переменную
                hash += string.Format("{0:x2}", b);           
            string pass = hash;
            AddUser(textBox_NewLogin.Text, pass);
            label_status.Text = "Пользователь удачно добавлен.";
        }

        void AddUser(string login, string password)
        {
            SQLiteFactory factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");
            using (SQLiteConnection connection = (SQLiteConnection)factory.CreateConnection())
            {
                
                connection.ConnectionString = "Data Source = " + Authentication_Form.dbFileName;
                connection.Open();
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        
                        command.CommandText = @"INSERT INTO Users('login','password') VALUES('" + login + "','" + password + "')" ;
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                      
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
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
            this.Close();
        }
     
    }
}
