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
using System.Data;
using System.Data.SqlClient;

namespace Вход_КурсоваРабота
{
    public partial class Form8 : MetroFramework.Forms.MetroForm
    {
        private int currentCustomerID;
        public Form8(int clientID)
        {

            InitializeComponent();
            currentCustomerID = clientID;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0; 
            }
            
        }

       
        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Детайл_Поръчка' table. You can move, or remove it, as needed.
            this.детайл_ПоръчкаTableAdapter.Fill(this.autoPartsDataSet1.Детайл_Поръчка);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Поръчка' table. You can move, or remove it, as needed.
            this.поръчкаTableAdapter.Fill(this.autoPartsDataSet1.Поръчка);
            // TODO: This line of code loads data into the 'autoPartsDataSet1.Резервна_Част' table. You can move, or remove it, as needed.
            this.резервна_ЧастTableAdapter.Fill(this.autoPartsDataSet1.Резервна_Част);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                DataRowView selectedRow = (DataRowView)comboBox1.SelectedItem;

                decimal price = Convert.ToDecimal(selectedRow["Цена_Единица"]);

                label5.Text = price.ToString("C2"); 
            }
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            if (comboBox1.SelectedValue != null)
            {
                DataRowView selectedRow = (DataRowView)comboBox1.SelectedItem;
                decimal price = Convert.ToDecimal(selectedRow["Цена_Единица"]);
                int quantity = (int)numericUpDown1.Value;

                decimal totalPrice = price * quantity;
                label3.Text = "Обща цена: " + totalPrice.ToString("C2");
            }
        }

        private int GetNextOrderID()
        {
            int nextOrderID = 0;

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AutoParts;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT MAX(ID_Поръчка) FROM Поръчка";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        nextOrderID = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        nextOrderID = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Грешка при извличане на следващото ID: " + ex.Message);
                }
            }

            return nextOrderID;
        }

        private int GetNextOrderDetailsID()
        {
            int nextOrderDetailsID = 0;

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AutoParts;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            string query = "SELECT MAX(ID_Детайл) FROM Детайл_Поръчка";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        nextOrderDetailsID = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        nextOrderDetailsID = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Грешка при извличане на следващото ID: " + ex.Message);
                }
            }

            return nextOrderDetailsID;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null && numericUpDown1.Value > 0)
            {
                DataRow newOrderRow = autoPartsDataSet1.Поръчка.NewRow();
                newOrderRow["ID_Поръчка"] = GetNextOrderID();
                newOrderRow["Дата_Поръчка"] = DateTime.Now;
                newOrderRow["Статус"] = "Открита"; 
                newOrderRow["ID_Клиент"] = currentCustomerID;  

                autoPartsDataSet1.Поръчка.Rows.Add(newOrderRow);

                DataRowView selectedPart = (DataRowView)comboBox1.SelectedItem;
                int partId = (int)selectedPart["ID_Част"];
                decimal unitPrice = Convert.ToDecimal(selectedPart["Цена_Единица"]);
                int quantity = (int)numericUpDown1.Value;
                decimal totalPrice = unitPrice * quantity;

                DataRow newOrderDetailRow = autoPartsDataSet1.Детайл_Поръчка.NewRow();
                newOrderDetailRow["ID_Детайл"] = GetNextOrderDetailsID();
                newOrderDetailRow["ID_Поръчка"] = newOrderRow["ID_Поръчка"];  
                newOrderDetailRow["ID_Част"] = partId;
                newOrderDetailRow["Количество"] = quantity;
                newOrderDetailRow["Цена_Обща"] = totalPrice;

                autoPartsDataSet1.Детайл_Поръчка.Rows.Add(newOrderDetailRow);

                поръчкаTableAdapter.Update(autoPartsDataSet1.Поръчка); 
                детайл_ПоръчкаTableAdapter.Update(autoPartsDataSet1.Детайл_Поръчка); 

                MessageBox.Show("Поръчката беше добавена успешно!");
                this.Close();  
            }
            else
            {
                MessageBox.Show("Моля, изберете част и посочете количество.");
            }
        }
    }
}
