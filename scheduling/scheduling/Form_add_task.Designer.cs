namespace scheduling
{
    partial class Form_add_task
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
            this.textBox_task_num = new System.Windows.Forms.TextBox();
            this.label_task_num = new System.Windows.Forms.Label();
            this.textBox_object = new System.Windows.Forms.TextBox();
            this.label_object = new System.Windows.Forms.Label();
            this.textBox_method = new System.Windows.Forms.TextBox();
            this.label_method = new System.Windows.Forms.Label();
            this.label_deadline = new System.Windows.Forms.Label();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.textBox_class = new System.Windows.Forms.TextBox();
            this.textBox_staff = new System.Windows.Forms.TextBox();
            this.label_count = new System.Windows.Forms.Label();
            this.label_staff = new System.Windows.Forms.Label();
            this.label_class = new System.Windows.Forms.Label();
            this.label_get_date = new System.Windows.Forms.Label();
            this.button_yes = new System.Windows.Forms.Button();
            this.tasks_databaseDataSet1 = new scheduling.tasks_databaseDataSet1();
            this.測試BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.測試TableAdapter = new scheduling.tasks_databaseDataSet1TableAdapters.測試TableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.測試BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_task_num
            // 
            this.textBox_task_num.Location = new System.Drawing.Point(82, 36);
            this.textBox_task_num.Name = "textBox_task_num";
            this.textBox_task_num.Size = new System.Drawing.Size(100, 25);
            this.textBox_task_num.TabIndex = 0;
            // 
            // label_task_num
            // 
            this.label_task_num.AutoSize = true;
            this.label_task_num.Location = new System.Drawing.Point(12, 39);
            this.label_task_num.Name = "label_task_num";
            this.label_task_num.Size = new System.Drawing.Size(67, 15);
            this.label_task_num.TabIndex = 1;
            this.label_task_num.Text = "專案編號";
            // 
            // textBox_object
            // 
            this.textBox_object.Location = new System.Drawing.Point(272, 36);
            this.textBox_object.Name = "textBox_object";
            this.textBox_object.Size = new System.Drawing.Size(100, 25);
            this.textBox_object.TabIndex = 0;
            // 
            // label_object
            // 
            this.label_object.AutoSize = true;
            this.label_object.Location = new System.Drawing.Point(199, 39);
            this.label_object.Name = "label_object";
            this.label_object.Size = new System.Drawing.Size(67, 15);
            this.label_object.TabIndex = 1;
            this.label_object.Text = "檢測項目";
            // 
            // textBox_method
            // 
            this.textBox_method.Location = new System.Drawing.Point(473, 36);
            this.textBox_method.Name = "textBox_method";
            this.textBox_method.Size = new System.Drawing.Size(100, 25);
            this.textBox_method.TabIndex = 0;
            // 
            // label_method
            // 
            this.label_method.AutoSize = true;
            this.label_method.Location = new System.Drawing.Point(400, 39);
            this.label_method.Name = "label_method";
            this.label_method.Size = new System.Drawing.Size(67, 15);
            this.label_method.TabIndex = 1;
            this.label_method.Text = "分析方法";
            // 
            // label_deadline
            // 
            this.label_deadline.AutoSize = true;
            this.label_deadline.Location = new System.Drawing.Point(370, 170);
            this.label_deadline.Name = "label_deadline";
            this.label_deadline.Size = new System.Drawing.Size(97, 15);
            this.label_deadline.TabIndex = 1;
            this.label_deadline.Text = "委託報告日期";
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(82, 106);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(100, 25);
            this.textBox_count.TabIndex = 0;
            // 
            // textBox_class
            // 
            this.textBox_class.Location = new System.Drawing.Point(272, 106);
            this.textBox_class.Name = "textBox_class";
            this.textBox_class.Size = new System.Drawing.Size(100, 25);
            this.textBox_class.TabIndex = 0;
            // 
            // textBox_staff
            // 
            this.textBox_staff.Location = new System.Drawing.Point(473, 106);
            this.textBox_staff.Name = "textBox_staff";
            this.textBox_staff.Size = new System.Drawing.Size(100, 25);
            this.textBox_staff.TabIndex = 0;
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(35, 109);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(37, 15);
            this.label_count.TabIndex = 1;
            this.label_count.Text = "數量";
            // 
            // label_staff
            // 
            this.label_staff.AutoSize = true;
            this.label_staff.Location = new System.Drawing.Point(385, 109);
            this.label_staff.Name = "label_staff";
            this.label_staff.Size = new System.Drawing.Size(82, 15);
            this.label_staff.TabIndex = 1;
            this.label_staff.Text = "案件負責人";
            // 
            // label_class
            // 
            this.label_class.AutoSize = true;
            this.label_class.Location = new System.Drawing.Point(225, 109);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(37, 15);
            this.label_class.TabIndex = 1;
            this.label_class.Text = "課別";
            // 
            // label_get_date
            // 
            this.label_get_date.AutoSize = true;
            this.label_get_date.Location = new System.Drawing.Point(5, 170);
            this.label_get_date.Name = "label_get_date";
            this.label_get_date.Size = new System.Drawing.Size(67, 15);
            this.label_get_date.TabIndex = 1;
            this.label_get_date.Text = "採樣日期";
            // 
            // button_yes
            // 
            this.button_yes.Location = new System.Drawing.Point(659, 72);
            this.button_yes.Name = "button_yes";
            this.button_yes.Size = new System.Drawing.Size(75, 23);
            this.button_yes.TabIndex = 3;
            this.button_yes.Text = "確定";
            this.button_yes.UseVisualStyleBackColor = true;
            this.button_yes.Click += new System.EventHandler(this.button_yes_Click);
            // 
            // tasks_databaseDataSet1
            // 
            this.tasks_databaseDataSet1.DataSetName = "tasks_databaseDataSet1";
            this.tasks_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 測試BindingSource
            // 
            this.測試BindingSource.DataMember = "測試";
            this.測試BindingSource.DataSource = this.tasks_databaseDataSet1;
            // 
            // 測試TableAdapter
            // 
            this.測試TableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(473, 167);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // comboBox_class
            // 
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Items.AddRange(new object[] {
            "有機",
            "無機"});
            this.comboBox_class.Location = new System.Drawing.Point(272, 109);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(100, 23);
            this.comboBox_class.TabIndex = 5;
            this.comboBox_class.Text = "有機";
            // 
            // Form_add_task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_class);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_yes);
            this.Controls.Add(this.label_get_date);
            this.Controls.Add(this.label_deadline);
            this.Controls.Add(this.label_class);
            this.Controls.Add(this.label_object);
            this.Controls.Add(this.label_staff);
            this.Controls.Add(this.label_method);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label_task_num);
            this.Controls.Add(this.textBox_staff);
            this.Controls.Add(this.textBox_method);
            this.Controls.Add(this.textBox_class);
            this.Controls.Add(this.textBox_object);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.textBox_task_num);
            this.Name = "Form_add_task";
            this.Text = "Form_add_task";
            this.Load += new System.EventHandler(this.Form_add_task_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.測試BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_task_num;
        private System.Windows.Forms.Label label_task_num;
        private System.Windows.Forms.TextBox textBox_object;
        private System.Windows.Forms.Label label_object;
        private System.Windows.Forms.TextBox textBox_method;
        private System.Windows.Forms.Label label_method;
        private System.Windows.Forms.Label label_deadline;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.TextBox textBox_class;
        private System.Windows.Forms.TextBox textBox_staff;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label_staff;
        private System.Windows.Forms.Label label_class;
        private System.Windows.Forms.Label label_get_date;
        private System.Windows.Forms.Button button_yes;
        private tasks_databaseDataSet1 tasks_databaseDataSet1;
        private System.Windows.Forms.BindingSource 測試BindingSource;
        private tasks_databaseDataSet1TableAdapters.測試TableAdapter 測試TableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox_class;
    }
}