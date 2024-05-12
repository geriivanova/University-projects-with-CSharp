using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсова_работа
{
    public partial class Form3 : Form
    {
        Form1 gl;
        public Form3(Form1 gl)
        {
            InitializeComponent();
            this.gl = gl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            double.TryParse(textBox1.Text, out double price);

            for (int i = 0; i < gl.sales.Count; i++)
            {
                if (Convert.ToDouble(price) > gl.sales[i].price)
                {
                    dataGridView1.Rows.Add(gl.sales[i].bonNumber, gl.sales[i].stock, gl.sales[i].quantity, gl.sales[i].price);
                    dataGridView1.Show();
                }
            }

            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
