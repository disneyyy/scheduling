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
    public partial class Form_add_task : Form
    {
        public Form_add_task()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            Form_main f = (Form_main)this.Owner;
            f.Controls["textBox_refresh"].Text = "11";
            f.Controls["textBox_refresh"].Text = "";
        }
        private void button_yes_Click(object sender, EventArgs e)
        {
            try
            {//,天數,檢測項目/設備名稱,分析方法,數量,課別,案件負責人
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|tasks_database.mdf;Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                //cmd.CommandText = "SELECT MAX(Id) FROM 專案";
                cmd.CommandText = "INSERT INTO 專案(專案編號,採樣日期起,委託單報告日期,天數,檢測項目,分析方法,數量,課別,案件負責人)VALUES('" +
                    textBox_task_num.Text + "','" +     //// 雙引號取代單引號
                    dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" +
                    dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'," +
                    textBox_count.Text + ",N'" +
                    textBox_object.Text + "','" +
                    textBox_method.Text + "'," +
                    textBox_count.Text + ",N'" +
                    comboBox_class.Text + "',N'" +
                    textBox_staff.Text +
                    "')";
                cmd.ExecuteNonQuery();
                db.Close();
                //Form_main_Load(sender, e);
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void Form_add_task_Load(object sender, EventArgs e)
        {
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
