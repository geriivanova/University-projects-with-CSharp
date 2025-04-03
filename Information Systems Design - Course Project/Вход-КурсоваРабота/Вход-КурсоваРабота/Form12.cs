using MetroFramework.Controls;
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
    public partial class Form12 : MetroFramework.Forms.MetroForm
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Производител' table. You can move, or remove it, as needed.
            this.производителTableAdapter.Fill(this.autoPartsDataSet1.Производител);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Модел' table. You can move, or remove it, as needed.
            this.моделTableAdapter.Fill(this.autoPartsDataSet1.Модел);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Категория' table. You can move, or remove it, as needed.
            this.категорияTableAdapter.Fill(this.autoPartsDataSet1.Категория);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Резервна_Част' table. You can move, or remove it, as needed.
            this.резервна_ЧастTableAdapter.Fill(this.autoPartsDataSet1.Резервна_Част);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Доставчик' table. You can move, or remove it, as needed.
            this.доставчикTableAdapter.Fill(this.autoPartsDataSet1.Доставчик);

        }

        private void доставчикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.доставчикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoPartsDataSet1);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            доставчикBindingSource.Filter = string.Format("Име LIKE '{0}%'", textBox1.Text);
        }

       
    }
}
