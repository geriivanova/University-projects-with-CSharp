using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсова_работа
{
    public partial class Form1 : Form
    {
        public List<Sale> sales = new List<Sale>();
        FileStream fs;
        string fileName = "Stock.txt";
        public Form1()
        {
            InitializeComponent();
            fs = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryReader br = new BinaryReader(fs);
            while (fs.Position < fs.Length)
            {
                Sale st = new Sale();
                st.bonNumber = br.ReadString();
                st.stock = br.ReadString();
                st.quantity = br.ReadInt32();
                st.price = br.ReadDouble();
                sales.Add(st);
                dataGridView1.Rows.Add(st.bonNumber, st.stock, st.quantity, st.price, st.quantity * st.price);
            }
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2(this).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3(this).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form4(this).Show();
        }

        public void AddToDataGridView(string bonNumber, string stock, int quantity, double price, double value)
        {
            dataGridView1.Rows.Add(bonNumber, stock, quantity, price, value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изход от приложението");
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sales.Clear();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                Sale st = new Sale();
                st.bonNumber = dataGridView1[0, i].Value.ToString();
                st.stock = dataGridView1[1, i].Value.ToString();
                st.quantity = Convert.ToInt32(dataGridView1[2, i].Value.ToString());
                st.price = Convert.ToDouble(dataGridView1[3, i].Value.ToString());
                sales.Add(st);
            }
            fs = new FileStream(fileName, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < sales.Count; i++)
            {
                bw.Write(sales[i].bonNumber);
                bw.Write(sales[i].stock);
                bw.Write(sales[i].quantity);
                bw.Write(sales[i].price);
            }
            fs.Close();
        }
    }
}
