namespace Вход_КурсоваРабота
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.autoPartsDataSet1 = new Вход_КурсоваРабота.AutoPartsDataSet1();
            this.резервнаЧастBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.резервна_ЧастTableAdapter = new Вход_КурсоваРабота.AutoPartsDataSet1TableAdapters.Резервна_ЧастTableAdapter();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.поръчкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поръчкаTableAdapter = new Вход_КурсоваРабота.AutoPartsDataSet1TableAdapters.ПоръчкаTableAdapter();
            this.tableAdapterManager = new Вход_КурсоваРабота.AutoPartsDataSet1TableAdapters.TableAdapterManager();
            this.детайл_ПоръчкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.детайл_ПоръчкаTableAdapter = new Вход_КурсоваРабота.AutoPartsDataSet1TableAdapters.Детайл_ПоръчкаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.резервнаЧастBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поръчкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.детайл_ПоръчкаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.резервнаЧастBindingSource;
            this.comboBox1.DisplayMember = "Име";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(390, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID_Част";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(142, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Избери резервна част:";
            // 
            // autoPartsDataSet1
            // 
            this.autoPartsDataSet1.DataSetName = "AutoPartsDataSet1";
            this.autoPartsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // резервнаЧастBindingSource
            // 
            this.резервнаЧастBindingSource.DataMember = "Резервна_Част";
            this.резервнаЧастBindingSource.DataSource = this.autoPartsDataSet1;
            // 
            // резервна_ЧастTableAdapter
            // 
            this.резервна_ЧастTableAdapter.ClearBeforeFill = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(390, 206);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(158, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(142, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(331, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Обща цена: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(142, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Единична цена: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(292, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Направи поръчка";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // поръчкаBindingSource
            // 
            this.поръчкаBindingSource.DataMember = "Поръчка";
            this.поръчкаBindingSource.DataSource = this.autoPartsDataSet1;
            // 
            // поръчкаTableAdapter
            // 
            this.поръчкаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Вход_КурсоваРабота.AutoPartsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Детайл_ПоръчкаTableAdapter = this.детайл_ПоръчкаTableAdapter;
            this.tableAdapterManager.ДоставчикTableAdapter = null;
            this.tableAdapterManager.Експ_БележкаTableAdapter = null;
            this.tableAdapterManager.КатегорияTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.КуриерTableAdapter = null;
            this.tableAdapterManager.МоделTableAdapter = null;
            this.tableAdapterManager.ПоръчкаTableAdapter = this.поръчкаTableAdapter;
            this.tableAdapterManager.ПроизводителTableAdapter = null;
            this.tableAdapterManager.Резервна_ЧастTableAdapter = this.резервна_ЧастTableAdapter;
            this.tableAdapterManager.Тип_КлиентTableAdapter = null;
            this.tableAdapterManager.ФактураTableAdapter = null;
            // 
            // детайл_ПоръчкаBindingSource
            // 
            this.детайл_ПоръчкаBindingSource.DataMember = "FK__Детайл_По__ID_По__398D8EEE";
            this.детайл_ПоръчкаBindingSource.DataSource = this.поръчкаBindingSource;
            // 
            // детайл_ПоръчкаTableAdapter
            // 
            this.детайл_ПоръчкаTableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form8";
            this.Text = "Направи поръчка";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.резервнаЧастBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поръчкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.детайл_ПоръчкаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private AutoPartsDataSet1 autoPartsDataSet1;
        private System.Windows.Forms.BindingSource резервнаЧастBindingSource;
        private AutoPartsDataSet1TableAdapters.Резервна_ЧастTableAdapter резервна_ЧастTableAdapter;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource поръчкаBindingSource;
        private AutoPartsDataSet1TableAdapters.ПоръчкаTableAdapter поръчкаTableAdapter;
        private AutoPartsDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private AutoPartsDataSet1TableAdapters.Детайл_ПоръчкаTableAdapter детайл_ПоръчкаTableAdapter;
        private System.Windows.Forms.BindingSource детайл_ПоръчкаBindingSource;
    }
}