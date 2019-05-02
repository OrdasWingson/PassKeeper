using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
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
            timerStatus.Tick += (object _sender,EventArgs _e) => { label_Status.Text = "Ожидание ввода данных."; };
            programToolStripMenuItem.Text = Authentication_Form.logAccount;
            dataGridView1.RowHeadersVisible = false;
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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
                                + DateTime.Now.ToString("dd.mm.yyyy")+"')";
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
            }
            else
            {
                label_Status.Text = "Не все поля были заполнены.";
            }
        }
    }
}
