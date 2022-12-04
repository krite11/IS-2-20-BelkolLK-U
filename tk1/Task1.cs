using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_2_20_BelkolLK_U
{
    public partial class Menu : Form
    {

        abstract class Components<type>
        {
            protected int Cost;
            protected int Year;
            protected type Article;
            public Components(int cost, int year, type article)
            {
                Cost = cost;
                Year = year;
                Article = article;
            }
            public virtual string Display()
            {
                return $"Цена: {Cost} \n Год выпуска: {Year}";
            }
        }
        class HardDrive<type> : Components<type>
        {
            public int Oboroti { get; private set; }

            public string Interface { get; private set; }

            public int size { get; private set; }

            public HardDrive(int Cost, int Year, type Art, int oboroti, string _interface, int Size) : base(Cost, Year, Art)
            {
                Oboroti = oboroti;
                Interface = _interface;
                size = Size;
            }
            public override string Display()
            {
                return $"Цена: {Cost} \n Год выпуска: {Year} \n Артикул: {Article}\n Скорость оборротов: {Oboroti} \n Интерфейс подключения: {Interface} \n Объем: {size} ";
            }
        }
        class Videocarta<type> : Components<type>
        {

            public double chastota { get; private set; }

            public string Manuf { get; private set; }
            public int Size { get; private set; }
            public Videocarta(int Cost, int Year, type Art, double chastotaGPU, string manufacture, int size) : base(Cost, Year, Art)
            {
                chastota = chastotaGPU;
                Manuf = manufacture;
                Size = size;
            }
            public override string Display()
            {
                return $"Цена: {Cost} \n Год выпуска: {Year} \n Артикул: {Article}\n Частота граф.процессора: {chastota} \n Производитель: {Manuf} \n Объем памяти: {Size} ";
            }
        }
        HardDrive<int> hdd;
        Videocarta<int> videocarta;
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                hdd = new HardDrive<int>(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox13.Text), Convert.ToInt32(textBox6.Text), textBox5.Text, Convert.ToInt32(textBox7.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(hdd.Display());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                videocarta = new Videocarta<int>(Convert.ToInt32(textBox12.Text), Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox15.Text), Convert.ToInt32(textBox10.Text), textBox9.Text, Convert.ToInt32(textBox8.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(videocarta.Display());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }


}
