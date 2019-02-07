namespace KP_Delivery3
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.database1DataSet = new KP_Delivery3.Database1DataSet();
			this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.deliveryTableAdapter = new KP_Delivery3.Database1DataSetTableAdapters.DeliveryTableAdapter();
			this.tableAdapterManager = new KP_Delivery3.Database1DataSetTableAdapters.TableAdapterManager();
			this.orderTableAdapter = new KP_Delivery3.Database1DataSetTableAdapters.OrderTableAdapter();
			this.prodTableAdapter = new KP_Delivery3.Database1DataSetTableAdapters.ProdTableAdapter();
			this.userTableAdapter = new KP_Delivery3.Database1DataSetTableAdapters.UserTableAdapter();
			this.deliveryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.deliveryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.prodBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.button6 = new System.Windows.Forms.Button();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label27 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.button9 = new System.Windows.Forms.Button();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.comboBox7 = new System.Windows.Forms.ComboBox();
			this.label22 = new System.Windows.Forms.Label();
			this.comboBox8 = new System.Windows.Forms.ComboBox();
			this.label30 = new System.Windows.Forms.Label();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.label20 = new System.Windows.Forms.Label();
			this.comboBox6 = new System.Windows.Forms.ComboBox();
			this.label23 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.label29 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label21 = new System.Windows.Forms.Label();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.textBox21 = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.textBox22 = new System.Windows.Forms.TextBox();
			this.button12 = new System.Windows.Forms.Button();
			this.listBox4 = new System.Windows.Forms.ListBox();
			this.deliveryTableAdapter1 = new KP_Delivery3.Database1DataSetTableAdapters.DeliveryTableAdapter();
			this.listBox5 = new System.Windows.Forms.ListBox();
			this.button13 = new System.Windows.Forms.Button();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deliveryBindingNavigator)).BeginInit();
			this.deliveryBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prodBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// database1DataSet
			// 
			this.database1DataSet.DataSetName = "Database1DataSet";
			this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// deliveryBindingSource
			// 
			this.deliveryBindingSource.DataMember = "Delivery";
			this.deliveryBindingSource.DataSource = this.database1DataSet;
			// 
			// deliveryTableAdapter
			// 
			this.deliveryTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.DeliveryTableAdapter = this.deliveryTableAdapter;
			this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
			this.tableAdapterManager.ProdTableAdapter = this.prodTableAdapter;
			this.tableAdapterManager.UpdateOrder = KP_Delivery3.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
			// 
			// orderTableAdapter
			// 
			this.orderTableAdapter.ClearBeforeFill = true;
			// 
			// prodTableAdapter
			// 
			this.prodTableAdapter.ClearBeforeFill = true;
			// 
			// userTableAdapter
			// 
			this.userTableAdapter.ClearBeforeFill = true;
			// 
			// deliveryBindingNavigator
			// 
			this.deliveryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.deliveryBindingNavigator.BindingSource = this.deliveryBindingSource;
			this.deliveryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.deliveryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.deliveryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.deliveryBindingNavigatorSaveItem,
            this.toolStripButton1});
			this.deliveryBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.deliveryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.deliveryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.deliveryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.deliveryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.deliveryBindingNavigator.Name = "deliveryBindingNavigator";
			this.deliveryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.deliveryBindingNavigator.Size = new System.Drawing.Size(663, 25);
			this.deliveryBindingNavigator.TabIndex = 0;
			this.deliveryBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Добавить";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
			this.bindingNavigatorCountItem.Text = "для {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Удалить";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Положение";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// deliveryBindingNavigatorSaveItem
			// 
			this.deliveryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.deliveryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("deliveryBindingNavigatorSaveItem.Image")));
			this.deliveryBindingNavigatorSaveItem.Name = "deliveryBindingNavigatorSaveItem";
			this.deliveryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.deliveryBindingNavigatorSaveItem.Text = "Сохранить данные";
			this.deliveryBindingNavigatorSaveItem.Click += new System.EventHandler(this.deliveryBindingNavigatorSaveItem_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// orderBindingSource
			// 
			this.orderBindingSource.DataMember = "Order";
			this.orderBindingSource.DataSource = this.database1DataSet;
			// 
			// prodBindingSource
			// 
			this.prodBindingSource.DataMember = "Prod";
			this.prodBindingSource.DataSource = this.database1DataSet;
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataMember = "User";
			this.userBindingSource.DataSource = this.database1DataSet;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 25);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(663, 329);
			this.tabControl1.TabIndex = 5;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.textBox4);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.textBox3);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.textBox2);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.listBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(655, 303);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "User";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(526, 168);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 17;
			this.button3.Text = "Удалить";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(403, 170);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 16;
			this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(400, 153);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(18, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "ID";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(322, 167);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 14;
			this.button2.Text = "Изменить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(199, 208);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(196, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Имя";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(199, 169);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 11;
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(196, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(18, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(9, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "label2";
			this.label2.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 153);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Имя";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 169);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(118, 166);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(12, 6);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(261, 108);
			this.listBox1.TabIndex = 5;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button13);
			this.tabPage2.Controls.Add(this.textBox12);
			this.tabPage2.Controls.Add(this.label31);
			this.tabPage2.Controls.Add(this.listBox5);
			this.tabPage2.Controls.Add(this.textBox10);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.textBox9);
			this.tabPage2.Controls.Add(this.button4);
			this.tabPage2.Controls.Add(this.textBox5);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.button5);
			this.tabPage2.Controls.Add(this.textBox6);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.textBox7);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.textBox8);
			this.tabPage2.Controls.Add(this.button6);
			this.tabPage2.Controls.Add(this.listBox2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(655, 303);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Prod";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(220, 241);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(100, 20);
			this.textBox10.TabIndex = 34;
			this.textBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(217, 225);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(82, 13);
			this.label12.TabIndex = 33;
			this.label12.Text = "Цена продукта";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(30, 186);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(82, 13);
			this.label11.TabIndex = 32;
			this.label11.Text = "Цена продукта";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(33, 202);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(100, 20);
			this.textBox9.TabIndex = 31;
			this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(547, 162);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 30;
			this.button4.Text = "Удалить";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(424, 164);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 29;
			this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(421, 147);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(18, 13);
			this.label6.TabIndex = 28;
			this.label6.Text = "ID";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(343, 161);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 27;
			this.button5.Text = "Изменить";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(220, 202);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 20);
			this.textBox6.TabIndex = 26;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(217, 186);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 13);
			this.label7.TabIndex = 25;
			this.label7.Text = "Имя продукта";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(220, 163);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(100, 20);
			this.textBox7.TabIndex = 24;
			this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(217, 147);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(18, 13);
			this.label8.TabIndex = 23;
			this.label8.Text = "ID";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.Color.Red;
			this.label9.Location = new System.Drawing.Point(31, 120);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 13);
			this.label9.TabIndex = 22;
			this.label9.Text = "label9";
			this.label9.Visible = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(30, 147);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(78, 13);
			this.label10.TabIndex = 21;
			this.label10.Text = "Имя продукта";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(33, 163);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(100, 20);
			this.textBox8.TabIndex = 20;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(139, 160);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 19;
			this.button6.Text = "Добавить";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(8, 6);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(261, 108);
			this.listBox2.TabIndex = 18;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.comboBox2);
			this.tabPage3.Controls.Add(this.dateTimePicker2);
			this.tabPage3.Controls.Add(this.label13);
			this.tabPage3.Controls.Add(this.label16);
			this.tabPage3.Controls.Add(this.label28);
			this.tabPage3.Controls.Add(this.textBox11);
			this.tabPage3.Controls.Add(this.comboBox1);
			this.tabPage3.Controls.Add(this.dateTimePicker1);
			this.tabPage3.Controls.Add(this.label27);
			this.tabPage3.Controls.Add(this.label14);
			this.tabPage3.Controls.Add(this.button7);
			this.tabPage3.Controls.Add(this.textBox13);
			this.tabPage3.Controls.Add(this.label15);
			this.tabPage3.Controls.Add(this.button8);
			this.tabPage3.Controls.Add(this.textBox15);
			this.tabPage3.Controls.Add(this.label17);
			this.tabPage3.Controls.Add(this.label18);
			this.tabPage3.Controls.Add(this.label19);
			this.tabPage3.Controls.Add(this.textBox16);
			this.tabPage3.Controls.Add(this.button9);
			this.tabPage3.Controls.Add(this.listBox3);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(655, 303);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Delivery";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(215, 281);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 60;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(214, 242);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(149, 20);
			this.dateTimePicker2.TabIndex = 59;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(212, 265);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(85, 13);
			this.label13.TabIndex = 58;
			this.label13.Text = "Имя заказчика";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(211, 226);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(72, 13);
			this.label16.TabIndex = 57;
			this.label16.Text = "Дата заказа";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(211, 187);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(77, 13);
			this.label28.TabIndex = 56;
			this.label28.Text = "Адрес заказа";
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(214, 203);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(100, 20);
			this.textBox11.TabIndex = 55;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(29, 258);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 54;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(28, 219);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
			this.dateTimePicker1.TabIndex = 53;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(26, 242);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(85, 13);
			this.label27.TabIndex = 52;
			this.label27.Text = "Имя заказчика";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(25, 203);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(72, 13);
			this.label14.TabIndex = 49;
			this.label14.Text = "Дата заказа";
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(542, 179);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 47;
			this.button7.Text = "Удалить";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(419, 181);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(100, 20);
			this.textBox13.TabIndex = 46;
			this.textBox13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(416, 164);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(18, 13);
			this.label15.TabIndex = 45;
			this.label15.Text = "ID";
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(337, 155);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 44;
			this.button8.Text = "Изменить";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// textBox15
			// 
			this.textBox15.Location = new System.Drawing.Point(214, 157);
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new System.Drawing.Size(100, 20);
			this.textBox15.TabIndex = 41;
			this.textBox15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(211, 141);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(18, 13);
			this.label17.TabIndex = 40;
			this.label17.Text = "ID";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.ForeColor = System.Drawing.Color.Red;
			this.label18.Location = new System.Drawing.Point(26, 137);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(41, 13);
			this.label18.TabIndex = 39;
			this.label18.Text = "label18";
			this.label18.Visible = false;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(25, 164);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(77, 13);
			this.label19.TabIndex = 38;
			this.label19.Text = "Адрес заказа";
			// 
			// textBox16
			// 
			this.textBox16.Location = new System.Drawing.Point(28, 180);
			this.textBox16.Name = "textBox16";
			this.textBox16.Size = new System.Drawing.Size(100, 20);
			this.textBox16.TabIndex = 37;
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(134, 177);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(75, 23);
			this.button9.TabIndex = 36;
			this.button9.Text = "Добавить";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// listBox3
			// 
			this.listBox3.FormattingEnabled = true;
			this.listBox3.Location = new System.Drawing.Point(6, 6);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(600, 121);
			this.listBox3.TabIndex = 35;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.comboBox7);
			this.tabPage4.Controls.Add(this.label22);
			this.tabPage4.Controls.Add(this.comboBox8);
			this.tabPage4.Controls.Add(this.label30);
			this.tabPage4.Controls.Add(this.comboBox5);
			this.tabPage4.Controls.Add(this.label20);
			this.tabPage4.Controls.Add(this.comboBox6);
			this.tabPage4.Controls.Add(this.label23);
			this.tabPage4.Controls.Add(this.comboBox4);
			this.tabPage4.Controls.Add(this.label29);
			this.tabPage4.Controls.Add(this.comboBox3);
			this.tabPage4.Controls.Add(this.label21);
			this.tabPage4.Controls.Add(this.button10);
			this.tabPage4.Controls.Add(this.button11);
			this.tabPage4.Controls.Add(this.textBox21);
			this.tabPage4.Controls.Add(this.label24);
			this.tabPage4.Controls.Add(this.label25);
			this.tabPage4.Controls.Add(this.label26);
			this.tabPage4.Controls.Add(this.textBox22);
			this.tabPage4.Controls.Add(this.button12);
			this.tabPage4.Controls.Add(this.listBox4);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(655, 303);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Order";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// comboBox7
			// 
			this.comboBox7.FormattingEnabled = true;
			this.comboBox7.Location = new System.Drawing.Point(430, 195);
			this.comboBox7.Name = "comboBox7";
			this.comboBox7.Size = new System.Drawing.Size(121, 21);
			this.comboBox7.TabIndex = 66;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(427, 218);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(80, 13);
			this.label22.TabIndex = 65;
			this.label22.Text = "Номер заказа";
			// 
			// comboBox8
			// 
			this.comboBox8.FormattingEnabled = true;
			this.comboBox8.Location = new System.Drawing.Point(430, 234);
			this.comboBox8.Name = "comboBox8";
			this.comboBox8.Size = new System.Drawing.Size(121, 21);
			this.comboBox8.TabIndex = 64;
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(427, 179);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(49, 13);
			this.label30.TabIndex = 63;
			this.label30.Text = "Продукт";
			// 
			// comboBox5
			// 
			this.comboBox5.FormattingEnabled = true;
			this.comboBox5.Location = new System.Drawing.Point(215, 219);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(121, 21);
			this.comboBox5.TabIndex = 62;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(212, 242);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(80, 13);
			this.label20.TabIndex = 61;
			this.label20.Text = "Номер заказа";
			// 
			// comboBox6
			// 
			this.comboBox6.FormattingEnabled = true;
			this.comboBox6.Location = new System.Drawing.Point(215, 258);
			this.comboBox6.Name = "comboBox6";
			this.comboBox6.Size = new System.Drawing.Size(121, 21);
			this.comboBox6.TabIndex = 60;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(212, 203);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(49, 13);
			this.label23.TabIndex = 59;
			this.label23.Text = "Продукт";
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(20, 258);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(121, 21);
			this.comboBox4.TabIndex = 58;
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(17, 242);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(80, 13);
			this.label29.TabIndex = 57;
			this.label29.Text = "Номер заказа";
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(20, 219);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 21);
			this.comboBox3.TabIndex = 56;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(17, 203);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(49, 13);
			this.label21.TabIndex = 55;
			this.label21.Text = "Продукт";
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(557, 177);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(75, 23);
			this.button10.TabIndex = 47;
			this.button10.Text = "Удалить";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(338, 178);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(75, 23);
			this.button11.TabIndex = 44;
			this.button11.Text = "Изменить";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// textBox21
			// 
			this.textBox21.Location = new System.Drawing.Point(215, 180);
			this.textBox21.Name = "textBox21";
			this.textBox21.Size = new System.Drawing.Size(100, 20);
			this.textBox21.TabIndex = 41;
			this.textBox21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(212, 164);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(18, 13);
			this.label24.TabIndex = 40;
			this.label24.Text = "ID";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.ForeColor = System.Drawing.Color.Red;
			this.label25.Location = new System.Drawing.Point(26, 137);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(41, 13);
			this.label25.TabIndex = 39;
			this.label25.Text = "label25";
			this.label25.Visible = false;
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(17, 166);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(115, 13);
			this.label26.TabIndex = 38;
			this.label26.Text = "Количество продукта";
			// 
			// textBox22
			// 
			this.textBox22.Location = new System.Drawing.Point(20, 182);
			this.textBox22.Name = "textBox22";
			this.textBox22.Size = new System.Drawing.Size(100, 20);
			this.textBox22.TabIndex = 37;
			this.textBox22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(126, 179);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(75, 23);
			this.button12.TabIndex = 36;
			this.button12.Text = "Добавить";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// listBox4
			// 
			this.listBox4.FormattingEnabled = true;
			this.listBox4.Location = new System.Drawing.Point(3, 6);
			this.listBox4.Name = "listBox4";
			this.listBox4.Size = new System.Drawing.Size(261, 121);
			this.listBox4.TabIndex = 35;
			// 
			// deliveryTableAdapter1
			// 
			this.deliveryTableAdapter1.ClearBeforeFill = true;
			// 
			// listBox5
			// 
			this.listBox5.FormattingEnabled = true;
			this.listBox5.Location = new System.Drawing.Point(343, 7);
			this.listBox5.Name = "listBox5";
			this.listBox5.Size = new System.Drawing.Size(279, 108);
			this.listBox5.TabIndex = 35;
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(547, 200);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(75, 23);
			this.button13.TabIndex = 38;
			this.button13.Text = "Вернуть";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.button13_Click);
			// 
			// textBox12
			// 
			this.textBox12.Location = new System.Drawing.Point(424, 202);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(100, 20);
			this.textBox12.TabIndex = 37;
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(421, 185);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(18, 13);
			this.label31.TabIndex = 36;
			this.label31.Text = "ID";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(663, 354);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.deliveryBindingNavigator);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deliveryBindingNavigator)).EndInit();
			this.deliveryBindingNavigator.ResumeLayout(false);
			this.deliveryBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prodBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Database1DataSet database1DataSet;
		private System.Windows.Forms.BindingSource deliveryBindingSource;
		private Database1DataSetTableAdapters.DeliveryTableAdapter deliveryTableAdapter;
		private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator deliveryBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton deliveryBindingNavigatorSaveItem;
		private Database1DataSetTableAdapters.OrderTableAdapter orderTableAdapter;
		private System.Windows.Forms.BindingSource orderBindingSource;
		private Database1DataSetTableAdapters.ProdTableAdapter prodTableAdapter;
		private System.Windows.Forms.BindingSource prodBindingSource;
		private Database1DataSetTableAdapters.UserTableAdapter userTableAdapter;
		private System.Windows.Forms.BindingSource userBindingSource;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.TextBox textBox21;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox textBox22;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.ListBox listBox4;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox textBox11;
		private Database1DataSetTableAdapters.DeliveryTableAdapter deliveryTableAdapter1;
		private System.Windows.Forms.ComboBox comboBox5;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.ComboBox comboBox6;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.ComboBox comboBox7;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.ComboBox comboBox8;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.ListBox listBox5;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.Label label31;
	}
}

