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
        public Form_main()
        {
            InitializeComponent();
        }

        private void button_add_task_Click(object sender, EventArgs e)
        {

            Form_add_task add_task = new Form_add_task();
            add_task.Show();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'tasks_databaseDataSet.Table' 資料表。您可以視需要進行移動或移除。
            this.tableTableAdapter.Fill(this.tasks_databaseDataSet.Table);
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True
            //建立SqlConnection物件db
            SqlConnection db = new SqlConnection();
            //設定db連接ch15DB資料庫檔案
            db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
            //建立DataAdapter物件da
            //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM 專案編號", db);
            //建立DataSet物件ds
            DataSet ds = new DataSet();
            //將da物件所取得的資料填入ds物件
            da.Fill(ds);
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
