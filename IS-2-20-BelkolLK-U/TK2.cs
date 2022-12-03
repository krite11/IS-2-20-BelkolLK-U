using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace IS_2_20_BelkolLK_U
{
    public partial class Form2 : Form
    {

        public class BDconnect
        {
            protected string connect;

            public BDconnect(string Connect)
            {
                this.connect = Connect;
            }

            public string GetConnectionString()
            {
                return this.connect;
            }
        }

        BDconnect BD = new BDconnect("server=chuc.caseum.ru;port=33333;user=uchebka;" +
                "database=uchebka;password=uchebka;");

        SqlConnection con;

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(BD.GetConnectionString());
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

}    }
