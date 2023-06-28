using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TicTacToe
{
    class DB
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TV08BN1\FAHAD;Initial Catalog=tiktik;Integrated Security=True");
        public SqlConnection Con()
        {
            return connection;
        }
        public void opencon()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closecon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
