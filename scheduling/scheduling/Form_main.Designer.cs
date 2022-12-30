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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tasks_databaseDataSet = new scheduling.tasks_databaseDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new scheduling.tasks_databaseDataSetTableAdapters.TableTableAdapter();
            this.專案編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.採樣日期起DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.委託單報告日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.天數DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.檢測項目設備名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.分析方法DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.課別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.案件負責人DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add_task
            // 
            this.button_add_task.Location = new System.Drawing.Point(48, 600);
            this.button_add_task.Name = "button_add_task";
            this.button_add_task.Size = new System.Drawing.Size(75, 23);
            this.button_add_task.TabIndex = 0;
            this.button_add_task.Text = "新增專案";
            this.button_add_task.UseVisualStyleBackColor = true;
            this.button_add_task.Click += new System.EventHandler(this.button_add_task_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.專案編號DataGridViewTextBoxColumn,
            this.採樣日期起DataGridViewTextBoxColumn,
            this.委託單報告日期DataGridViewTextBoxColumn,
            this.天數DataGridViewTextBoxColumn,
            this.檢測項目設備名稱DataGridViewTextBoxColumn,
            this.分析方法DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn,
            this.課別DataGridViewTextBoxColumn,
            this.案件負責人DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(947, 560);
            this.dataGridView1.TabIndex = 1;
            // 
            // tasks_databaseDataSet
            // 
            this.tasks_databaseDataSet.DataSetName = "tasks_databaseDataSet";
            this.tasks_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.tasks_databaseDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
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
            // 天數DataGridViewTextBoxColumn
            // 
            this.天數DataGridViewTextBoxColumn.DataPropertyName = "天數";
            this.天數DataGridViewTextBoxColumn.HeaderText = "天數";
            this.天數DataGridViewTextBoxColumn.Name = "天數DataGridViewTextBoxColumn";
            // 
            // 檢測項目設備名稱DataGridViewTextBoxColumn
            // 
            this.檢測項目設備名稱DataGridViewTextBoxColumn.DataPropertyName = "檢測項目/設備名稱";
            this.檢測項目設備名稱DataGridViewTextBoxColumn.HeaderText = "檢測項目/設備名稱";
            this.檢測項目設備名稱DataGridViewTextBoxColumn.Name = "檢測項目設備名稱DataGridViewTextBoxColumn";
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
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_add_task);
            this.Name = "Form_main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add_task;
        private System.Windows.Forms.DataGridView dataGridView1;
        private tasks_databaseDataSet tasks_databaseDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private tasks_databaseDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 專案編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 採樣日期起DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 委託單報告日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 天數DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 檢測項目設備名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分析方法DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 課別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 案件負責人DataGridViewTextBoxColumn;
    }
}

