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
    public partial class Form6 : MetroFramework.Forms.MetroForm
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Експ_Бележка' table. You can move, or remove it, as needed.
            this.експ_БележкаTableAdapter.Fill(this.autoPartsDataSet1.Експ_Бележка);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Куриер' table. You can move, or remove it, as needed.
            this.куриерTableAdapter.Fill(this.autoPartsDataSet1.Куриер);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Куриер' table. You can move, or remove it, as needed.
            this.куриерTableAdapter.Fill(this.autoPartsDataSet1.Куриер);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Експ_Бележка' table. You can move, or remove it, as needed.
            this.експ_БележкаTableAdapter.Fill(this.autoPartsDataSet1.Експ_Бележка);

        }

        private void експ_БележкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.експ_БележкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoPartsDataSet1);

        }

        private void куриерBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.куриерBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoPartsDataSet1);

        }
    }
}
