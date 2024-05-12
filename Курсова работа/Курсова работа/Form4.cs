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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсова_работа
{
    public partial class Form4 : Form
    {
        Form1 gl;
        public Form4(Form1 gl)
        {
            InitializeComponent();
            this.gl = gl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bonNumber = TB1.Text;
            string stock = TB2.Text;
            int.TryParse(TB3.Text, out int quantity);
            double.TryParse(TB4.Text, out double price);
            gl.AddToDataGridView(bonNumber, stock, quantity,price, quantity * price);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
