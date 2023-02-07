﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace scheduling
{
    public partial class Form_main : Form
    {
        public string date_test;
        public Form_main()
        {
            InitializeComponent();
        }

        private void button_add_task_Click(object sender, EventArgs e)
        {

            Form_add_task add_task = new Form_add_task();
            add_task.Show(this);
            refresh_task();
        }
        private void refresh_task()
        {
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True
            //建立SqlConnection物件db
            SqlConnection db = new SqlConnection();
            //設定db連接ch15DB資料庫檔案
            db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
            //建立DataAdapter物件da
            //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM 專案 ORDER BY 課別, 委託單報告日期 ASC", db);
            //建立DataSet物件ds
            DataSet ds = new DataSet();
            //將da物件所取得的資料填入ds物件
            da.Fill(ds);
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Form_main_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'tasks_databaseDataSet15.專案' 資料表。您可以視需要進行移動或移除。
            this.專案TableAdapter3.Fill(this.tasks_databaseDataSet15.專案);
            // TODO: 這行程式碼會將資料載入 'tasks_databaseDataSet9.專案' 資料表。您可以視需要進行移動或移除。
            this.專案TableAdapter2.Fill(this.tasks_databaseDataSet9.專案);
            // TODO: 這行程式碼會將資料載入 'tasks_databaseDataSet5.專案' 資料表。您可以視需要進行移動或移除。
            //this.專案TableAdapter1.Fill(this.tasks_databaseDataSet5.專案);
            // TODO: 這行程式碼會將資料載入 'tasks_databaseDataSet3.測試' 資料表。您可以視需要進行移動或移除。
            this.測試TableAdapter.Fill(this.tasks_databaseDataSet3.測試);
            refresh_task();
           
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "DELETE FROM 專案 WHERE 專案編號 = '" + textBox_delete.Text + "'";
                cmd.ExecuteNonQuery();
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refresh_task();
            textBox_delete.Text = "";
        }

        private void textBox_refresh_TextChanged(object sender, EventArgs e)
        {
            refresh_task();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox_delete.Text = "1";
        }

        private void button_method_Click(object sender, EventArgs e)
        {
            Form_method manage_method = new Form_method();
            manage_method.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                db.Open();
                                
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM 專案 ORDER BY 課別, 委託單報告日期 ASC", db);
                //建立DataSet物件ds
                DataSet ds = new DataSet();
                //將da物件所取得的資料填入ds物件
                da.Fill(ds);
                //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                dataGridView1.DataSource = ds.Tables[0];
                db.Close();
                //refresh_task();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_time_Click(object sender, EventArgs e)
        {
            Form_Time time = new Form_Time();
            time.Show();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            BindingManagerBase bm;
            SqlConnection db = new SqlConnection();
            db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
            DataSet ds = new DataSet();
            SqlDataAdapter daProduct = new SqlDataAdapter("SELECT * FROM 專案 ORDER BY 課別, 委託單報告日期 ASC", db);
            daProduct.Fill(ds, "專案");
            //https://msdn.microsoft.com/zh-tw/library/system.windows.forms.controlbindingscollection(v=vs.110).aspx
            label2.DataBindings.Add("Text", ds, "專案.專案編號");
            label3.DataBindings.Add("Text", ds, "專案.數量");
            label4.DataBindings.Add("Text", ds, "專案.分析方法");
            label5.DataBindings.Add("Text", ds, "專案.課別");
            label1.DataBindings.Add("Text", ds, "專案.檢測項目");
            bm = this.BindingContext[ds, "專案"];
            db.Close();
            //this 代表 form1 , 使用form1的BindingContext屬性指定bm(BindingManaterBase)物件瀏覽產品資料表
            //https://msdn.microsoft.com/zh-tw/library/system.windows.forms.bindingmanagerbase(v=vs.110).aspx
            if(int.Parse(textBox1.Text) < bm.Count)
            {
                bm.Position = int.Parse(textBox1.Text);
            }
            else
            {
                bm.Position = 0;
            }
            label2.DataBindings.Clear();
            label3.DataBindings.Clear();
            label4.DataBindings.Clear();
            label5.DataBindings.Clear();
            label1.DataBindings.Clear();
        }

        private void button_allo_Click(object sender, EventArgs e)
        {
            //label4:分析方法
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                db.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Method" + label5.Text + " WHERE 就緒 = 1 AND " + label4.Text +"=1 ORDER BY 剩餘時間 DESC, 數量 ASC", db);
                //建立DataSet物件ds
                DataSet ds = new DataSet();
                //將da物件所取得的資料填入ds物件
                da.Fill(ds, "Method" + label5.Text);
                //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                //dataGridView2.DataSource = ds.Tables[0];
                dataGridView3.DataSource = ds;
                dataGridView3.DataMember = "Method" + label5.Text;

                SqlDataAdapter da_time = new SqlDataAdapter("SELECT * FROM Time WHERE 分析編號 = '" + label4.Text + "'", db);
                DataSet ds_time = new DataSet();
                da_time.Fill(ds_time, "Time");
                dataGridView_time.DataSource = ds_time;
                dataGridView_time.DataMember = "Time";

                BindingManagerBase bm_time, bm_method;

                label_basic_time.DataBindings.Add("Text", ds_time, "Time.基本工時");
                label_time.DataBindings.Add("Text", ds_time, "Time.作業時間");
                label_last.DataBindings.Add("Text", ds, "Method" +label5.Text+".剩餘時間");
                label_worker.DataBindings.Add("Text", ds, "Method" + label5.Text + ".授權人員");

                bm_time = this.BindingContext[ds_time, "Time"];
                bm_method = this.BindingContext[ds, "Method" + label5.Text];
                
                //refresh_task();


                label_basic_time.DataBindings.Clear();
                label_time.DataBindings.Clear();
                label_last.DataBindings.Clear();
                label_worker.DataBindings.Clear();
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_allo2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                db.Open();

               
                int time_consume = int.Parse(label_basic_time.Text) + int.Parse(label_time.Text) * int.Parse(label3.Text);
                int time_last = int.Parse(label_last.Text);
                time_last -= time_consume;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "UPDATE Method" + label5.Text + " SET 剩餘時間 = " + time_last + " WHERE 授權人員 = N'" + label_worker.Text + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "UPDATE 專案 SET 分析人員 = N'" + label_worker.Text + "' WHERE 專案編號 = '" + label2.Text + "' AND 檢測項目 = N'" + label1.Text + "'";
                cmd.ExecuteNonQuery();

                db.Close();
                refresh_task();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_allo3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                db.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Method" + label5.Text + " WHERE 就緒 = 1 AND " + label4.Text + "=1 ORDER BY 剩餘時間 DESC, 數量 ASC", db);
                //建立DataSet物件ds
                DataSet ds = new DataSet();
                //將da物件所取得的資料填入ds物件
                da.Fill(ds, "Method" + label5.Text);
                //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                //dataGridView2.DataSource = ds.Tables[0];
                dataGridView3.DataSource = ds;
                dataGridView3.DataMember = "Method" + label5.Text;

                SqlDataAdapter da_time = new SqlDataAdapter("SELECT * FROM Time WHERE 分析編號 = '" + label4.Text + "'", db);
                DataSet ds_time = new DataSet();
                da_time.Fill(ds_time, "Time");
                dataGridView_time.DataSource = ds_time;
                dataGridView_time.DataMember = "Time";

                BindingManagerBase bm_time, bm_method;

                label_basic_time.DataBindings.Add("Text", ds_time, "Time.基本工時");
                label_time.DataBindings.Add("Text", ds_time, "Time.作業時間");
                label_last.DataBindings.Add("Text", ds, "Method" + label5.Text + ".剩餘時間");
                label_worker.DataBindings.Add("Text", ds, "Method" + label5.Text + ".授權人員");

                bm_time = this.BindingContext[ds_time, "Time"];
                bm_method = this.BindingContext[ds, "Method" + label5.Text];

                //refresh_task();
                int time_consume = int.Parse(label_basic_time.Text) + int.Parse(label_time.Text) * int.Parse(label3.Text);
                int time_last = int.Parse(label_last.Text);
                while (time_last <= 0 && bm_method.Position <= bm_method.Count)
                {
                    bm_method.Position++;
                    time_last = int.Parse(label_last.Text);
                }
                if (time_last >= time_consume) time_last -= time_consume;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "UPDATE Method" + label5.Text + " SET 剩餘時間 = " + time_last + " WHERE 授權人員 = N'" + label_worker.Text + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "UPDATE 專案 SET 分析人員 = N'" + label_worker.Text + "' WHERE 專案編號 = '" + label2 + "', 檢測項目 = N'" + label1.Text + "'";
                cmd.ExecuteNonQuery();


                label_basic_time.DataBindings.Clear();
                label_time.DataBindings.Clear();
                label_last.DataBindings.Clear();
                label_worker.DataBindings.Clear();
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
