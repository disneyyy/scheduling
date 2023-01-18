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
        private void refresh_test()
        {
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True
            //建立SqlConnection物件db
            SqlConnection db = new SqlConnection();
            //設定db連接ch15DB資料庫檔案
            db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
            //建立DataAdapter物件da
            //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM 測試", db);
            //建立DataSet物件ds
            DataSet ds = new DataSet();
            //將da物件所取得的資料填入ds物件
            da.Fill(ds);
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            dataGridView2.DataSource = ds.Tables[0];
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM 專案", db);
            //建立DataSet物件ds
            DataSet ds = new DataSet();
            //將da物件所取得的資料填入ds物件
            da.Fill(ds);
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Form_main_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'tasks_databaseDataSet9.專案' 資料表。您可以視需要進行移動或移除。
            this.專案TableAdapter2.Fill(this.tasks_databaseDataSet9.專案);
            // TODO: 這行程式碼會將資料載入 'tasks_databaseDataSet5.專案' 資料表。您可以視需要進行移動或移除。
            //this.專案TableAdapter1.Fill(this.tasks_databaseDataSet5.專案);
            // TODO: 這行程式碼會將資料載入 'tasks_databaseDataSet3.測試' 資料表。您可以視需要進行移動或移除。
            this.測試TableAdapter.Fill(this.tasks_databaseDataSet3.測試);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "INSERT INTO 測試(Id,name,date)VALUES(33,'mike','"+date_test+"')";
                cmd.ExecuteNonQuery();
                db.Close();
                refresh_test();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "DELETE FROM 測試 WHERE Id = 33";
                cmd.ExecuteNonQuery();
                db.Close();
                refresh_test();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date_test = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            label1.Text = date_test;
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
                refresh_test();
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
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "UPDATE 專案" + " SET 數量 " + "= 14 WHERE 檢測項目 = N'氨氮'";
                cmd.ExecuteNonQuery();
                db.Close();
                refresh_task();
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
    }
}
