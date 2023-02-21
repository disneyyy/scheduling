namespace scheduling
{
    partial class Form_method
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.label_class = new System.Windows.Forms.Label();
            this.comboBox_yo = new System.Windows.Forms.ComboBox();
            this.method有機BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasks_databaseDataSet7 = new scheduling.tasks_databaseDataSet7();
            this.label_name2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_wu = new System.Windows.Forms.RadioButton();
            this.radioButton_yo = new System.Windows.Forms.RadioButton();
            this.method有機TableAdapter1 = new scheduling.tasks_databaseDataSet6TableAdapters.Method有機TableAdapter();
            this.method有機TableAdapter = new scheduling.tasks_databaseDataSet7TableAdapters.Method有機TableAdapter();
            this.comboBox_wu = new System.Windows.Forms.ComboBox();
            this.method無機BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasks_databaseDataSet8 = new scheduling.tasks_databaseDataSet8();
            this.method無機TableAdapter = new scheduling.tasks_databaseDataSet8TableAdapters.Method無機TableAdapter();
            this.method有機BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tasks_databaseDataSet13 = new scheduling.tasks_databaseDataSet13();
            this.method無機BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tasks_databaseDataSet14 = new scheduling.tasks_databaseDataSet14();
            this.button2 = new System.Windows.Forms.Button();
            this.label_method = new System.Windows.Forms.Label();
            this.button_add_me = new System.Windows.Forms.Button();
            this.button_delete_me = new System.Windows.Forms.Button();
            this.button_ready = new System.Windows.Forms.Button();
            this.comboBox_me_wu = new System.Windows.Forms.ComboBox();
            this.comboBox_me_yo = new System.Windows.Forms.ComboBox();
            this.tasks_databaseDataSet10 = new scheduling.tasks_databaseDataSet10();
            this.method無機BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.method無機TableAdapter1 = new scheduling.tasks_databaseDataSet10TableAdapters.Method無機TableAdapter();
            this.method有機BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tasks_databaseDataSet11 = new scheduling.tasks_databaseDataSet11();
            this.method有機TableAdapter2 = new scheduling.tasks_databaseDataSet11TableAdapters.Method有機TableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_wu = new System.Windows.Forms.Label();
            this.label_yo = new System.Windows.Forms.Label();
            this.method有機TableAdapter3 = new scheduling.tasks_databaseDataSet13TableAdapters.Method有機TableAdapter();
            this.method無機TableAdapter2 = new scheduling.tasks_databaseDataSet14TableAdapters.Method無機TableAdapter();
            this.button_not_ready = new System.Windows.Forms.Button();
            this.label_me = new System.Windows.Forms.Label();
            this.label_getname_wu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_getname_yo = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.method有機BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet7)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.method無機BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.method有機BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.method無機BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.method無機BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.method有機BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(59, 52);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 25);
            this.textBox_name.TabIndex = 0;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 55);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(37, 15);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "姓名";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(176, 52);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "新增員工";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_class
            // 
            this.label_class.AutoSize = true;
            this.label_class.Location = new System.Drawing.Point(12, 26);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(37, 15);
            this.label_class.TabIndex = 1;
            this.label_class.Text = "課別";
            // 
            // comboBox_yo
            // 
            this.comboBox_yo.DataSource = this.method有機BindingSource;
            this.comboBox_yo.DisplayMember = "授權人員";
            this.comboBox_yo.FormattingEnabled = true;
            this.comboBox_yo.Location = new System.Drawing.Point(59, 136);
            this.comboBox_yo.Name = "comboBox_yo";
            this.comboBox_yo.Size = new System.Drawing.Size(121, 23);
            this.comboBox_yo.TabIndex = 4;
            // 
            // method有機BindingSource
            // 
            this.method有機BindingSource.DataMember = "Method有機";
            this.method有機BindingSource.DataSource = this.tasks_databaseDataSet7;
            // 
            // tasks_databaseDataSet7
            // 
            this.tasks_databaseDataSet7.DataSetName = "tasks_databaseDataSet7";
            this.tasks_databaseDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_name2
            // 
            this.label_name2.AutoSize = true;
            this.label_name2.Location = new System.Drawing.Point(12, 139);
            this.label_name2.Name = "label_name2";
            this.label_name2.Size = new System.Drawing.Size(37, 15);
            this.label_name2.TabIndex = 1;
            this.label_name2.Text = "姓名";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_wu);
            this.groupBox1.Controls.Add(this.radioButton_yo);
            this.groupBox1.Location = new System.Drawing.Point(59, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 37);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // radioButton_wu
            // 
            this.radioButton_wu.AutoSize = true;
            this.radioButton_wu.Location = new System.Drawing.Point(88, 12);
            this.radioButton_wu.Name = "radioButton_wu";
            this.radioButton_wu.Size = new System.Drawing.Size(58, 19);
            this.radioButton_wu.TabIndex = 1;
            this.radioButton_wu.TabStop = true;
            this.radioButton_wu.Text = "無機";
            this.radioButton_wu.UseVisualStyleBackColor = true;
            this.radioButton_wu.CheckedChanged += new System.EventHandler(this.checkBox_wu_CheckedChanged);
            // 
            // radioButton_yo
            // 
            this.radioButton_yo.AutoSize = true;
            this.radioButton_yo.Checked = true;
            this.radioButton_yo.Location = new System.Drawing.Point(7, 13);
            this.radioButton_yo.Name = "radioButton_yo";
            this.radioButton_yo.Size = new System.Drawing.Size(58, 19);
            this.radioButton_yo.TabIndex = 0;
            this.radioButton_yo.TabStop = true;
            this.radioButton_yo.Text = "有機";
            this.radioButton_yo.UseVisualStyleBackColor = true;
            this.radioButton_yo.CheckedChanged += new System.EventHandler(this.checkBox_yo_CheckStateChanged);
            // 
            // method有機TableAdapter1
            // 
            this.method有機TableAdapter1.ClearBeforeFill = true;
            // 
            // method有機TableAdapter
            // 
            this.method有機TableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_wu
            // 
            this.comboBox_wu.DataSource = this.method無機BindingSource;
            this.comboBox_wu.DisplayMember = "授權人員";
            this.comboBox_wu.FormattingEnabled = true;
            this.comboBox_wu.Location = new System.Drawing.Point(59, 136);
            this.comboBox_wu.Name = "comboBox_wu";
            this.comboBox_wu.Size = new System.Drawing.Size(121, 23);
            this.comboBox_wu.TabIndex = 6;
            this.comboBox_wu.Visible = false;
            // 
            // method無機BindingSource
            // 
            this.method無機BindingSource.DataMember = "Method無機";
            this.method無機BindingSource.DataSource = this.tasks_databaseDataSet8;
            // 
            // tasks_databaseDataSet8
            // 
            this.tasks_databaseDataSet8.DataSetName = "tasks_databaseDataSet8";
            this.tasks_databaseDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // method無機TableAdapter
            // 
            this.method無機TableAdapter.ClearBeforeFill = true;
            // 
            // method有機BindingSource2
            // 
            this.method有機BindingSource2.DataMember = "Method有機";
            this.method有機BindingSource2.DataSource = this.tasks_databaseDataSet13;
            // 
            // tasks_databaseDataSet13
            // 
            this.tasks_databaseDataSet13.DataSetName = "tasks_databaseDataSet13";
            this.tasks_databaseDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // method無機BindingSource2
            // 
            this.method無機BindingSource2.DataMember = "Method無機";
            this.method無機BindingSource2.DataSource = this.tasks_databaseDataSet14;
            // 
            // tasks_databaseDataSet14
            // 
            this.tasks_databaseDataSet14.DataSetName = "tasks_databaseDataSet14";
            this.tasks_databaseDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "delete_all";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_method
            // 
            this.label_method.AutoSize = true;
            this.label_method.Location = new System.Drawing.Point(12, 167);
            this.label_method.Name = "label_method";
            this.label_method.Size = new System.Drawing.Size(67, 15);
            this.label_method.TabIndex = 9;
            this.label_method.Text = "分析方法";
            // 
            // button_add_me
            // 
            this.button_add_me.Location = new System.Drawing.Point(186, 135);
            this.button_add_me.Name = "button_add_me";
            this.button_add_me.Size = new System.Drawing.Size(75, 23);
            this.button_add_me.TabIndex = 11;
            this.button_add_me.Text = "新增方法";
            this.button_add_me.UseVisualStyleBackColor = true;
            this.button_add_me.Click += new System.EventHandler(this.button_add_me_Click);
            // 
            // button_delete_me
            // 
            this.button_delete_me.Location = new System.Drawing.Point(186, 164);
            this.button_delete_me.Name = "button_delete_me";
            this.button_delete_me.Size = new System.Drawing.Size(75, 23);
            this.button_delete_me.TabIndex = 11;
            this.button_delete_me.Text = "刪除方法";
            this.button_delete_me.UseVisualStyleBackColor = true;
            this.button_delete_me.Click += new System.EventHandler(this.button_delete_me_Click);
            // 
            // button_ready
            // 
            this.button_ready.Location = new System.Drawing.Point(309, 135);
            this.button_ready.Name = "button_ready";
            this.button_ready.Size = new System.Drawing.Size(75, 23);
            this.button_ready.TabIndex = 13;
            this.button_ready.Text = "就緒";
            this.button_ready.UseVisualStyleBackColor = true;
            this.button_ready.Click += new System.EventHandler(this.button_ready_Click_1);
            // 
            // comboBox_me_wu
            // 
            this.comboBox_me_wu.FormattingEnabled = true;
            this.comboBox_me_wu.Items.AddRange(new object[] {
            "W201",
            "W203",
            "W208",
            "W210",
            "W223",
            "W311",
            "W320",
            "W330",
            "W406",
            "W408",
            "W410",
            "W413",
            "W418",
            "W419",
            "W422",
            "W424",
            "W427",
            "W430",
            "W433",
            "W434",
            "W436",
            "W437",
            "W448",
            "W449",
            "W451",
            "W455",
            "W464",
            "W506",
            "W510",
            "W515",
            "W516",
            "W517",
            "W521",
            "W525",
            "S280",
            "S310",
            "S321",
            "S322",
            "S410",
            "CNS 3916",
            "CNS 5090 A3089",
            "R201",
            "R203",
            "R205",
            "R208",
            "R210",
            "R212",
            "R306",
            "R309",
            "R314",
            "M317",
            "M353",
            "A102",
            "A205",
            "A208",
            "A216",
            "A306"});
            this.comboBox_me_wu.Location = new System.Drawing.Point(82, 164);
            this.comboBox_me_wu.Name = "comboBox_me_wu";
            this.comboBox_me_wu.Size = new System.Drawing.Size(98, 23);
            this.comboBox_me_wu.TabIndex = 10;
            this.comboBox_me_wu.Visible = false;
            // 
            // comboBox_me_yo
            // 
            this.comboBox_me_yo.FormattingEnabled = true;
            this.comboBox_me_yo.Items.AddRange(new object[] {
            "A705",
            "S280",
            "S703",
            "M711",
            "M731",
            "W219",
            "W532",
            "W785",
            "W801",
            "W901",
            "E202",
            "E204",
            "E230",
            "E237",
            "E301",
            "E401",
            "R703"});
            this.comboBox_me_yo.Location = new System.Drawing.Point(82, 164);
            this.comboBox_me_yo.Name = "comboBox_me_yo";
            this.comboBox_me_yo.Size = new System.Drawing.Size(98, 23);
            this.comboBox_me_yo.TabIndex = 14;
            // 
            // tasks_databaseDataSet10
            // 
            this.tasks_databaseDataSet10.DataSetName = "tasks_databaseDataSet10";
            this.tasks_databaseDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // method無機BindingSource1
            // 
            this.method無機BindingSource1.DataMember = "Method無機";
            this.method無機BindingSource1.DataSource = this.tasks_databaseDataSet10;
            // 
            // method無機TableAdapter1
            // 
            this.method無機TableAdapter1.ClearBeforeFill = true;
            // 
            // method有機BindingSource1
            // 
            this.method有機BindingSource1.DataMember = "Method有機";
            this.method有機BindingSource1.DataSource = this.tasks_databaseDataSet11;
            // 
            // tasks_databaseDataSet11
            // 
            this.tasks_databaseDataSet11.DataSetName = "tasks_databaseDataSet11";
            this.tasks_databaseDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // method有機TableAdapter2
            // 
            this.method有機TableAdapter2.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(383, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 16;
            // 
            // label_wu
            // 
            this.label_wu.AutoSize = true;
            this.label_wu.Location = new System.Drawing.Point(380, 300);
            this.label_wu.Name = "label_wu";
            this.label_wu.Size = new System.Drawing.Size(41, 15);
            this.label_wu.TabIndex = 17;
            this.label_wu.Text = "label1";
            // 
            // label_yo
            // 
            this.label_yo.AutoSize = true;
            this.label_yo.Location = new System.Drawing.Point(380, 330);
            this.label_yo.Name = "label_yo";
            this.label_yo.Size = new System.Drawing.Size(41, 15);
            this.label_yo.TabIndex = 17;
            this.label_yo.Text = "label1";
            // 
            // method有機TableAdapter3
            // 
            this.method有機TableAdapter3.ClearBeforeFill = true;
            // 
            // method無機TableAdapter2
            // 
            this.method無機TableAdapter2.ClearBeforeFill = true;
            // 
            // button_not_ready
            // 
            this.button_not_ready.Location = new System.Drawing.Point(309, 163);
            this.button_not_ready.Name = "button_not_ready";
            this.button_not_ready.Size = new System.Drawing.Size(75, 23);
            this.button_not_ready.TabIndex = 13;
            this.button_not_ready.Text = "未就緒";
            this.button_not_ready.UseVisualStyleBackColor = true;
            this.button_not_ready.Click += new System.EventHandler(this.button_not_ready_Click_1);
            // 
            // label_me
            // 
            this.label_me.AutoSize = true;
            this.label_me.Location = new System.Drawing.Point(315, 274);
            this.label_me.Name = "label_me";
            this.label_me.Size = new System.Drawing.Size(41, 15);
            this.label_me.TabIndex = 18;
            this.label_me.Text = "label1";
            // 
            // label_getname_wu
            // 
            this.label_getname_wu.AutoSize = true;
            this.label_getname_wu.Location = new System.Drawing.Point(220, 330);
            this.label_getname_wu.Name = "label_getname_wu";
            this.label_getname_wu.Size = new System.Drawing.Size(41, 15);
            this.label_getname_wu.TabIndex = 18;
            this.label_getname_wu.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "強制更改數量";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label_getname_yo
            // 
            this.label_getname_yo.AutoSize = true;
            this.label_getname_yo.Location = new System.Drawing.Point(220, 348);
            this.label_getname_yo.Name = "label_getname_yo";
            this.label_getname_yo.Size = new System.Drawing.Size(41, 15);
            this.label_getname_yo.TabIndex = 18;
            this.label_getname_yo.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(699, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "reset_time";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(404, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(370, 151);
            this.dataGridView1.TabIndex = 20;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 208);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(753, 230);
            this.dataGridView2.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(56, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 21;
            // 
            // Form_method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label_getname_yo);
            this.Controls.Add(this.label_getname_wu);
            this.Controls.Add(this.label_me);
            this.Controls.Add(this.label_yo);
            this.Controls.Add(this.label_wu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox_me_yo);
            this.Controls.Add(this.button_not_ready);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_ready);
            this.Controls.Add(this.button_delete_me);
            this.Controls.Add(this.button_add_me);
            this.Controls.Add(this.comboBox_me_wu);
            this.Controls.Add(this.label_method);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox_yo);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_class);
            this.Controls.Add(this.label_name2);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.comboBox_wu);
            this.Name = "Form_method";
            this.Text = "Form_method";
            this.Load += new System.EventHandler(this.Form_method_Load);
            ((System.ComponentModel.ISupportInitialize)(this.method有機BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.method無機BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.method有機BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.method無機BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.method無機BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.method有機BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_class;
        private System.Windows.Forms.ComboBox comboBox_yo;
        private System.Windows.Forms.Label label_name2;
        private System.Windows.Forms.GroupBox groupBox1;
        private tasks_databaseDataSet6TableAdapters.Method有機TableAdapter method有機TableAdapter1;
        private tasks_databaseDataSet7 tasks_databaseDataSet7;
        private System.Windows.Forms.BindingSource method有機BindingSource;
        private tasks_databaseDataSet7TableAdapters.Method有機TableAdapter method有機TableAdapter;
        private System.Windows.Forms.ComboBox comboBox_wu;
        private tasks_databaseDataSet8 tasks_databaseDataSet8;
        private System.Windows.Forms.BindingSource method無機BindingSource;
        private tasks_databaseDataSet8TableAdapters.Method無機TableAdapter method無機TableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_method;
        private System.Windows.Forms.Button button_add_me;
        private System.Windows.Forms.Button button_delete_me;
        private System.Windows.Forms.Button button_ready;
        private System.Windows.Forms.ComboBox comboBox_me_wu;
        private System.Windows.Forms.ComboBox comboBox_me_yo;
        private tasks_databaseDataSet10 tasks_databaseDataSet10;
        private System.Windows.Forms.BindingSource method無機BindingSource1;
        private tasks_databaseDataSet10TableAdapters.Method無機TableAdapter method無機TableAdapter1;
        private tasks_databaseDataSet11 tasks_databaseDataSet11;
        private System.Windows.Forms.BindingSource method有機BindingSource1;
        private tasks_databaseDataSet11TableAdapters.Method有機TableAdapter method有機TableAdapter2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_wu;
        private System.Windows.Forms.Label label_yo;
        private tasks_databaseDataSet13 tasks_databaseDataSet13;
        private System.Windows.Forms.BindingSource method有機BindingSource2;
        private tasks_databaseDataSet13TableAdapters.Method有機TableAdapter method有機TableAdapter3;
        private tasks_databaseDataSet14 tasks_databaseDataSet14;
        private System.Windows.Forms.BindingSource method無機BindingSource2;
        private tasks_databaseDataSet14TableAdapters.Method無機TableAdapter method無機TableAdapter2;
        private System.Windows.Forms.Button button_not_ready;
        private System.Windows.Forms.Label label_me;
        private System.Windows.Forms.Label label_getname_wu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_getname_yo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton_wu;
        private System.Windows.Forms.RadioButton radioButton_yo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}