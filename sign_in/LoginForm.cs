using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sign_in
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LabelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
               
        private void LoginButton_Click(object sender, EventArgs e)
        {
            login();
        }
        
        Point lastPos; 
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                this.Left += e.X - lastPos.X;
                this.Top += e.Y - lastPos.Y;

            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPos = new Point(e.X , e.Y);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        
        private void login() {
            if (LoginBox.Text == "" || PassBox.Text == "")
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }
            if (try_connect() == false) return;
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@l AND `password`=@p", db.Connect());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = LoginBox.Text;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = PassBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();


                command = new MySqlCommand("INSERT INTO `logs` ( `comment`) VALUES( @c)", db.Connect());

                // command.Parameters.Add("@data", MySqlDbType.DateTime).Value = DateTime.Now;
                command.Parameters.Add("@c", MySqlDbType.VarChar).Value = "LOGIN USER: " + LoginBox.Text;

                db.OpenConnect();
                command.ExecuteNonQuery();
                db.CloseConnect();
            }
            else MessageBox.Show("Неверный логин или пароль");
            db.CloseConnect();
        }

        private void PassBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) login();
        }

        private void LoginBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) login();
        }

        private bool try_connect() {
            try
            {
                DataBase db = new DataBase();
                db.OpenConnect();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Проблема с соединением c БД");
                return false;           
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }
    }

}
