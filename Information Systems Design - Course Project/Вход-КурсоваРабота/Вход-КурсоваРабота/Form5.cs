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
using System.Windows.Forms.VisualStyles;

namespace Вход_КурсоваРабота
{
    public partial class Form5 : MetroFramework.Forms.MetroForm
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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


        private int GetSelectedClientID()
        {
            if (metroComboBox1.SelectedValue != null)
            {
                return (int)metroComboBox1.SelectedValue;
            }
            else
            {
                return -1; 
            }
        }

        private void поръчкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поръчкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoPartsDataSet1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int selectedClientID = GetSelectedClientID();  

            if (selectedClientID != -1)
            {
               
                Form8 orderForm = new Form8(selectedClientID); 
                orderForm.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Моля, изберете клиент.");
            }
        }
    }
}
