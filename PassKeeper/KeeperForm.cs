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
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeeper
{
    public partial class KeeperForm : Form
    {
        bool isNotCloseButtonPress;

        public KeeperForm()
        {
            InitializeComponent();
            isNotCloseButtonPress = false;

        }

        private void KeeperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!isNotCloseButtonPress)
            {
                Application.Exit();
            }
                        
        }

        private void KeeperForm_Load(object sender, EventArgs e)
        {
            timerStatus.Tick += (object _sender, EventArgs _e) => { label_Status.Text = "Ожидание ввода данных."; };
            //programToolStripMenuItem.Text = Authentication_Form.logAccount;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(36,36,49);
            //dataGridView1.ColumnHeadersDefaultCellStyle.
          

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

                            dataGridView1.Rows.Add(
                                decriptFunc(Authentication_Form.logAccount, myReader["syte_name"].ToString(), Authentication_Form.keyWord),
                                decriptFunc(Authentication_Form.logAccount, myReader["login"].ToString(), Authentication_Form.keyWord),
                                decriptFunc(Authentication_Form.logAccount, myReader["password"].ToString(), Authentication_Form.keyWord),
                                myReader["data_added"].ToString(), myReader["id"].ToString());


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
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                dataGridView1.Rows[j].DefaultCellStyle.BackColor = Color.FromArgb(36, 36, 80);
                dataGridView1.Rows[j].DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //выход из аккаунта
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //здесь надо реализовать копировние в буфер
            Clipboard.SetText(dataGridView1.CurrentCell.Value.ToString());
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
                                + encriptFunc(Authentication_Form.logAccount, textBox_SyteName.Text, Authentication_Form.keyWord) + "','" 
                                + encriptFunc(Authentication_Form.logAccount, textBox_SyteLogin.Text, Authentication_Form.keyWord) + "','" 
                                + encriptFunc(Authentication_Form.logAccount, textBox_SytePassword.Text, Authentication_Form.keyWord) + "','" 
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
        private string encriptFunc(string name, string word, string key)
        {
            string nameKey = name + key;
            string wordEncr = string.Empty;
            string nameKeyEncr = string.Empty;
            MD5 md5 = new MD5CryptoServiceProvider(); //шифрование
            byte[] bytes = Encoding.Unicode.GetBytes(nameKey); //переводим в байты пароль
            byte[] byteHash = md5.ComputeHash(bytes); //преаброзовываем в md5                       
            char buf = (char)byteHash[key.Length];
            foreach (byte b in byteHash) //записываем побайтово в  переменную
                nameKeyEncr += string.Format("{0:x2}", b);

            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(word), nameKeyEncr));
        }

        private string decriptFunc(string name, string word, string key)
        {
            string nameKey = name + key; // подготовка ключа
            string wordEncr = string.Empty;
            string nameKeyEncr = string.Empty;
            MD5 md5 = new MD5CryptoServiceProvider(); //шифрование
            byte[] bytes = Encoding.Unicode.GetBytes(nameKey); //переводим в байты пароль
            byte[] byteHash = md5.ComputeHash(bytes); //преаброзовываем в md5                       
            char buf = (char)byteHash[key.Length];
            foreach (byte b in byteHash) //записываем побайтово в  переменную
                nameKeyEncr += string.Format("{0:x2}", b);

            return Decrypt(word, nameKeyEncr);
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


        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Для копирования в буфер обмена кликните по ячейке.";
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox_Search.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }


        private void textBox_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_Search_Click(sender, e);
           
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                DialogResult dialogResult = MessageBox.Show("Уверены что хотите удалить пароль от " + dataGridView1.CurrentRow.Cells["Column_Syte"].Value.ToString(), 
                    "Удаление пароля", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string id = dataGridView1.CurrentRow.Cells["Column_ID"].Value.ToString();
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

                                command.CommandText = @"DELETE FROM " + Authentication_Form.logAccount + " WHERE id = " + id;
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
                    DataGreedUpdate();
                }               
            }
        }
       

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KeeperForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            ifrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            ifrm.Show();
            isNotCloseButtonPress = true;
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

    #region tabControl setting
    public class TabControl : System.Windows.Forms.TabControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public TabControl()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);

        }


        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }


        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }
        #endregion

        #region Interop

        [StructLayout(LayoutKind.Sequential)]
        private struct NMHDR
        {
            public IntPtr HWND;
            public uint idFrom;
            public int code;
            public override String ToString()
            {
                return String.Format("Hwnd: {0}, ControlID: {1}, Code: {2}", HWND, idFrom, code);
            }
        }

        private const int TCN_FIRST = 0 - 550;
        private const int TCN_SELCHANGING = (TCN_FIRST - 2);

        private const int WM_USER = 0x400;
        private const int WM_NOTIFY = 0x4E;
        private const int WM_REFLECT = WM_USER + 0x1C00;

        #endregion

        #region BackColor Manipulation

        //As well as exposing the property to the Designer we want it to behave just like any other 
        //controls BackColor property so we need some clever manipulation.

        private Color m_Backcolor = Color.Empty;
        [Browsable(true), Description("The background color used to display text and graphics in a control.")]
        public override Color BackColor
        {
            get
            {
                if (m_Backcolor.Equals(Color.Empty))
                {
                    if (Parent == null)
                        return Control.DefaultBackColor;
                    else
                        return Parent.BackColor;
                }
                return m_Backcolor;
            }
            set
            {
                if (m_Backcolor.Equals(value)) return;
                m_Backcolor = value;
                Invalidate();
                //Let the Tabpages know that the backcolor has changed.
                base.OnBackColorChanged(EventArgs.Empty);
            }
        }
        public bool ShouldSerializeBackColor()
        {
            return !m_Backcolor.Equals(Color.Empty);
        }
        public override void ResetBackColor()
        {
            m_Backcolor = Color.Empty;
            Invalidate();
        }

        #endregion

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            Invalidate();
        }


        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            Invalidate();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(BackColor);
            Rectangle r = ClientRectangle;
            if (TabCount <= 0) return;
            //Draw a custom background for Transparent TabPages
            r = SelectedTab.Bounds;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            Font DrawFont = new Font(Font.FontFamily, 24, FontStyle.Regular, GraphicsUnit.Pixel);
            ControlPaint.DrawStringDisabled(e.Graphics, "Micks Ownerdraw TabControl", DrawFont, BackColor, (RectangleF)r, sf);
            DrawFont.Dispose();
            //Draw a border around TabPage
            r.Inflate(3, 3);
            TabPage tp = TabPages[SelectedIndex];
            SolidBrush PaintBrush = new SolidBrush(Color.FromArgb(36, 36, 49));
            SolidBrush penBrush = new SolidBrush(Color.FromArgb(36, 36, 49));
            e.Graphics.FillRectangle(PaintBrush, r);
            ControlPaint.DrawBorder(e.Graphics, r, Color.DodgerBlue, ButtonBorderStyle.Inset); //PaintBrush.Color
            //Draw the Tabs
            for (int index = 0; index <= TabCount - 1; index++)
            {
                tp = TabPages[index];
                r = GetTabRect(index);
                ButtonBorderStyle bs = ButtonBorderStyle.Inset;
                if (index == SelectedIndex)
                {
                    bs = ButtonBorderStyle.Solid;
                    PaintBrush.Color = Color.DodgerBlue;//tp.BackColor;                    
                }
                else
                {
                    PaintBrush.Color = tp.BackColor;
                    penBrush.Color = Color.White;
                }

                e.Graphics.FillRectangle(PaintBrush, r);
                ControlPaint.DrawBorder(e.Graphics, r, PaintBrush.Color, bs);


                //Set up rotation for left and right aligned tabs
                if (Alignment == TabAlignment.Left || Alignment == TabAlignment.Right)
                {
                    float RotateAngle = 90;
                    if (Alignment == TabAlignment.Left) RotateAngle = 270;
                    PointF cp = new PointF(r.Left + (r.Width >> 1), r.Top + (r.Height >> 1));
                    e.Graphics.TranslateTransform(cp.X, cp.Y);
                    e.Graphics.RotateTransform(RotateAngle);
                    r = new Rectangle(-(r.Height >> 1), -(r.Width >> 1), r.Height, r.Width);
                }
                //Draw the Tab Text
                if (tp.Enabled)
                    e.Graphics.DrawString(tp.Text, Font, penBrush, (RectangleF)r, sf);//Color.White
                else
                    ControlPaint.DrawStringDisabled(e.Graphics, tp.Text, Font, tp.BackColor, (RectangleF)r, sf);

                e.Graphics.ResetTransform();
            }

            PaintBrush.Dispose();

        }


        [Description("Occurs as a tab is being changed.")]
        public event SelectedTabPageChangeEventHandler SelectedIndexChanging;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == (WM_REFLECT + WM_NOTIFY))
            {
                NMHDR hdr = (NMHDR)(Marshal.PtrToStructure(m.LParam, typeof(NMHDR)));
                if (hdr.code == TCN_SELCHANGING)
                {
                    TabPage tp = TestTab(PointToClient(Cursor.Position));
                    if (tp != null)
                    {
                        TabPageChangeEventArgs e = new TabPageChangeEventArgs(SelectedTab, tp);
                        if (SelectedIndexChanging != null)
                            SelectedIndexChanging(this, e);
                        if (e.Cancel || tp.Enabled == false)
                        {
                            m.Result = new IntPtr(1);
                            return;
                        }
                    }
                }
            }
            base.WndProc(ref m);
        }


        private TabPage TestTab(Point pt)
        {
            for (int index = 0; index <= TabCount - 1; index++)
            {
                if (GetTabRect(index).Contains(pt.X, pt.Y))
                    return TabPages[index];
            }
            return null;
        }

    }


    public class TabPageChangeEventArgs : EventArgs
    {
        private TabPage _Selected = null;
        private TabPage _PreSelected = null;
        public bool Cancel = false;

        public TabPage CurrentTab
        {
            get
            {
                return _Selected;
            }
        }


        public TabPage NextTab
        {
            get
            {
                return _PreSelected;
            }
        }


        public TabPageChangeEventArgs(TabPage CurrentTab, TabPage NextTab)
        {
            _Selected = CurrentTab;
            _PreSelected = NextTab;
        }


    }


    public delegate void SelectedTabPageChangeEventHandler(Object sender, TabPageChangeEventArgs e);
    #endregion
   
}
