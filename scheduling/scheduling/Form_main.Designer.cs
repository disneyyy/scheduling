namespace scheduling
{
    partial class Form_main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_add_task = new System.Windows.Forms.Button();
            this.測試BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasks_databaseDataSet3 = new scheduling.tasks_databaseDataSet3();
            this.測試TableAdapter = new scheduling.tasks_databaseDataSet3TableAdapters.測試TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.專案編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.採樣日期起DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.委託單報告日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.檢測項目DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.分析方法DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.課別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.案件負責人DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.專案BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tasks_databaseDataSet9 = new scheduling.tasks_databaseDataSet9();
            this.專案BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasks_databaseDataSet5 = new scheduling.tasks_databaseDataSet5();
            this.專案TableAdapter = new scheduling.tasks_databaseDataSet4TableAdapters.專案TableAdapter();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_refresh = new System.Windows.Forms.TextBox();
            this.專案TableAdapter1 = new scheduling.tasks_databaseDataSet5TableAdapters.專案TableAdapter();
            this.textBox_delete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label_delete = new System.Windows.Forms.Label();
            this.button_method = new System.Windows.Forms.Button();
            this.專案TableAdapter2 = new scheduling.tasks_databaseDataSet9TableAdapters.專案TableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button_time = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.測試BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.專案BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.專案BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add_task
            // 
            this.button_add_task.Location = new System.Drawing.Point(60, 570);
            this.button_add_task.Name = "button_add_task";
            this.button_add_task.Size = new System.Drawing.Size(89, 23);
            this.button_add_task.TabIndex = 0;
            this.button_add_task.Text = "新增專案";
            this.button_add_task.UseVisualStyleBackColor = true;
            this.button_add_task.Click += new System.EventHandler(this.button_add_task_Click);
            // 
            // 測試BindingSource
            // 
            this.測試BindingSource.DataMember = "測試";
            this.測試BindingSource.DataSource = this.tasks_databaseDataSet3;
            // 
            // tasks_databaseDataSet3
            // 
            this.tasks_databaseDataSet3.DataSetName = "tasks_databaseDataSet3";
            this.tasks_databaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 測試TableAdapter
            // 
            this.測試TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.專案編號DataGridViewTextBoxColumn,
            this.採樣日期起DataGridViewTextBoxColumn,
            this.委託單報告日期DataGridViewTextBoxColumn,
            this.檢測項目DataGridViewTextBoxColumn,
            this.分析方法DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn,
            this.課別DataGridViewTextBoxColumn,
            this.案件負責人DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.專案BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-27, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1282, 521);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // 專案編號DataGridViewTextBoxColumn
            // 
            this.專案編號DataGridViewTextBoxColumn.DataPropertyName = "專案編號";
            this.專案編號DataGridViewTextBoxColumn.HeaderText = "專案編號";
            this.專案編號DataGridViewTextBoxColumn.Name = "專案編號DataGridViewTextBoxColumn";
            // 
            // 採樣日期起DataGridViewTextBoxColumn
            // 
            this.採樣日期起DataGridViewTextBoxColumn.DataPropertyName = "採樣日期起";
            this.採樣日期起DataGridViewTextBoxColumn.HeaderText = "採樣日期起";
            this.採樣日期起DataGridViewTextBoxColumn.Name = "採樣日期起DataGridViewTextBoxColumn";
            // 
            // 委託單報告日期DataGridViewTextBoxColumn
            // 
            this.委託單報告日期DataGridViewTextBoxColumn.DataPropertyName = "委託單報告日期";
            this.委託單報告日期DataGridViewTextBoxColumn.HeaderText = "委託單報告日期";
            this.委託單報告日期DataGridViewTextBoxColumn.Name = "委託單報告日期DataGridViewTextBoxColumn";
            // 
            // 檢測項目DataGridViewTextBoxColumn
            // 
            this.檢測項目DataGridViewTextBoxColumn.DataPropertyName = "檢測項目";
            this.檢測項目DataGridViewTextBoxColumn.HeaderText = "檢測項目";
            this.檢測項目DataGridViewTextBoxColumn.Name = "檢測項目DataGridViewTextBoxColumn";
            // 
            // 分析方法DataGridViewTextBoxColumn
            // 
            this.分析方法DataGridViewTextBoxColumn.DataPropertyName = "分析方法";
            this.分析方法DataGridViewTextBoxColumn.HeaderText = "分析方法";
            this.分析方法DataGridViewTextBoxColumn.Name = "分析方法DataGridViewTextBoxColumn";
            // 
            // 數量DataGridViewTextBoxColumn
            // 
            this.數量DataGridViewTextBoxColumn.DataPropertyName = "數量";
            this.數量DataGridViewTextBoxColumn.HeaderText = "數量";
            this.數量DataGridViewTextBoxColumn.Name = "數量DataGridViewTextBoxColumn";
            // 
            // 課別DataGridViewTextBoxColumn
            // 
            this.課別DataGridViewTextBoxColumn.DataPropertyName = "課別";
            this.課別DataGridViewTextBoxColumn.HeaderText = "課別";
            this.課別DataGridViewTextBoxColumn.Name = "課別DataGridViewTextBoxColumn";
            // 
            // 案件負責人DataGridViewTextBoxColumn
            // 
            this.案件負責人DataGridViewTextBoxColumn.DataPropertyName = "案件負責人";
            this.案件負責人DataGridViewTextBoxColumn.HeaderText = "案件負責人";
            this.案件負責人DataGridViewTextBoxColumn.Name = "案件負責人DataGridViewTextBoxColumn";
            // 
            // 專案BindingSource1
            // 
            this.專案BindingSource1.DataMember = "專案";
            this.專案BindingSource1.DataSource = this.tasks_databaseDataSet9;
            // 
            // tasks_databaseDataSet9
            // 
            this.tasks_databaseDataSet9.DataSetName = "tasks_databaseDataSet9";
            this.tasks_databaseDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 專案BindingSource
            // 
            this.專案BindingSource.DataMember = "專案";
            this.專案BindingSource.DataSource = this.tasks_databaseDataSet5;
            // 
            // tasks_databaseDataSet5
            // 
            this.tasks_databaseDataSet5.DataSetName = "tasks_databaseDataSet5";
            this.tasks_databaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 專案TableAdapter
            // 
            this.專案TableAdapter.ClearBeforeFill = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(339, 599);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "刪除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_refresh
            // 
            this.textBox_refresh.Location = new System.Drawing.Point(1155, 600);
            this.textBox_refresh.Name = "textBox_refresh";
            this.textBox_refresh.Size = new System.Drawing.Size(100, 25);
            this.textBox_refresh.TabIndex = 8;
            this.textBox_refresh.Visible = false;
            this.textBox_refresh.TextChanged += new System.EventHandler(this.textBox_refresh_TextChanged);
            // 
            // 專案TableAdapter1
            // 
            this.專案TableAdapter1.ClearBeforeFill = true;
            // 
            // textBox_delete
            // 
            this.textBox_delete.Location = new System.Drawing.Point(233, 600);
            this.textBox_delete.Name = "textBox_delete";
            this.textBox_delete.Size = new System.Drawing.Size(100, 25);
            this.textBox_delete.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1049, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(996, 435);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1079, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1079, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "date";
            this.date.Name = "date";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.測試BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(919, 101);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(338, 150);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.Visible = false;
            // 
            // label_delete
            // 
            this.label_delete.AutoSize = true;
            this.label_delete.Location = new System.Drawing.Point(206, 582);
            this.label_delete.Name = "label_delete";
            this.label_delete.Size = new System.Drawing.Size(127, 15);
            this.label_delete.TabIndex = 10;
            this.label_delete.Text = "欲刪除之專案編號";
            // 
            // button_method
            // 
            this.button_method.Location = new System.Drawing.Point(60, 599);
            this.button_method.Name = "button_method";
            this.button_method.Size = new System.Drawing.Size(89, 23);
            this.button_method.TabIndex = 11;
            this.button_method.Text = "方法授權表";
            this.button_method.UseVisualStyleBackColor = true;
            this.button_method.Click += new System.EventHandler(this.button_method_Click);
            // 
            // 專案TableAdapter2
            // 
            this.專案TableAdapter2.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(586, 599);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_time
            // 
            this.button_time.Location = new System.Drawing.Point(60, 628);
            this.button_time.Name = "button_time";
            this.button_time.Size = new System.Drawing.Size(89, 23);
            this.button_time.TabIndex = 13;
            this.button_time.Text = "理論工時";
            this.button_time.UseVisualStyleBackColor = true;
            this.button_time.Click += new System.EventHandler(this.button_time_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 632);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(783, 649);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(724, 572);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "0";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(938, 569);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(874, 628);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1010, 649);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "label4";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_time);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_method);
            this.Controls.Add(this.label_delete);
            this.Controls.Add(this.textBox_delete);
            this.Controls.Add(this.textBox_refresh);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button_add_task);
            this.Name = "Form_main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.測試BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.專案BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.專案BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add_task;
        private tasks_databaseDataSet3 tasks_databaseDataSet3;
        private System.Windows.Forms.BindingSource 測試BindingSource;
        private tasks_databaseDataSet3TableAdapters.測試TableAdapter 測試TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private tasks_databaseDataSet4TableAdapters.專案TableAdapter 專案TableAdapter;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_refresh;
        private tasks_databaseDataSet5 tasks_databaseDataSet5;
        private System.Windows.Forms.BindingSource 專案BindingSource;
        private tasks_databaseDataSet5TableAdapters.專案TableAdapter 專案TableAdapter1;
        private System.Windows.Forms.TextBox textBox_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label_delete;
        private System.Windows.Forms.Button button_method;
        private tasks_databaseDataSet9 tasks_databaseDataSet9;
        private System.Windows.Forms.BindingSource 專案BindingSource1;
        private tasks_databaseDataSet9TableAdapters.專案TableAdapter 專案TableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 專案編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 採樣日期起DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 委託單報告日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 檢測項目DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分析方法DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 課別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 案件負責人DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

