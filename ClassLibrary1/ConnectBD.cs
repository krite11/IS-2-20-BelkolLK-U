using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConnectBD
{
    public class connectBD
    {
        string Connect;
        MySqlConnection Con;

        public MySqlConnection Connection()
        {
            Con = new MySqlConnection(Connect);
            return Con;
        }
        public string ReturnCon()
        {
            return Connect;
        }
        public connectBD(string connect)
        {
            Connect = connect;
        }
    }
}