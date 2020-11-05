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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
          private void button1_Click(object sender, EventArgs e)
        {
            FormTableOrders form = new FormTableOrders();
            form.ShowDialog();
        }

        Point lastPos;
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPos.X;
                this.Top += e.Y - lastPos.Y;

            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPos = new Point(e.X, e.Y);
        }

        private void MainForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("test");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(220, 70, 70);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(30, 33, 38);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal; else
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(40, 43, 46);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(30, 33, 38);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(30, 33, 38);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(40, 43, 46);
        }
        
        private void button_exit_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();   
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculatorForm form = new CalculatorForm();
            form.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string OPS = textBox1.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:/POCHTA/Свод готовый.xlsx");

        }
    }

}