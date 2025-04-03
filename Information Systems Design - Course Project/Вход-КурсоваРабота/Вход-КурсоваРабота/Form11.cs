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
    public partial class Form11 : MetroFramework.Forms.MetroForm
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Доставчик' table. You can move, or remove it, as needed.
            this.доставчикTableAdapter.Fill(this.autoPartsDataSet1.Доставчик);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Производител' table. You can move, or remove it, as needed.
            this.производителTableAdapter.Fill(this.autoPartsDataSet1.Производител);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Модел' table. You can move, or remove it, as needed.
            this.моделTableAdapter.Fill(this.autoPartsDataSet1.Модел);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Детайл_Поръчка' table. You can move, or remove it, as needed.
            this.детайл_ПоръчкаTableAdapter.Fill(this.autoPartsDataSet1.Детайл_Поръчка);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Категория' table. You can move, or remove it, as needed.
            this.категорияTableAdapter.Fill(this.autoPartsDataSet1.Категория);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Резервна_Част' table. You can move, or remove it, as needed.
            this.резервна_ЧастTableAdapter.Fill(this.autoPartsDataSet1.Резервна_Част);

        }

        private void резервна_ЧастBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.резервна_ЧастBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoPartsDataSet1);

        }
    }
}
