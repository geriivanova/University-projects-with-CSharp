using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Вход_КурсоваРабота.AutoPartsDataSet1TableAdapters;
using iText.Kernel.Pdf;
using iText.Kernel.Font;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.IO;
using iText.IO.Font.Constants;
using IronPdf;

namespace Вход_КурсоваРабота
{
    public partial class Form14 : MetroFramework.Forms.MetroForm
    {
        private object моделТableAdapter;

        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Модел' table. You can move, or remove it, as needed.
            this.моделTableAdapter.Fill(this.autoPartsDataSet1.Модел);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Резервна_Част' table. You can move, or remove it, as needed.
            this.резервна_ЧастTableAdapter.Fill(this.autoPartsDataSet1.Резервна_Част);

        }

        private void резервна_ЧастBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.резервна_ЧастBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoPartsDataSet1);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           резервна_ЧастBindingSource.Filter = string.Format("Име LIKE '{0}%'", textBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedValue != null)
            {
                int selectedModelId = (int)metroComboBox1.SelectedValue;
                this.резервна_ЧастTableAdapter.FillByModelId(this.autoPartsDataSet1.Резервна_Част, selectedModelId);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (.pdf)|.pdf";
                saveFileDialog.Title = "Запази като PDF";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    ExportWithIronPDF(filePath);  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Възникна грешка: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportWithIronPDF(string filePath)
        {
            try
            {
                var Renderer = new HtmlToPdf();

                string htmlContent = "<html><body><table border='1'>";

                htmlContent += "<h1 style='text-align:center;'>Справка</h1>"; 

                htmlContent += "<tr>";
                foreach (DataGridViewColumn column in резервна_ЧастMetroGrid.Columns)
                {
                    htmlContent += "<th>" + column.HeaderText + "</th>";
                }
                htmlContent += "</tr>";

                foreach (DataGridViewRow row in резервна_ЧастMetroGrid.Rows)
                {
                    if (row.IsNewRow) continue; 
                    htmlContent += "<tr>";
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        htmlContent += "<td>" + (cell.Value?.ToString() ?? "") + "</td>";
                    }
                    htmlContent += "</tr>";
                }

                htmlContent += "</table></body></html>";

                var pdfDocument = Renderer.RenderHtmlAsPdf(htmlContent);

                pdfDocument.SaveAs(filePath);

                MessageBox.Show("PDF файлът е създаден успешно с таблица!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Възникна грешка при създаването на PDF файла:\n" + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
