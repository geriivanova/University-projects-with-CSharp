namespace Вход_КурсоваРабота
{
    partial class Form10
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
            System.Windows.Forms.Label iD_ПоръчкаLabel;
            System.Windows.Forms.Label дата_ПоръчкаLabel;
            System.Windows.Forms.Label статусLabel;
            System.Windows.Forms.Label iD_КлиентLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.autoPartsDataSet1 = new Вход_КурсоваРабота.AutoPartsDataSet1();
            this.поръчкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поръчкаTableAdapter = new Вход_КурсоваРабота.AutoPartsDataSet1TableAdapters.ПоръчкаTableAdapter();
            this.tableAdapterManager = new Вход_КурсоваРабота.AutoPartsDataSet1TableAdapters.TableAdapterManager();
            this.детайл_ПоръчкаTableAdapter = new Вход_КурсоваРабота.AutoPartsDataSet1TableAdapters.Детайл_ПоръчкаTableAdapter();
            this.клиентTableAdapter = new Вход_КурсоваРабота.AutoPartsDataSet1TableAdapters.КлиентTableAdapter();
            this.резервна_ЧастTableAdapter = new Вход_КурсоваРабота.AutoPartsDataSet1TableAdapters.Резервна_ЧастTableAdapter();
            this.поръчкаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.поръчкаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ПоръчкаTextBox = new System.Windows.Forms.TextBox();
            this.дата_ПоръчкаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.статусTextBox = new System.Windows.Forms.TextBox();
            this.детайл_ПоръчкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.детайл_ПоръчкаMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.резервнаЧастBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iD_ПоръчкаLabel = new System.Windows.Forms.Label();
            дата_ПоръчкаLabel = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            iD_КлиентLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поръчкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поръчкаBindingNavigator)).BeginInit();
            this.поръчкаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.детайл_ПоръчкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.детайл_ПоръчкаMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.резервнаЧастBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_ПоръчкаLabel
            // 
            iD_ПоръчкаLabel.AutoSize = true;
            iD_ПоръчкаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_ПоръчкаLabel.Location = new System.Drawing.Point(283, 141);
            iD_ПоръчкаLabel.Name = "iD_ПоръчкаLabel";
            iD_ПоръчкаLabel.Size = new System.Drawing.Size(162, 20);
            iD_ПоръчкаLabel.TabIndex = 1;
            iD_ПоръчкаLabel.Text = "Код на поръчка:";
            // 
            // дата_ПоръчкаLabel
            // 
            дата_ПоръчкаLabel.AutoSize = true;
            дата_ПоръчкаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_ПоръчкаLabel.Location = new System.Drawing.Point(283, 172);
            дата_ПоръчкаLabel.Name = "дата_ПоръчкаLabel";
            дата_ПоръчкаLabel.Size = new System.Drawing.Size(148, 20);
            дата_ПоръчкаLabel.TabIndex = 3;
            дата_ПоръчкаLabel.Text = "Дата Поръчка:";
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            статусLabel.Location = new System.Drawing.Point(283, 201);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(80, 20);
            статусLabel.TabIndex = 5;
            статусLabel.Text = "Статус:";
            // 
            // iD_КлиентLabel
            // 
            iD_КлиентLabel.AutoSize = true;
            iD_КлиентLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_КлиентLabel.Location = new System.Drawing.Point(283, 231);
            iD_КлиентLabel.Name = "iD_КлиентLabel";
            iD_КлиентLabel.Size = new System.Drawing.Size(150, 20);
            iD_КлиентLabel.TabIndex = 7;
            iD_КлиентLabel.Text = "Име на клиент:";
            // 
            // autoPartsDataSet1
            // 
            this.autoPartsDataSet1.DataSetName = "AutoPartsDataSet1";
            this.autoPartsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.КлиентTableAdapter = this.клиентTableAdapter;
            this.tableAdapterManager.КуриерTableAdapter = null;
            this.tableAdapterManager.МоделTableAdapter = null;
            this.tableAdapterManager.ПоръчкаTableAdapter = this.поръчкаTableAdapter;
            this.tableAdapterManager.ПроизводителTableAdapter = null;
            this.tableAdapterManager.Резервна_ЧастTableAdapter = this.резервна_ЧастTableAdapter;
            this.tableAdapterManager.Тип_КлиентTableAdapter = null;
            this.tableAdapterManager.ФактураTableAdapter = null;
            // 
            // детайл_ПоръчкаTableAdapter
            // 
            this.детайл_ПоръчкаTableAdapter.ClearBeforeFill = true;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // резервна_ЧастTableAdapter
            // 
            this.резервна_ЧастTableAdapter.ClearBeforeFill = true;
            // 
            // поръчкаBindingNavigator
            // 
            this.поръчкаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.поръчкаBindingNavigator.BindingSource = this.поръчкаBindingSource;
            this.поръчкаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.поръчкаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.поръчкаBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.поръчкаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.поръчкаBindingNavigatorSaveItem});
            this.поръчкаBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.поръчкаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.поръчкаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.поръчкаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.поръчкаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.поръчкаBindingNavigator.Name = "поръчкаBindingNavigator";
            this.поръчкаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.поръчкаBindingNavigator.Size = new System.Drawing.Size(982, 31);
            this.поръчкаBindingNavigator.TabIndex = 0;
            this.поръчкаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // поръчкаBindingNavigatorSaveItem
            // 
            this.поръчкаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.поръчкаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("поръчкаBindingNavigatorSaveItem.Image")));
            this.поръчкаBindingNavigatorSaveItem.Name = "поръчкаBindingNavigatorSaveItem";
            this.поръчкаBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.поръчкаBindingNavigatorSaveItem.Text = "Save Data";
            this.поръчкаBindingNavigatorSaveItem.Click += new System.EventHandler(this.поръчкаBindingNavigatorSaveItem_Click);
            // 
            // iD_ПоръчкаTextBox
            // 
            this.iD_ПоръчкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поръчкаBindingSource, "ID_Поръчка", true));
            this.iD_ПоръчкаTextBox.Location = new System.Drawing.Point(460, 139);
            this.iD_ПоръчкаTextBox.Name = "iD_ПоръчкаTextBox";
            this.iD_ПоръчкаTextBox.ReadOnly = true;
            this.iD_ПоръчкаTextBox.Size = new System.Drawing.Size(200, 22);
            this.iD_ПоръчкаTextBox.TabIndex = 2;
            // 
            // дата_ПоръчкаDateTimePicker
            // 
            this.дата_ПоръчкаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.поръчкаBindingSource, "Дата_Поръчка", true));
            this.дата_ПоръчкаDateTimePicker.Location = new System.Drawing.Point(460, 170);
            this.дата_ПоръчкаDateTimePicker.Name = "дата_ПоръчкаDateTimePicker";
            this.дата_ПоръчкаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_ПоръчкаDateTimePicker.TabIndex = 4;
            // 
            // статусTextBox
            // 
            this.статусTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поръчкаBindingSource, "Статус", true));
            this.статусTextBox.Location = new System.Drawing.Point(460, 199);
            this.статусTextBox.Name = "статусTextBox";
            this.статусTextBox.Size = new System.Drawing.Size(200, 22);
            this.статусTextBox.TabIndex = 6;
            // 
            // детайл_ПоръчкаBindingSource
            // 
            this.детайл_ПоръчкаBindingSource.DataMember = "FK__Детайл_По__ID_По__398D8EEE";
            this.детайл_ПоръчкаBindingSource.DataSource = this.поръчкаBindingSource;
            // 
            // детайл_ПоръчкаMetroGrid
            // 
            this.детайл_ПоръчкаMetroGrid.AllowUserToResizeRows = false;
            this.детайл_ПоръчкаMetroGrid.AutoGenerateColumns = false;
            this.детайл_ПоръчкаMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.детайл_ПоръчкаMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.детайл_ПоръчкаMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.детайл_ПоръчкаMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.детайл_ПоръчкаMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.детайл_ПоръчкаMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.детайл_ПоръчкаMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.детайл_ПоръчкаMetroGrid.DataSource = this.детайл_ПоръчкаBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.детайл_ПоръчкаMetroGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.детайл_ПоръчкаMetroGrid.EnableHeadersVisualStyles = false;
            this.детайл_ПоръчкаMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.детайл_ПоръчкаMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.детайл_ПоръчкаMetroGrid.Location = new System.Drawing.Point(58, 297);
            this.детайл_ПоръчкаMetroGrid.Name = "детайл_ПоръчкаMetroGrid";
            this.детайл_ПоръчкаMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.детайл_ПоръчкаMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.детайл_ПоръчкаMetroGrid.RowHeadersWidth = 51;
            this.детайл_ПоръчкаMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.детайл_ПоръчкаMetroGrid.RowTemplate.Height = 24;
            this.детайл_ПоръчкаMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.детайл_ПоръчкаMetroGrid.Size = new System.Drawing.Size(870, 220);
            this.детайл_ПоръчкаMetroGrid.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Поръчка";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер на поръчка";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Част";
            this.dataGridViewTextBoxColumn3.DataSource = this.резервнаЧастBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Име";
            this.dataGridViewTextBoxColumn3.HeaderText = "Част";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID_Част";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // резервнаЧастBindingSource
            // 
            this.резервнаЧастBindingSource.DataMember = "Резервна_Част";
            this.резервнаЧастBindingSource.DataSource = this.autoPartsDataSet1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Количество";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Цена_Обща";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "#.## лв";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn5.HeaderText = "Обща цена";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.клиентBindingSource;
            this.comboBox1.DisplayMember = "Име";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(460, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "ID_Клиент";
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.autoPartsDataSet1;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 554);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.детайл_ПоръчкаMetroGrid);
            this.Controls.Add(iD_ПоръчкаLabel);
            this.Controls.Add(this.iD_ПоръчкаTextBox);
            this.Controls.Add(дата_ПоръчкаLabel);
            this.Controls.Add(this.дата_ПоръчкаDateTimePicker);
            this.Controls.Add(статусLabel);
            this.Controls.Add(this.статусTextBox);
            this.Controls.Add(iD_КлиентLabel);
            this.Controls.Add(this.поръчкаBindingNavigator);
            this.Name = "Form10";
            this.Text = "Поръчки";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поръчкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поръчкаBindingNavigator)).EndInit();
            this.поръчкаBindingNavigator.ResumeLayout(false);
            this.поръчкаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.детайл_ПоръчкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.детайл_ПоръчкаMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.резервнаЧастBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoPartsDataSet1 autoPartsDataSet1;
        private System.Windows.Forms.BindingSource поръчкаBindingSource;
        private AutoPartsDataSet1TableAdapters.ПоръчкаTableAdapter поръчкаTableAdapter;
        private AutoPartsDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator поръчкаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton поръчкаBindingNavigatorSaveItem;
        private AutoPartsDataSet1TableAdapters.Детайл_ПоръчкаTableAdapter детайл_ПоръчкаTableAdapter;
        private System.Windows.Forms.TextBox iD_ПоръчкаTextBox;
        private System.Windows.Forms.DateTimePicker дата_ПоръчкаDateTimePicker;
        private System.Windows.Forms.TextBox статусTextBox;
        private System.Windows.Forms.BindingSource детайл_ПоръчкаBindingSource;
        private MetroFramework.Controls.MetroGrid детайл_ПоръчкаMetroGrid;
        private System.Windows.Forms.ComboBox comboBox1;
        private AutoPartsDataSet1TableAdapters.КлиентTableAdapter клиентTableAdapter;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private AutoPartsDataSet1TableAdapters.Резервна_ЧастTableAdapter резервна_ЧастTableAdapter;
        private System.Windows.Forms.BindingSource резервнаЧастBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}