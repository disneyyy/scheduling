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
            this.button_add_task = new System.Windows.Forms.Button();
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
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.button_add_task);
            this.Name = "Form_main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add_task;
    }
}

