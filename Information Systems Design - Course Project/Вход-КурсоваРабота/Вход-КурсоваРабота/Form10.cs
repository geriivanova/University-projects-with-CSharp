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
    public partial class Form10 : MetroFramework.Forms.MetroForm
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Резервна_Част' table. You can move, or remove it, as needed.
            this.резервна_ЧастTableAdapter.Fill(this.autoPartsDataSet1.Резервна_Част);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Клиент' table. You can move, or remove it, as needed.
            this.клиентTableAdapter.Fill(this.autoPartsDataSet1.Клиент);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Детайл_Поръчка' table. You can move, or remove it, as needed.
            this.детайл_ПоръчкаTableAdapter.Fill(this.autoPartsDataSet1.Детайл_Поръчка);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Поръчка' table. You can move, or remove it, as needed.
            this.поръчкаTableAdapter.Fill(this.autoPartsDataSet1.Поръчка);

        }

        private void поръчкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поръчкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoPartsDataSet1);

        }
    }
}
