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
    public partial class Form7 : MetroFramework.Forms.MetroForm
    {
        public Form7()
        {
            InitializeComponent();

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Тип_Клиент' table. You can move, or remove it, as needed.
            this.тип_КлиентTableAdapter.Fill(this.autoPartsDataSet1.Тип_Клиент);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Клиент' table. You can move, or remove it, as needed.
            this.клиентTableAdapter.Fill(this.autoPartsDataSet1.Клиент);

        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoPartsDataSet1);

        }

        private void metroTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            клиентBindingSource.Filter = string.Format("Име LIKE '{0}%'", metroTextBox1.Text);
        }

       
    }
}
