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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
