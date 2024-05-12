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
    public partial class Form2 : Form
    {
        Form1 gl;
        public Form2(Form1 gl)
        {
            InitializeComponent();
            this.gl = gl;
        }

        private void FindMinMaxQuantityProducts()
        {
            if (gl.sales.Any())
            {
                var maxQuantitySale = gl.sales.OrderByDescending(s => s.quantity).FirstOrDefault();
                var minQuantitySale = gl.sales.OrderBy(s => s.quantity).FirstOrDefault();
                listBox1.Items.Clear();
                listBox1.Items.Add($"Най-голямо количество продажби: {maxQuantitySale.stock} {maxQuantitySale.quantity}");
                listBox1.Items.Add($"Най-малко количество продажби: {minQuantitySale.stock} {minQuantitySale.quantity}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindMinMaxQuantityProducts();
        }
    }
}
