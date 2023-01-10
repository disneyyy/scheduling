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
            this.checkBox_wu = new System.Windows.Forms.CheckBox();
            this.checkBox_yo = new System.Windows.Forms.CheckBox();
            this.method有機TableAdapter1 = new scheduling.tasks_databaseDataSet6TableAdapters.Method有機TableAdapter();
            this.method有機TableAdapter = new scheduling.tasks_databaseDataSet7TableAdapters.Method有機TableAdapter();
            this.comboBox_wu = new System.Windows.Forms.ComboBox();
            this.method無機BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasks_databaseDataSet8 = new scheduling.tasks_databaseDataSet8();
            this.method無機TableAdapter = new scheduling.tasks_databaseDataSet8TableAdapters.Method無機TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.授權人員DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.授權人員DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label_method = new System.Windows.Forms.Label();
            this.comboBox_me = new System.Windows.Forms.ComboBox();
            this.button_add_me = new System.Windows.Forms.Button();
            this.button_delete_me = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.授權人員DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.method有機BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet7)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.method無機BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.groupBox1.Controls.Add(this.checkBox_wu);
            this.groupBox1.Controls.Add(this.checkBox_yo);
            this.groupBox1.Location = new System.Drawing.Point(59, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 37);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // checkBox_wu
            // 
            this.checkBox_wu.AutoSize = true;
            this.checkBox_wu.Location = new System.Drawing.Point(85, 18);
            this.checkBox_wu.Name = "checkBox_wu";
            this.checkBox_wu.Size = new System.Drawing.Size(59, 19);
            this.checkBox_wu.TabIndex = 6;
            this.checkBox_wu.Text = "無機";
            this.checkBox_wu.UseVisualStyleBackColor = true;
            this.checkBox_wu.CheckedChanged += new System.EventHandler(this.checkBox_wu_CheckedChanged);
            // 
            // checkBox_yo
            // 
            this.checkBox_yo.AutoSize = true;
            this.checkBox_yo.Checked = true;
            this.checkBox_yo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_yo.Location = new System.Drawing.Point(6, 18);
            this.checkBox_yo.Name = "checkBox_yo";
            this.checkBox_yo.Size = new System.Drawing.Size(59, 19);
            this.checkBox_yo.TabIndex = 6;
            this.checkBox_yo.Text = "有機";
            this.checkBox_yo.UseVisualStyleBackColor = true;
            this.checkBox_yo.CheckStateChanged += new System.EventHandler(this.checkBox_yo_CheckStateChanged);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.授權人員DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.method有機BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(503, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // 授權人員DataGridViewTextBoxColumn
            // 
            this.授權人員DataGridViewTextBoxColumn.DataPropertyName = "授權人員";
            this.授權人員DataGridViewTextBoxColumn.HeaderText = "授權人員";
            this.授權人員DataGridViewTextBoxColumn.Name = "授權人員DataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.授權人員DataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.method無機BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(503, 229);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 7;
            // 
            // 授權人員DataGridViewTextBoxColumn1
            // 
            this.授權人員DataGridViewTextBoxColumn1.DataPropertyName = "授權人員";
            this.授權人員DataGridViewTextBoxColumn1.HeaderText = "授權人員";
            this.授權人員DataGridViewTextBoxColumn1.Name = "授權人員DataGridViewTextBoxColumn1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
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
            // comboBox_me
            // 
            this.comboBox_me.FormattingEnabled = true;
            this.comboBox_me.Location = new System.Drawing.Point(82, 164);
            this.comboBox_me.Name = "comboBox_me";
            this.comboBox_me.Size = new System.Drawing.Size(98, 23);
            this.comboBox_me.TabIndex = 10;
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // 授權人員DataGridViewTextBoxColumn2
            // 
            this.授權人員DataGridViewTextBoxColumn2.DataPropertyName = "授權人員";
            this.授權人員DataGridViewTextBoxColumn2.HeaderText = "授權人員";
            this.授權人員DataGridViewTextBoxColumn2.Name = "授權人員DataGridViewTextBoxColumn2";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.授權人員DataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.method無機BindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(82, 257);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 12;
            // 
            // Form_method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button_delete_me);
            this.Controls.Add(this.button_add_me);
            this.Controls.Add(this.comboBox_me);
            this.Controls.Add(this.label_method);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private System.Windows.Forms.CheckBox checkBox_yo;
        private System.Windows.Forms.CheckBox checkBox_wu;
        private tasks_databaseDataSet6TableAdapters.Method有機TableAdapter method有機TableAdapter1;
        private tasks_databaseDataSet7 tasks_databaseDataSet7;
        private System.Windows.Forms.BindingSource method有機BindingSource;
        private tasks_databaseDataSet7TableAdapters.Method有機TableAdapter method有機TableAdapter;
        private System.Windows.Forms.ComboBox comboBox_wu;
        private tasks_databaseDataSet8 tasks_databaseDataSet8;
        private System.Windows.Forms.BindingSource method無機BindingSource;
        private tasks_databaseDataSet8TableAdapters.Method無機TableAdapter method無機TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 授權人員DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 授權人員DataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_method;
        private System.Windows.Forms.ComboBox comboBox_me;
        private System.Windows.Forms.Button button_add_me;
        private System.Windows.Forms.Button button_delete_me;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 授權人員DataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}