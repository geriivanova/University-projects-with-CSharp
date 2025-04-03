namespace Вход_КурсоваРабота
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            System.Windows.Forms.Label iD_КуриерLabel;
            System.Windows.Forms.Label имеLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.autoPartsDataSet1 = new Вход_КурсоваРабота.AutoPartsDataSet1();
            this.куриерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.куриерTableAdapter = new Вход_КурсоваРабота.AutoPartsDataSet1TableAdapters.КуриерTableAdapter();
            this.tableAdapterManager = new Вход_КурсоваРабота.AutoPartsDataSet1TableAdapters.TableAdapterManager();
            this.куриерBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.куриерBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_КуриерTextBox = new System.Windows.Forms.TextBox();
            this.имеTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.експ_БележкаTableAdapter = new Вход_КурсоваРабота.AutoPartsDataSet1TableAdapters.Експ_БележкаTableAdapter();
            this.експ_БележкаMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.експ_БележкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iD_КуриерLabel = new System.Windows.Forms.Label();
            имеLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.куриерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.куриерBindingNavigator)).BeginInit();
            this.куриерBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.експ_БележкаMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.експ_БележкаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // autoPartsDataSet1
            // 
            this.autoPartsDataSet1.DataSetName = "AutoPartsDataSet1";
            this.autoPartsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // куриерBindingSource
            // 
            this.куриерBindingSource.DataMember = "Куриер";
            this.куриерBindingSource.DataSource = this.autoPartsDataSet1;
            // 
            // куриерTableAdapter
            // 
            this.куриерTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Вход_КурсоваРабота.AutoPartsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Детайл_ПоръчкаTableAdapter = null;
            this.tableAdapterManager.ДоставчикTableAdapter = null;
            this.tableAdapterManager.Експ_БележкаTableAdapter = this.експ_БележкаTableAdapter;
            this.tableAdapterManager.КатегорияTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.КуриерTableAdapter = this.куриерTableAdapter;
            this.tableAdapterManager.МоделTableAdapter = null;
            this.tableAdapterManager.ПоръчкаTableAdapter = null;
            this.tableAdapterManager.ПроизводителTableAdapter = null;
            this.tableAdapterManager.Резервна_ЧастTableAdapter = null;
            this.tableAdapterManager.Тип_КлиентTableAdapter = null;
            this.tableAdapterManager.ФактураTableAdapter = null;
            // 
            // куриерBindingNavigator
            // 
            this.куриерBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.куриерBindingNavigator.BindingSource = this.куриерBindingSource;
            this.куриерBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.куриерBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.куриерBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.куриерBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.куриерBindingNavigatorSaveItem});
            this.куриерBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.куриерBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.куриерBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.куриерBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.куриерBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.куриерBindingNavigator.Name = "куриерBindingNavigator";
            this.куриерBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.куриерBindingNavigator.Size = new System.Drawing.Size(869, 27);
            this.куриерBindingNavigator.TabIndex = 0;
            this.куриерBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // куриерBindingNavigatorSaveItem
            // 
            this.куриерBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.куриерBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("куриерBindingNavigatorSaveItem.Image")));
            this.куриерBindingNavigatorSaveItem.Name = "куриерBindingNavigatorSaveItem";
            this.куриерBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.куриерBindingNavigatorSaveItem.Text = "Save Data";
            this.куриерBindingNavigatorSaveItem.Click += new System.EventHandler(this.куриерBindingNavigatorSaveItem_Click);
            // 
            // iD_КуриерLabel
            // 
            iD_КуриерLabel.AutoSize = true;
            iD_КуриерLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_КуриерLabel.Location = new System.Drawing.Point(238, 139);
            iD_КуриерLabel.Name = "iD_КуриерLabel";
            iD_КуриерLabel.Size = new System.Drawing.Size(148, 20);
            iD_КуриерLabel.TabIndex = 1;
            iD_КуриерLabel.Text = "Код на куриер:";
            // 
            // iD_КуриерTextBox
            // 
            this.iD_КуриерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.куриерBindingSource, "ID_Куриер", true));
            this.iD_КуриерTextBox.Location = new System.Drawing.Point(417, 137);
            this.iD_КуриерTextBox.Name = "iD_КуриерTextBox";
            this.iD_КуриерTextBox.ReadOnly = true;
            this.iD_КуриерTextBox.Size = new System.Drawing.Size(213, 22);
            this.iD_КуриерTextBox.TabIndex = 2;
            // 
            // имеLabel
            // 
            имеLabel.AutoSize = true;
            имеLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            имеLabel.Location = new System.Drawing.Point(238, 179);
            имеLabel.Name = "имеLabel";
            имеLabel.Size = new System.Drawing.Size(51, 20);
            имеLabel.TabIndex = 3;
            имеLabel.Text = "Име:";
            // 
            // имеTextBox
            // 
            this.имеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.куриерBindingSource, "Име", true));
            this.имеTextBox.Location = new System.Drawing.Point(417, 177);
            this.имеTextBox.Name = "имеTextBox";
            this.имеTextBox.Size = new System.Drawing.Size(213, 22);
            this.имеTextBox.TabIndex = 4;
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефонLabel.Location = new System.Drawing.Point(239, 221);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(98, 20);
            телефонLabel.TabIndex = 5;
            телефонLabel.Text = "Телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.куриерBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(417, 218);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(213, 22);
            this.телефонTextBox.TabIndex = 6;
            // 
            // експ_БележкаTableAdapter
            // 
            this.експ_БележкаTableAdapter.ClearBeforeFill = true;
            // 
            // експ_БележкаMetroGrid
            // 
            this.експ_БележкаMetroGrid.AllowUserToResizeRows = false;
            this.експ_БележкаMetroGrid.AutoGenerateColumns = false;
            this.експ_БележкаMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.експ_БележкаMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.експ_БележкаMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.експ_БележкаMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.експ_БележкаMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.експ_БележкаMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.експ_БележкаMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.експ_БележкаMetroGrid.DataSource = this.експ_БележкаBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.експ_БележкаMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.експ_БележкаMetroGrid.EnableHeadersVisualStyles = false;
            this.експ_БележкаMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.експ_БележкаMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.експ_БележкаMetroGrid.Location = new System.Drawing.Point(67, 281);
            this.експ_БележкаMetroGrid.Name = "експ_БележкаMetroGrid";
            this.експ_БележкаMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.експ_БележкаMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.експ_БележкаMetroGrid.RowHeadersWidth = 51;
            this.експ_БележкаMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.експ_БележкаMetroGrid.RowTemplate.Height = 24;
            this.експ_БележкаMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.експ_БележкаMetroGrid.Size = new System.Drawing.Size(718, 198);
            this.експ_БележкаMetroGrid.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Бележка";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код на бележка";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Фактура";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код на фактура";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата_Бележка";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата на бележка";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_Куриер";
            this.dataGridViewTextBoxColumn4.HeaderText = "Код на куриер";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // експ_БележкаBindingSource
            // 
            this.експ_БележкаBindingSource.DataMember = "FK__Експ_Беле__ID_Ку__3B75D760";
            this.експ_БележкаBindingSource.DataSource = this.куриерBindingSource;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 535);
            this.Controls.Add(this.експ_БележкаMetroGrid);
            this.Controls.Add(iD_КуриерLabel);
            this.Controls.Add(this.iD_КуриерTextBox);
            this.Controls.Add(имеLabel);
            this.Controls.Add(this.имеTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(this.куриерBindingNavigator);
            this.Name = "Form6";
            this.Text = "Експедиционни бележки";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.куриерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.куриерBindingNavigator)).EndInit();
            this.куриерBindingNavigator.ResumeLayout(false);
            this.куриерBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.експ_БележкаMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.експ_БележкаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoPartsDataSet1 autoPartsDataSet1;
        private System.Windows.Forms.BindingSource куриерBindingSource;
        private AutoPartsDataSet1TableAdapters.КуриерTableAdapter куриерTableAdapter;
        private AutoPartsDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator куриерBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton куриерBindingNavigatorSaveItem;
        private AutoPartsDataSet1TableAdapters.Експ_БележкаTableAdapter експ_БележкаTableAdapter;
        private System.Windows.Forms.TextBox iD_КуриерTextBox;
        private System.Windows.Forms.TextBox имеTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.BindingSource експ_БележкаBindingSource;
        private MetroFramework.Controls.MetroGrid експ_БележкаMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}