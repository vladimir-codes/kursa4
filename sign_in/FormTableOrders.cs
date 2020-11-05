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
    public partial class FormTableOrders : Form
    {
        public FormTableOrders()
        {
            InitializeComponent();
            updata();
        }
        private void updata()
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand();
            string commandString = "SELECT * FROM orders;";
            command.CommandText = commandString;
            command.Connection = db.Connect();
            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                this.dataGridView1.Columns.Add("Id", "id");
                this.dataGridView1.Columns.Add("Type", "Вид отправления");
                this.dataGridView1.Columns.Add("Number", "Номер отправления");
                this.dataGridView1.Columns.Add("Data", "Дата и время отправления");
                this.dataGridView1.Columns.Add("FromIndex", "Откуда индекс");
                this.dataGridView1.Columns.Add("Number", "Куда индекс");
                this.dataGridView1.Columns.Add("Id", "Куда адрес");
                this.dataGridView1.Columns.Add("Type", "Кому");
                this.dataGridView1.Columns.Add("Number", "Вес");
                this.dataGridView1.Columns.Add("Number", "Плата за пересылку");
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["id"].ToString(),
                        reader["Вид отправления"].ToString(),
                        reader["Номер отправления"].ToString(),
                        reader["Дата и время отправления"].ToString(),
                        reader["Откуда индекс"].ToString(),
                        reader["Куда индекс"].ToString(),
                        reader["Куда адрес"].ToString(),
                        reader["Кому"].ToString(),
                        reader["Вес"].ToString(),
                        reader["Плата за пересылку"].ToString()
                        );
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: \r\n{0}", ex.ToString());
            }
            command.Connection.Close();
        }
    }
}
