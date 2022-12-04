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



namespace Task2
{

    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        public class DBconnect
        {
            protected string Connect;


            public DBconnect(string connectString)
            {
                this.Connect = connectString;

            }

            public string Connection()
            {
                return this.Connect;
            }
        }

        DBconnect BD = new DBconnect("server=chuc.caseum.ru;port=33333;user=uchebka;" +
                "database=uchebka;password=uchebka;");

        MySqlConnection con;

        private void Task2_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(BD.Connection());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MessageBox.Show("Соединение работает");
            }
            catch
            {
                MessageBox.Show("Соединение не работает");
            }
            finally
            {            
                con.Close();
            }
        }


    }
}