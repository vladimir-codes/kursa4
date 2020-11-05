using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sign_in
{
    class DataBase
    {
        const string info = "server=localhost;port=8889;username=root;password=root;database=post_bd";
        MySqlConnection connect = new MySqlConnection(info);


        public void OpenConnect() {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }
        public void CloseConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }
        public MySqlConnection Connect() {
            return connect;
        }
    }
}
