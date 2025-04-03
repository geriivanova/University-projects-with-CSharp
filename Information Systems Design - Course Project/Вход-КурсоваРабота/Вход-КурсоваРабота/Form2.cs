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
    public partial class Form2 : MetroFramework.Forms.MetroForm

    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form5().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form6().ShowDialog();
        }


        public static string CFilter { get; set; }
    }
}
