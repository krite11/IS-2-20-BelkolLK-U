using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using tk3;
   
namespace tk3
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void Task3_Load(object sender, EventArgs e)
        {
           
            conn = connectbd.Connection();
            Car();

        }
        MySqlConnection conn;
        MySqlDataAdapter MyDA = new MySqlDataAdapter();
        DataTable DT = new DataTable();
        BindingSource BindingS = new BindingSource();
        ConnectBD connectbd = new ConnectBD("server=chuc.caseum.ru;port=33333;username=st_2_20_1;password=93583167;database=is_2_20_st1_KURS");
       

        public void Car()
        {
            DT.Clear();
            string table = "SELECT Car.car_brand AS `марка`,Car.car_model AS `модель`, Car.colour AS `цвет` FROM Car";
            conn.Open();
            MyDA.SelectCommand = new MySqlCommand(table, conn);
            MyDA.Fill(DT);
            BindingS.DataSource = DT;
            dataGridView1.DataSource = BindingS;
            conn.Close();

            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;




            dataGridView1.Columns[0].FillWeight = 15;
            dataGridView1.Columns[1].FillWeight = 15;
            dataGridView1.Columns[2].FillWeight = 15;



            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;



            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ColumnHeadersVisible = true;

        }


       

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string car_brand = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            conn.Open();
            string a1 = "";
            string a2 = "";
            string a3 = "";
            string sql = $"SELECT  Car.car_brand AS `марка`, Car.car_model AS `модель`,  Car.colour AS `цвет` FROM Car WHERE Car.car_brand_Car = " + car_brand;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                a1 = reader[0].ToString();
                a2 = reader[1].ToString();
                a3 = reader[2].ToString();
            }
            reader.Close();
            MessageBox.Show($"марка: {a1} модель: {a2} цвет: {a3}");
            conn.Close();
        }

    }
}
