using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeeper
{
    public partial class KeeperForm : Form
    {
        public KeeperForm()
        {
            InitializeComponent();
        }

        private void KeeperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void KeeperForm_Load(object sender, EventArgs e)
        {
            timerStatus.Tick += (object _sender, EventArgs _e) => { label_Status.Text = "Ожидание ввода данных."; };
            programToolStripMenuItem.Text = Authentication_Form.logAccount;
            dataGridView1.RowHeadersVisible = false;
            DataGreedUpdate();
        }

        private void DataGreedUpdate()
        {
            dataGridView1.Rows.Clear();            
            SQLiteFactory factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");
            using (SQLiteConnection connection = (SQLiteConnection)factory.CreateConnection())
            {

                connection.ConnectionString = "Data Source = " + Authentication_Form.dbFileName;
                connection.Open();
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {

                        command.CommandText = @"SELECT * FROM " + Authentication_Form.logAccount;
                        command.CommandType = CommandType.Text;

                        SQLiteDataReader myReader = command.ExecuteReader();
                        while (myReader.Read())
                        {

                            dataGridView1.Rows.Add(myReader["syte_name"].ToString(),
                                myReader["login"].ToString(),
                                myReader["password"].ToString(),
                                myReader["data_added"].ToString());


                        }
                        myReader.Close();
                        connection.Close();

                    }
                }
                catch
                {
                    Console.WriteLine("Count not insert.");
                }
                connection.Close();
            }
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //выход из аккаунта
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //здесь надо реализовать копировние в буфер
            MessageBox.Show(dataGridView1.CurrentCell.Value.ToString());
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if(textBox_SyteName.Text != "" && textBox_SyteLogin.Text != "" && textBox_SytePassword.Text != "")
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
                            command.CommandText = @"INSERT INTO " + Authentication_Form.logAccount + "('syte_name','login','password','data_added') VALUES('" 
                                + textBox_SyteName.Text + "','" 
                                + textBox_SyteLogin.Text + "','" 
                                + textBox_SytePassword.Text + "','" 
                                + DateTime.Now.ToString("dd.MM.yyyy")+"')";
                            command.CommandType = CommandType.Text;
                            command.ExecuteNonQuery();
                        }
                    }
                    catch(ArgumentException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

                label_Status.Text = "Пароль успешно сохранен.";
                textBox_SyteName.Text = "";
                textBox_SyteLogin.Text = "";
                textBox_SytePassword.Text = "";
                timerStatus.Start();
                DataGreedUpdate();
            }
            else
            {
                label_Status.Text = "Не все поля были заполнены.";
            }
        }
        #region шифрование
        private void encriptFunc(string name, string word, string key)
        {
            string nameKey = name + key;
            string wordEncr = string.Empty;
            string pd = string.Empty;
            MD5 md5 = new MD5CryptoServiceProvider(); //шифрование
            byte[] bytes = Encoding.Unicode.GetBytes(nameKey); //переводим в байты пароль
            byte[] byteHash = md5.ComputeHash(bytes); //преаброзовываем в md5                       
            char buf = (char)byteHash[key.Length];
            foreach (byte b in byteHash) //записываем побайтово в  переменную
                pd += string.Format("{0:x2}", b);

            string dksdjdj = Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(word), pd));
            MessageBox.Show(dksdjdj);
            MessageBox.Show(Decrypt(dksdjdj, pd));

        }


        private static byte[] Encrypt(byte[] key, string value)
        {
            SymmetricAlgorithm Sa = Rijndael.Create();
            ICryptoTransform Ct = Sa.CreateEncryptor((new PasswordDeriveBytes(value, null)).GetBytes(16), new byte[16]);

            MemoryStream Ms = new MemoryStream();
            CryptoStream Cs = new CryptoStream(Ms, Ct, CryptoStreamMode.Write);

            Cs.Write(key, 0, key.Length);
            Cs.FlushFinalBlock();

            byte[] Result = Ms.ToArray();

            Ms.Close();
            Ms.Dispose();

            Cs.Close();
            Cs.Dispose();

            Ct.Dispose();

            return Result;
        }

        [DebuggerNonUserCodeAttribute]
        public static string Decrypt(string str, string keyCrypt)
        {
            string Result;
            try
            {
                CryptoStream Cs = InternalDecrypt(Convert.FromBase64String(str), keyCrypt);
                StreamReader Sr = new StreamReader(Cs);

                Result = Sr.ReadToEnd();

                Cs.Close();
                Cs.Dispose();

                Sr.Close();
                Sr.Dispose();
            }
            catch (CryptographicException)
            {
                return null;
            }

            return Result;
        }

        private static CryptoStream InternalDecrypt(byte[] key, string value)
        {
            SymmetricAlgorithm sa = Rijndael.Create();
            ICryptoTransform ct = sa.CreateDecryptor((new PasswordDeriveBytes(value, null)).GetBytes(16), new byte[16]);

            MemoryStream ms = new MemoryStream(key);
            return new CryptoStream(ms, ct, CryptoStreamMode.Read);
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            encriptFunc(Authentication_Form.logAccount, textBox_SytePassword.Text, Authentication_Form.keyWord);
        }

    }
}
