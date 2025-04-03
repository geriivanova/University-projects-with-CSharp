using iText.Kernel.Pdf;
using iText.Layout.Element;
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
using System.IO;
using iText.Layout;
using iText.Layout.Element;

namespace Вход_КурсоваРабота
{
    public partial class Form9 : MetroFramework.Forms.MetroForm
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void SearchDateInDataGridView(DateTime selectedDate)
        {
            bool dateFound = false;

            foreach (DataGridViewRow row in фактураMetroGrid.Rows)
            {
                if (row.Cells["dataGridViewTextBoxColumn2"].Value != null &&
                    DateTime.TryParse(row.Cells["dataGridViewTextBoxColumn2"].Value.ToString(), out DateTime rowDate))
                {
                    if (rowDate.Date == selectedDate.Date)
                    {
                        dateFound = true;
                        row.Selected = true; 
                        фактураMetroGrid.FirstDisplayedScrollingRowIndex = row.Index; 
                        break;
                    }
                }
            }

            if (!dateFound)
            {
                MessageBox.Show("Няма намерен запис с избраната дата.", "Резултат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Фактура' table. You can move, or remove it, as needed.
            this.фактураTableAdapter.Fill(this.autoPartsDataSet1.Фактура);

        }

        private void фактураBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.фактураBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoPartsDataSet1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            SearchDateInDataGridView(selectedDate);
        }
    }
}

