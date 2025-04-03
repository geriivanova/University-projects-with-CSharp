using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Вход_КурсоваРабота
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form7().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form9().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form10().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form11().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form12().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form13().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Form14().ShowDialog();
        }
    }
}
