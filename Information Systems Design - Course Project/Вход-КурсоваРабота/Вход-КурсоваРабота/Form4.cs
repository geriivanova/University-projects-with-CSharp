using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Configuration;

namespace Вход_КурсоваРабота
{
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate(); 
                this.клиентBindingSource.EndEdit(); 
                this.tableAdapterManager.UpdateAll(this.autoPartsDataSet1); 

                MessageBox.Show("Данните са запазени успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Възникна грешка при запазването: {ex.Message}");
            }
        }
    }
}
