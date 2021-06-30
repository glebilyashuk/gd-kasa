namespace WindowsFormsApp1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.билетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.маршрутыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.поездаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.кондукторыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this._02_02_00_009_Baza_ruDataSet1 = new WindowsFormsApp1._02_02_00_009_Baza_ruDataSet();
			this._02_02_00_009_Baza_ruDataSet2 = new WindowsFormsApp1._02_02_00_009_Baza_ruDataSet();
			this.tableAdapterManager1 = new WindowsFormsApp1._02_02_00_009_Baza_ruDataSetTableAdapters.TableAdapterManager();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._02_02_00_009_Baza_ruDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._02_02_00_009_Baza_ruDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.билетыToolStripMenuItem,
            this.маршрутыToolStripMenuItem,
            this.поездаToolStripMenuItem,
            this.кондукторыToolStripMenuItem1});
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(76, 20);
			this.toolStripMenuItem2.Text = "Просмотр";
			// 
			// билетыToolStripMenuItem
			// 
			this.билетыToolStripMenuItem.Name = "билетыToolStripMenuItem";
			this.билетыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.билетыToolStripMenuItem.Text = "Билеты";
			this.билетыToolStripMenuItem.Click += new System.EventHandler(this.button4_Click);
			// 
			// маршрутыToolStripMenuItem
			// 
			this.маршрутыToolStripMenuItem.Name = "маршрутыToolStripMenuItem";
			this.маршрутыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.маршрутыToolStripMenuItem.Text = "Маршруты";
			this.маршрутыToolStripMenuItem.Click += new System.EventHandler(this.button5_Click);
			// 
			// поездаToolStripMenuItem
			// 
			this.поездаToolStripMenuItem.Name = "поездаToolStripMenuItem";
			this.поездаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.поездаToolStripMenuItem.Text = "Поезда";
			this.поездаToolStripMenuItem.Click += new System.EventHandler(this.button6_Click);
			// 
			// кондукторыToolStripMenuItem1
			// 
			this.кондукторыToolStripMenuItem1.Name = "кондукторыToolStripMenuItem1";
			this.кондукторыToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.кондукторыToolStripMenuItem1.Text = "Кондукторы";
			this.кондукторыToolStripMenuItem1.Click += new System.EventHandler(this.button7_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 27);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(570, 197);
			this.dataGridView1.TabIndex = 1;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(12, 243);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(570, 208);
			this.dataGridView2.TabIndex = 2;
			this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(588, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 132);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Фильтр";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 98);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(188, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Применить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 72);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(188, 20);
			this.textBox1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Маска";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "номер перевозки;",
            "номер маршрута;",
            "пункт назначения;",
            "пассажир;",
            "водитель."});
			this.comboBox1.Location = new System.Drawing.Point(6, 32);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(188, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Поле";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Location = new System.Drawing.Point(588, 165);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 81);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Перевозка";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(9, 48);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(185, 23);
			this.button3.TabIndex = 1;
			this.button3.Text = "Удалить";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(9, 19);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(185, 23);
			this.button2.TabIndex = 0;
			this.button2.Text = "Добавить…";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button7);
			this.groupBox3.Controls.Add(this.button6);
			this.groupBox3.Controls.Add(this.button5);
			this.groupBox3.Controls.Add(this.button4);
			this.groupBox3.Location = new System.Drawing.Point(588, 252);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 140);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Просмотр";
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(9, 106);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(185, 23);
			this.button7.TabIndex = 3;
			this.button7.Text = "Кондукторы";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(9, 77);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(185, 23);
			this.button6.TabIndex = 2;
			this.button6.Text = "Поезда";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(9, 48);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(185, 23);
			this.button5.TabIndex = 1;
			this.button5.Text = "Маршруты";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(9, 19);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(185, 23);
			this.button4.TabIndex = 0;
			this.button4.Text = "Билеты";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.button9);
			this.groupBox4.Controls.Add(this.button8);
			this.groupBox4.Location = new System.Drawing.Point(588, 398);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(200, 84);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Команды";
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(9, 46);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(185, 23);
			this.button9.TabIndex = 1;
			this.button9.Text = "Удалить";
			this.button9.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(9, 17);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(185, 23);
			this.button8.TabIndex = 0;
			this.button8.Text = "Добавить…";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// _02_02_00_009_Baza_ruDataSet1
			// 
			this._02_02_00_009_Baza_ruDataSet1.DataSetName = "_02_02_00_009_Baza_ruDataSet";
			this._02_02_00_009_Baza_ruDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// _02_02_00_009_Baza_ruDataSet2
			// 
			this._02_02_00_009_Baza_ruDataSet2.DataSetName = "_02_02_00_009_Baza_ruDataSet";
			this._02_02_00_009_Baza_ruDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tableAdapterManager1
			// 
			this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager1.Connection = null;
			this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1._02_02_00_009_Baza_ruDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager1.АвтобусTableAdapter = null;
			this.tableAdapterManager1.БилетTableAdapter = null;
			this.tableAdapterManager1.ВодительTableAdapter = null;
			this.tableAdapterManager1.ДиспетчерTableAdapter = null;
			this.tableAdapterManager1.МаршрутTableAdapter = null;
			this.tableAdapterManager1.ПеревозкаTableAdapter = null;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(800, 495);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.удалитьToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
			this.toolStripMenuItem1.Text = "Перевозка";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem3.Text = "Добавить...";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.button2_Click);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(800, 494);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Касса ЖД";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._02_02_00_009_Baza_ruDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._02_02_00_009_Baza_ruDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem билетыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem маршрутыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem поездаToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private _02_02_00_009_Baza_ruDataSet _02_02_00_009_Baza_ruDataSet1;
		private _02_02_00_009_Baza_ruDataSet _02_02_00_009_Baza_ruDataSet2;
		private _02_02_00_009_Baza_ruDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
		private System.Windows.Forms.ToolStripMenuItem кондукторыToolStripMenuItem1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
	}
}

