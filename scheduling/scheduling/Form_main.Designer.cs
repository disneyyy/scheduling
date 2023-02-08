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
            this.分析人員 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.專案BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tasks_databaseDataSet15 = new scheduling.tasks_databaseDataSet15();
            this.專案BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tasks_databaseDataSet9 = new scheduling.tasks_databaseDataSet9();
            this.專案BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasks_databaseDataSet5 = new scheduling.tasks_databaseDataSet5();
            this.專案TableAdapter = new scheduling.tasks_databaseDataSet4TableAdapters.專案TableAdapter();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_refresh = new System.Windows.Forms.TextBox();
            this.專案TableAdapter1 = new scheduling.tasks_databaseDataSet5TableAdapters.專案TableAdapter();
            this.textBox_delete = new System.Windows.Forms.TextBox();
            this.label_basic_time = new System.Windows.Forms.Label();
            this.label_delete = new System.Windows.Forms.Label();
            this.button_method = new System.Windows.Forms.Button();
            this.專案TableAdapter2 = new scheduling.tasks_databaseDataSet9TableAdapters.專案TableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button_time = new System.Windows.Forms.Button();
            this.label_task_id = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label_method = new System.Windows.Forms.Label();
            this.label_class = new System.Windows.Forms.Label();
            this.button_allo = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView_time = new System.Windows.Forms.DataGridView();
            this.label_time = new System.Windows.Forms.Label();
            this.label_last = new System.Windows.Forms.Label();
            this.label_worker = new System.Windows.Forms.Label();
            this.label_test_obj = new System.Windows.Forms.Label();
            this.專案TableAdapter3 = new scheduling.tasks_databaseDataSet15TableAdapters.專案TableAdapter();
            this.button_allo2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.測試BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.專案BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.專案BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.專案BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_time)).BeginInit();
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
            this.案件負責人DataGridViewTextBoxColumn,
            this.分析人員});
            this.dataGridView1.DataSource = this.專案BindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(-27, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(657, 448);
            this.dataGridView1.TabIndex = 6;
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
            // 分析人員
            // 
            this.分析人員.DataPropertyName = "分析人員";
            this.分析人員.HeaderText = "分析人員";
            this.分析人員.Name = "分析人員";
            // 
            // 專案BindingSource2
            // 
            this.專案BindingSource2.DataMember = "專案";
            this.專案BindingSource2.DataSource = this.tasks_databaseDataSet15;
            // 
            // tasks_databaseDataSet15
            // 
            this.tasks_databaseDataSet15.DataSetName = "tasks_databaseDataSet15";
            this.tasks_databaseDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label_basic_time
            // 
            this.label_basic_time.AutoSize = true;
            this.label_basic_time.Location = new System.Drawing.Point(1049, 508);
            this.label_basic_time.Name = "label_basic_time";
            this.label_basic_time.Size = new System.Drawing.Size(67, 15);
            this.label_basic_time.TabIndex = 5;
            this.label_basic_time.Text = "基本工時";
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
            this.button3.Location = new System.Drawing.Point(467, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "reset";
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
            // label_task_id
            // 
            this.label_task_id.AutoSize = true;
            this.label_task_id.Location = new System.Drawing.Point(691, 632);
            this.label_task_id.Name = "label_task_id";
            this.label_task_id.Size = new System.Drawing.Size(67, 15);
            this.label_task_id.TabIndex = 15;
            this.label_task_id.Text = "專案編號";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(783, 649);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(37, 15);
            this.label_count.TabIndex = 16;
            this.label_count.Text = "數量";
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
            this.button4.Text = "get";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label_method
            // 
            this.label_method.AutoSize = true;
            this.label_method.Location = new System.Drawing.Point(887, 636);
            this.label_method.Name = "label_method";
            this.label_method.Size = new System.Drawing.Size(67, 15);
            this.label_method.TabIndex = 16;
            this.label_method.Text = "分析方法";
            // 
            // label_class
            // 
            this.label_class.AutoSize = true;
            this.label_class.Location = new System.Drawing.Point(976, 649);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(37, 15);
            this.label_class.TabIndex = 16;
            this.label_class.Text = "課別";
            // 
            // button_allo
            // 
            this.button_allo.Location = new System.Drawing.Point(1028, 569);
            this.button_allo.Name = "button_allo";
            this.button_allo.Size = new System.Drawing.Size(75, 23);
            this.button_allo.TabIndex = 19;
            this.button_allo.Text = "指派";
            this.button_allo.UseVisualStyleBackColor = true;
            this.button_allo.Click += new System.EventHandler(this.button_allo_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(768, 68);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(487, 150);
            this.dataGridView3.TabIndex = 20;
            // 
            // dataGridView_time
            // 
            this.dataGridView_time.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_time.Location = new System.Drawing.Point(694, 275);
            this.dataGridView_time.Name = "dataGridView_time";
            this.dataGridView_time.RowTemplate.Height = 27;
            this.dataGridView_time.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_time.TabIndex = 21;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(1049, 537);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(37, 15);
            this.label_time.TabIndex = 5;
            this.label_time.Text = "時間";
            // 
            // label_last
            // 
            this.label_last.AutoSize = true;
            this.label_last.Location = new System.Drawing.Point(1168, 362);
            this.label_last.Name = "label_last";
            this.label_last.Size = new System.Drawing.Size(67, 15);
            this.label_last.TabIndex = 5;
            this.label_last.Text = "剩餘時間";
            // 
            // label_worker
            // 
            this.label_worker.AutoSize = true;
            this.label_worker.Location = new System.Drawing.Point(1168, 332);
            this.label_worker.Name = "label_worker";
            this.label_worker.Size = new System.Drawing.Size(67, 15);
            this.label_worker.TabIndex = 5;
            this.label_worker.Text = "分析人員";
            // 
            // label_test_obj
            // 
            this.label_test_obj.AutoSize = true;
            this.label_test_obj.Location = new System.Drawing.Point(832, 610);
            this.label_test_obj.Name = "label_test_obj";
            this.label_test_obj.Size = new System.Drawing.Size(67, 15);
            this.label_test_obj.TabIndex = 16;
            this.label_test_obj.Text = "檢測項目";
            // 
            // 專案TableAdapter3
            // 
            this.專案TableAdapter3.ClearBeforeFill = true;
            // 
            // button_allo2
            // 
            this.button_allo2.Location = new System.Drawing.Point(1119, 569);
            this.button_allo2.Name = "button_allo2";
            this.button_allo2.Size = new System.Drawing.Size(75, 23);
            this.button_allo2.TabIndex = 19;
            this.button_allo2.Text = "確認";
            this.button_allo2.UseVisualStyleBackColor = true;
            this.button_allo2.Click += new System.EventHandler(this.button_allo3_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.dataGridView_time);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button_allo2);
            this.Controls.Add(this.button_allo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_class);
            this.Controls.Add(this.label_test_obj);
            this.Controls.Add(this.label_method);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label_task_id);
            this.Controls.Add(this.button_time);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_method);
            this.Controls.Add(this.label_delete);
            this.Controls.Add(this.textBox_delete);
            this.Controls.Add(this.textBox_refresh);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_worker);
            this.Controls.Add(this.label_last);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_basic_time);
            this.Controls.Add(this.button_add_task);
            this.Name = "Form_main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.測試BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.專案BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.專案BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.專案BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_time)).EndInit();
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
        private System.Windows.Forms.Label label_basic_time;
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
        private System.Windows.Forms.Label label_task_id;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label_method;
        private System.Windows.Forms.Label label_class;
        private System.Windows.Forms.Button button_allo;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView_time;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_last;
        private System.Windows.Forms.Label label_worker;
        private System.Windows.Forms.Label label_test_obj;
        private tasks_databaseDataSet15 tasks_databaseDataSet15;
        private System.Windows.Forms.BindingSource 專案BindingSource2;
        private tasks_databaseDataSet15TableAdapters.專案TableAdapter 專案TableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分析人員;
        private System.Windows.Forms.Button button_allo2;
    }
}

