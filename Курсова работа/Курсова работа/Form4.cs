using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            gl.AddToDataGridView(TB1.Text, TB2.Text, Convert.ToInt32(TB3.Text), Convert.ToDouble(TB4.Text), Convert.ToInt32(TB3.Text) * Convert.ToDouble(TB4.Text));
            //Sale st = new Sale();
            //st.bonNumber = TB1.Text;
            //st.stock = TB2.Text;
            //st.quantity = Convert.ToInt32(TB3.Text);
            //st.price= Convert.ToDouble(TB4.Text);
            //gl.sales.Add(st);
            Close();
        }
    }
}
