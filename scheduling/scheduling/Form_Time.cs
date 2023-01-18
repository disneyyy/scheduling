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
    public partial class Form_Time : Form
    {
        public Form_Time()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True
            //建立SqlConnection物件db
            SqlConnection db = new SqlConnection();
            //設定db連接ch15DB資料庫檔案
            db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
            //建立DataAdapter物件da
            //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Time", db);
            //建立DataSet物件ds
            DataSet ds = new DataSet();
            //將da物件所取得的資料填入ds物件
            da.Fill(ds);
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Form_Time_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'tasks_databaseDataSet12.Time' 資料表。您可以視需要進行移動或移除。
            this.timeTableAdapter.Fill(this.tasks_databaseDataSet12.Time);

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "INSERT INTO Time(分析編號,基本工時,作業時間)VALUES('" + textBox_method.Text + "'," + textBox_basic.Text + "," + textBox_work.Text + ")";
                cmd.ExecuteNonQuery();
                db.Close();
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                cmd.CommandText = "DELETE FROM Time WHERE 分析編號 = '" + textBox_method.Text + "'";
                cmd.ExecuteNonQuery();
                db.Close();
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "UPDATE Time SET 基本工時 = " + textBox_basic.Text + ",作業時間 = " + textBox_work.Text + " WHERE 分析編號 = '" + textBox_method.Text + "'";
                cmd.ExecuteNonQuery();
                db.Close();
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
