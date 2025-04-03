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
    public partial class Form13 : MetroFramework.Forms.MetroForm
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Експ_Бележка' table. You can move, or remove it, as needed.
            this.експ_БележкаTableAdapter.Fill(this.autoPartsDataSet1.Експ_Бележка);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Куриер' table. You can move, or remove it, as needed.
            this.куриерTableAdapter.Fill(this.autoPartsDataSet1.Куриер);

        }

        private void куриерBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.куриерBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoPartsDataSet1);

        }

        
    }
}
