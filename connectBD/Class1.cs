using MySql.Data.MySqlClient;


namespace connectBD
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