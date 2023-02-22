using System;
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
        public string refresh_string = "SELECT 專案編號,採樣日期起,委託單報告日期,檢測項目,分析方法,數量,課別,案件負責人,分析人員,分析日期,單日累積工時 FROM 專案 ORDER BY case when 分析日期 is null then 1 else 0 end asc, 分析日期 asc, 分析人員 , 單日累積工時, 委託單報告日期, 專案編號, 檢測項目 ASC";
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
            /*
            SqlConnection db = new SqlConnection();
            //設定db連接ch15DB資料庫檔案
            db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
            //建立DataAdapter物件da
            //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
            SqlDataAdapter da = new SqlDataAdapter(refresh_string, db);
            //建立DataSet物件ds
            DataSet ds = new DataSet();
            //將da物件所取得的資料填入ds物件
            da.Fill(ds);
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            dataGridView1.DataSource = ds.Tables[0];
            */
            SqlConnection db4 = new SqlConnection();
            db4.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
            db4.Open();
            //SqlDataAdapter da2 = new SqlDataAdapter("SELECT 授權人員 FROM " + selected, db4);
            SqlDataAdapter da4 = new SqlDataAdapter(refresh_string, db4);
            //建立DataSet物件ds
            /*
            DataSet ds2 = new DataSet();
            //將da物件所取得的資料填入ds物件
            da2.Fill(ds2, selected);
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            //dataGridView2.DataSource = ds.Tables[0];
            comboBox1.DataSource = ds2;
            //comboBox1.DisplayMember = selected;
            */

            DataSet ds4 = new DataSet();
            //將da物件所取得的資料填入ds物件
            da4.Fill(ds4, "專案");
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            //dataGridView2.DataSource = ds.Tables[0];
            dataGridView1.DataSource = ds4;
            dataGridView1.DataMember = "專案";
            db4.Close();
        }
        private void Form_main_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'tasks_databaseDataSet16.專案' 資料表。您可以視需要進行移動或移除。
            this.專案TableAdapter4.Fill(this.tasks_databaseDataSet16.專案);
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


        private void button_method_Click(object sender, EventArgs e)
        {
            Form_method manage_method = new Form_method();
            manage_method.Show();
        }
        public void reset_work_time()
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "UPDATE " + "Method有機" + " SET 累積時間 = 0";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "UPDATE " + "Method無機" + " SET 累積時間 = 0";
                cmd.ExecuteNonQuery();
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            reset_work_time();
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "UPDATE " + "專案" + " SET 分析人員 = NULL";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "UPDATE " + "專案" + " SET 分析日期 = NULL";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "UPDATE " + "專案" + " SET 單日累積工時 = NULL";
                cmd.ExecuteNonQuery();
                db.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refresh_task();
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
            label_task_id.DataBindings.Add("Text", ds, "專案.專案編號");
            label_count.DataBindings.Add("Text", ds, "專案.數量");
            label_method.DataBindings.Add("Text", ds, "專案.分析方法");
            label_class.DataBindings.Add("Text", ds, "專案.課別");
            label_test_obj.DataBindings.Add("Text", ds, "專案.檢測項目");
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
            label_task_id.DataBindings.Clear();
            label_count.DataBindings.Clear();
            label_method.DataBindings.Clear();
            label_class.DataBindings.Clear();
            label_test_obj.DataBindings.Clear();

            //button_allo_Click(sender, e);
            //button_allo2_Click(sender, e);
        }

        private void button_allo_Click(object sender, EventArgs e)
        {
            //label4:分析方法
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                db.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Method" + label_class.Text + " WHERE 就緒 = 1 AND " + label_method.Text +"=1 ORDER BY 累積時間 ASC, 數量 ASC", db);
                //建立DataSet物件ds
                DataSet ds = new DataSet();
                //將da物件所取得的資料填入ds物件
                da.Fill(ds, "Method" + label_class.Text);
                //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                //dataGridView2.DataSource = ds.Tables[0];
                dataGridView3.DataSource = ds;
                dataGridView3.DataMember = "Method" + label_class.Text;

                SqlDataAdapter da_time = new SqlDataAdapter("SELECT * FROM Time WHERE 分析編號 = '" + label_method.Text + "'", db);
                DataSet ds_time = new DataSet();
                da_time.Fill(ds_time, "Time");
                dataGridView_time.DataSource = ds_time;
                dataGridView_time.DataMember = "Time";

                BindingManagerBase bm_time, bm_method;

                label_basic_time.DataBindings.Add("Text", ds_time, "Time.基本工時");
                label_time.DataBindings.Add("Text", ds_time, "Time.作業時間");
                label_last.DataBindings.Add("Text", ds, "Method" +label_class.Text+".累積時間");
                label_worker.DataBindings.Add("Text", ds, "Method" + label_class.Text + ".授權人員");

                bm_time = this.BindingContext[ds_time, "Time"];
                bm_method = this.BindingContext[ds, "Method" + label_class.Text];

                if (bm_method.Count == 0) label_worker.Text = "0";
                if (bm_time.Count == 0) label_basic_time.Text = "-1";
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
                if(label_worker.Text != "0")
                {
                    int time_consume = int.Parse(label_basic_time.Text) + int.Parse(label_time.Text) * int.Parse(label_count.Text);
                    int time_last = int.Parse(label_last.Text);
                    time_last += time_consume;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = db;
                    cmd.CommandText = "UPDATE Method" + label_class.Text + " SET 累積時間 = " + time_last + " WHERE 授權人員 = N'" + label_worker.Text + "'";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE 專案 SET 分析人員 = N'" + label_worker.Text + "',分析日期 = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' WHERE 專案編號 = '" + label_task_id.Text + "' AND 檢測項目 = N'" + label_test_obj.Text + "'";
                    cmd.ExecuteNonQuery();
                    //cmd.CommandText = "UPDATE 專案 SET 分析日期 = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00.000' WHERE 專案編號 = '" + label_task_id.Text + "' AND 檢測項目 = N'" + label_test_obj.Text + "'";
                    //cmd.ExecuteNonQuery();
                }
                db.Close();
                refresh_task();
                int temp = int.Parse(textBox1.Text) + 1;
                textBox1.Text = "" + temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void binding_clear()
        {
            label_task_id.DataBindings.Clear();
            label_count.DataBindings.Clear();
            label_method.DataBindings.Clear();
            label_class.DataBindings.Clear();
            label_test_obj.DataBindings.Clear();
            label_anal_date.DataBindings.Clear();
        }
        private void button_allo3_Click(object sender, EventArgs e)
        {
            reset_work_time();
            BindingManagerBase bm;
            SqlConnection db = new SqlConnection();
            db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
            DataSet ds = new DataSet();
            SqlDataAdapter daProduct = new SqlDataAdapter(refresh_string, db);
            daProduct.Fill(ds, "專案");
            //https://msdn.microsoft.com/zh-tw/library/system.windows.forms.controlbindingscollection(v=vs.110).aspx
            label_task_id.DataBindings.Add("Text", ds, "專案.專案編號");
            label_count.DataBindings.Add("Text", ds, "專案.數量");
            label_method.DataBindings.Add("Text", ds, "專案.分析方法");
            label_class.DataBindings.Add("Text", ds, "專案.課別");
            label_test_obj.DataBindings.Add("Text", ds, "專案.檢測項目");
            label_anal_date.DataBindings.Add("Text", ds, "專案.分析日期");
            bm = this.BindingContext[ds, "專案"];
            db.Close();
            bm.Position = bm.Count;
            if (label_anal_date.Text != "")
            {
                binding_clear();
                return;
            }
            else
            {
                bm.Position = 0;
            }
            
            while (label_anal_date.Text != "")
            {
                bm.Position++;
                if (label_anal_date.Text == dateTimePicker1.Value.ToString("yyyy/M/dd") + " 上午 12:00:00")
                {
                    binding_clear();
                    return;
                }
                    
            }
            string DB_text = "";
            if (radioButton_average.Checked)
            {
                DB_text = "ORDER BY 數量 ASC, 累積時間 ASC";
            }
            else
            {
                DB_text = "ORDER BY 數量 ASC, 累積時間 DESC";
            }

            for (int i = bm.Position; i < bm.Count; i++)
            {
                try
                {
                    bm.Position = i;
                    SqlConnection db2 = new SqlConnection();
                    db2.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                    db2.Open();

                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Method" + label_class.Text + " WHERE 就緒 = 1 AND " + label_method.Text + "=1 AND 累積時間 < 480 " + DB_text, db2);
                    //建立DataSet物件ds
                    DataSet ds2 = new DataSet();
                    //將da物件所取得的資料填入ds物件
                    da.Fill(ds2, "Method" + label_class.Text);
                    //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                    //dataGridView2.DataSource = ds.Tables[0];
                    dataGridView3.DataSource = ds2;
                    dataGridView3.DataMember = "Method" + label_class.Text;

                    SqlDataAdapter da_time = new SqlDataAdapter("SELECT * FROM Time WHERE 分析編號 = '" + label_method.Text + "'", db2);
                    DataSet ds_time = new DataSet();
                    da_time.Fill(ds_time, "Time");
                    dataGridView_time.DataSource = ds_time;
                    dataGridView_time.DataMember = "Time";

                    BindingManagerBase bm_time, bm_method;

                    label_basic_time.DataBindings.Add("Text", ds_time, "Time.基本工時");
                    label_time.DataBindings.Add("Text", ds_time, "Time.作業時間");
                    label_last.DataBindings.Add("Text", ds2, "Method" + label_class.Text + ".累積時間");
                    label_worker.DataBindings.Add("Text", ds2, "Method" + label_class.Text + ".授權人員");

                    bm_time = this.BindingContext[ds_time, "Time"];
                    bm_method = this.BindingContext[ds2, "Method" + label_class.Text];

                    if (bm_method.Count == 0) label_worker.Text = "0";
                    if (bm_time.Count == 0) label_basic_time.Text = "-1";
                    //refresh_task();


                    



                    SqlConnection db3 = new SqlConnection();
                    db3.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                    db3.Open();
                    if (label_worker.Text != "0" && int.Parse(label_basic_time.Text) >= 0)
                    {
                        int time_consume = int.Parse(label_basic_time.Text) + int.Parse(label_time.Text) * int.Parse(label_count.Text);
                        int time_last = int.Parse(label_last.Text);
                        if(time_last + time_consume <= 600)
                        {
                            time_last += time_consume;
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = db3;
                            cmd.CommandText = "UPDATE Method" + label_class.Text + " SET 累積時間 = " + time_last + " WHERE 授權人員 = N'" + label_worker.Text + "'";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = "UPDATE 專案 SET 分析人員 = N'" + label_worker.Text + "',分析日期 = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' ,單日累積工時 = " + time_last +" WHERE 專案編號 = '" + label_task_id.Text + "' AND 檢測項目 = N'" + label_test_obj.Text + "'";
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            if(bm_method.Position <= bm_method.Count)
                            {
                                bm_method.Position++;
                            }
                        }
                    }
                    label_basic_time.DataBindings.Clear();
                    label_time.DataBindings.Clear();
                    label_last.DataBindings.Clear();
                    label_worker.DataBindings.Clear();
                    db2.Close();
                    db3.Close();
                    refresh_task();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            binding_clear();

            SqlConnection db4 = new SqlConnection();
            db4.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
            db4.Open();
            SqlDataAdapter da3 = new SqlDataAdapter(refresh_string, db4);
            //建立DataSet物件ds
            DataSet ds3 = new DataSet();
            //將da物件所取得的資料填入ds物件
            da3.Fill(ds3, "專案");
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            //dataGridView2.DataSource = ds.Tables[0];
            dataGridView1.DataSource = ds3;
            dataGridView1.DataMember = "專案";
            db4.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
