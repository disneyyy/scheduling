namespace scheduling
{
    partial class Form_Time
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_method = new System.Windows.Forms.TextBox();
            this.label_method = new System.Windows.Forms.Label();
            this.textBox_work = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_basic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.tasks_databaseDataSet12 = new scheduling.tasks_databaseDataSet12();
            this.timeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeTableAdapter = new scheduling.tasks_databaseDataSet12TableAdapters.TimeTableAdapter();
            this.分析編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.基本工時DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作業時間DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.分析編號DataGridViewTextBoxColumn,
            this.基本工時DataGridViewTextBoxColumn,
            this.作業時間DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.timeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(351, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(437, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(211, 50);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "新增";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_method
            // 
            this.textBox_method.Location = new System.Drawing.Point(85, 50);
            this.textBox_method.Name = "textBox_method";
            this.textBox_method.Size = new System.Drawing.Size(100, 25);
            this.textBox_method.TabIndex = 2;
            // 
            // label_method
            // 
            this.label_method.AutoSize = true;
            this.label_method.Location = new System.Drawing.Point(12, 53);
            this.label_method.Name = "label_method";
            this.label_method.Size = new System.Drawing.Size(67, 15);
            this.label_method.TabIndex = 3;
            this.label_method.Text = "分析編號";
            // 
            // textBox_work
            // 
            this.textBox_work.Location = new System.Drawing.Point(85, 148);
            this.textBox_work.Name = "textBox_work";
            this.textBox_work.Size = new System.Drawing.Size(100, 25);
            this.textBox_work.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "作業時間";
            // 
            // textBox_basic
            // 
            this.textBox_basic.Location = new System.Drawing.Point(85, 101);
            this.textBox_basic.Name = "textBox_basic";
            this.textBox_basic.Size = new System.Drawing.Size(100, 25);
            this.textBox_basic.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "基本工時";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(211, 100);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "刪除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(211, 148);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 1;
            this.button_edit.Text = "修改";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // tasks_databaseDataSet12
            // 
            this.tasks_databaseDataSet12.DataSetName = "tasks_databaseDataSet12";
            this.tasks_databaseDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timeBindingSource
            // 
            this.timeBindingSource.DataMember = "Time";
            this.timeBindingSource.DataSource = this.tasks_databaseDataSet12;
            // 
            // timeTableAdapter
            // 
            this.timeTableAdapter.ClearBeforeFill = true;
            // 
            // 分析編號DataGridViewTextBoxColumn
            // 
            this.分析編號DataGridViewTextBoxColumn.DataPropertyName = "分析編號";
            this.分析編號DataGridViewTextBoxColumn.HeaderText = "分析編號";
            this.分析編號DataGridViewTextBoxColumn.Name = "分析編號DataGridViewTextBoxColumn";
            // 
            // 基本工時DataGridViewTextBoxColumn
            // 
            this.基本工時DataGridViewTextBoxColumn.DataPropertyName = "基本工時";
            this.基本工時DataGridViewTextBoxColumn.HeaderText = "基本工時";
            this.基本工時DataGridViewTextBoxColumn.Name = "基本工時DataGridViewTextBoxColumn";
            // 
            // 作業時間DataGridViewTextBoxColumn
            // 
            this.作業時間DataGridViewTextBoxColumn.DataPropertyName = "作業時間";
            this.作業時間DataGridViewTextBoxColumn.HeaderText = "作業時間";
            this.作業時間DataGridViewTextBoxColumn.Name = "作業時間DataGridViewTextBoxColumn";
            // 
            // Form_Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_basic);
            this.Controls.Add(this.textBox_work);
            this.Controls.Add(this.label_method);
            this.Controls.Add(this.textBox_method);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Time";
            this.Text = "Form_Time";
            this.Load += new System.EventHandler(this.Form_Time_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_method;
        private System.Windows.Forms.Label label_method;
        private System.Windows.Forms.TextBox textBox_work;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_basic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private tasks_databaseDataSet12 tasks_databaseDataSet12;
        private System.Windows.Forms.BindingSource timeBindingSource;
        private tasks_databaseDataSet12TableAdapters.TimeTableAdapter timeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分析編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 基本工時DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作業時間DataGridViewTextBoxColumn;
    }
}