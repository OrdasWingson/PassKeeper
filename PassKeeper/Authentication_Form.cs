using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;

namespace PassKeeper
{
    public partial class Authentication_Form : Form
    {
        
        private SQLiteCommand db_sqlCmd;
        public static string dbFileName = "KeeperDB.pkdb";
        public static string keyWord = string.Empty;
        public static string logAccount = string.Empty;
        public Authentication_Form()
        {
            InitializeComponent();                      
        }

        private void button_Registration_Click(object sender, EventArgs e)
        {
            NewUserForm newUserForm = new NewUserForm();
            newUserForm.Show();
            this.Hide();
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            string passDB = string.Empty; //пароль из базы данных            
            string password = string.Empty;//введеный пароль

            MD5 md5 = new MD5CryptoServiceProvider(); //шифрование
            byte[] bytes = Encoding.Unicode.GetBytes(textBox_Password.Text); //переводим в байты пароль
            byte[] byteHash = md5.ComputeHash(bytes); //преаброзовываем в md5           
            foreach (byte b in byteHash) //записываем побайтово в  переменную
                password += string.Format("{0:x2}", b);

            
            try
            {               
                SQLiteFactory factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");
                using (SQLiteConnection connection = (SQLiteConnection)factory.CreateConnection())
                {
                    connection.ConnectionString = "Data Source = " + dbFileName;
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = @"SELECT password FROM users WHERE login = '" + textBox_Login.Text+"'";
                        command.CommandType = CommandType.Text;
                        
                        SQLiteDataReader myReader = command.ExecuteReader();
                        while (myReader.Read())
                        {
                            passDB = myReader["password"].ToString();
                            
                        }                       
                        myReader.Close();
                        

                        if(passDB.Equals(password))
                        {
                            keyWord = textBox_Password.Text;
                            logAccount = textBox_Login.Text;
                            KeeperForm keeperForm = new KeeperForm();
                            keeperForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Не верный логин или пароль.");
                        }
                        
                    }
                }            
            }
            catch
            {
                MessageBox.Show("Сбой работы базы данных.");
            }
        }

        private void Authentication_Form_Load(object sender, EventArgs e)
        {            
            db_sqlCmd = new SQLiteCommand();           

            if (!File.Exists(dbFileName))
            {
                SQLiteConnection.CreateFile(dbFileName);
                SQLiteFactory factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");
                using (SQLiteConnection connection = (SQLiteConnection)factory.CreateConnection())
                {
                    connection.ConnectionString = "Data Source = " + dbFileName;
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = @"CREATE TABLE [users] (
                    [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                    [login] char(15) NOT NULL,
                    [password] char(32) NOT NULL                    
                    );";
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
            }
               
        }


       

        private void textBox_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Enter_Click(sender, e);
        }

        private void textBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Enter_Click(sender,e);
        }
    }
}
