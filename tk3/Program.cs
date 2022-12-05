using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace tk3
{
    
        public class ConnectBD
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
            public ConnectBD(string connect)
            {
                Connect = connect;
            }
        }
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Task3());
        }
    }
}
