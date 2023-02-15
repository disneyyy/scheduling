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
    public partial class Form_method : Form
    {
        BindingManagerBase bm_yo;
        BindingManagerBase bm_wu;
        public string selected = "Method有機";
        public Form_method()
        {
            InitializeComponent();
            selected = "Method無機";
            refresh();
            SqlConnection db = new SqlConnection();
            db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
            DataSet ds = new DataSet();
            SqlDataAdapter daProduct = new SqlDataAdapter("SELECT * FROM " + selected + " ORDER BY 數量 ASC", db);
            daProduct.Fill(ds, selected);
            //https://msdn.microsoft.com/zh-tw/library/system.windows.forms.controlbindingscollection(v=vs.110).aspx
            label_wu.DataBindings.Add("Text", ds, selected + ".數量");
            label_getname_wu.DataBindings.Add("Text", ds, selected + ".授權人員");
            bm_wu = this.BindingContext[ds, selected];
            bm_wu.Position = bm_wu.Count;

            db.Close();
            selected = "Method有機";
            refresh();
            SqlConnection db2 = new SqlConnection();
            db2.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
            DataSet ds2 = new DataSet();
            SqlDataAdapter daProduct2 = new SqlDataAdapter("SELECT * FROM " + selected + " ORDER BY 數量 ASC", db2);
            daProduct.Fill(ds2, selected);
            //https://msdn.microsoft.com/zh-tw/library/system.windows.forms.controlbindingscollection(v=vs.110).aspx
            label_yo.DataBindings.Add("Text", ds2, selected + ".數量");
            label_getname_yo.DataBindings.Add("Text", ds2, selected + ".授權人員");
            bm_yo = this.BindingContext[ds2, selected];
            db2.Close();
            refresh2();
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + selected + " ORDER BY 數量 ASC", db);
            //建立DataSet物件ds
            DataSet ds = new DataSet();
            //將da物件所取得的資料填入ds物件
            da.Fill(ds);
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            if(selected == "Method有機")
            {
                comboBox_yo.DataSource = ds.Tables[0];
            }
            else
            {
                comboBox_wu.DataSource = ds.Tables[0];
            }
            db.Close();
            
        }

        private void refresh2()
        {
            SqlConnection db4 = new SqlConnection();
            db4.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
            db4.Open();
            //SqlDataAdapter da2 = new SqlDataAdapter("SELECT 授權人員 FROM " + selected, db4);
            SqlDataAdapter da3 = new SqlDataAdapter("SELECT * FROM " + selected + " ORDER BY 數量 ASC", db4);
            SqlDataAdapter da4 = new SqlDataAdapter("SELECT 授權人員,就緒,數量,累積時間 FROM " + selected + " ORDER BY 數量 ASC", db4);
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
            DataSet ds3 = new DataSet();
            //將da物件所取得的資料填入ds物件
            da3.Fill(ds3, selected);
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            //dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.DataSource = ds3;
            dataGridView2.DataMember = selected;

            DataSet ds4 = new DataSet();
            //將da物件所取得的資料填入ds物件
            da4.Fill(ds4, selected);
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            //dataGridView2.DataSource = ds.Tables[0];
            dataGridView1.DataSource = ds4;
            dataGridView1.DataMember = selected;
            db4.Close();
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
                cmd.CommandText = "INSERT INTO " + selected + "(授權人員)VALUES(N'" + textBox_name.Text + "')";
                cmd.ExecuteNonQuery();
                db.Close();
                refresh();
                refresh2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_method_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'tasks_databaseDataSet14.Method無機' 資料表。您可以視需要進行移動或移除。
            this.method無機TableAdapter2.Fill(this.tasks_databaseDataSet14.Method無機);
            // TODO: 這行程式碼會將資料載入 'tasks_databaseDataSet13.Method有機' 資料表。您可以視需要進行移動或移除。
            this.method有機TableAdapter3.Fill(this.tasks_databaseDataSet13.Method有機);
            // TODO: 這行程式碼會將資料載入 'tasks_databaseDataSet11.Method有機' 資料表。您可以視需要進行移動或移除。
            this.method有機TableAdapter2.Fill(this.tasks_databaseDataSet11.Method有機);
            // TODO: 這行程式碼會將資料載入 'tasks_databaseDataSet10.Method無機' 資料表。您可以視需要進行移動或移除。
            this.method無機TableAdapter1.Fill(this.tasks_databaseDataSet10.Method無機);
            // TODO: 這行程式碼會將資料載入 'tasks_databaseDataSet8.Method無機' 資料表。您可以視需要進行移動或移除。
            this.method無機TableAdapter.Fill(this.tasks_databaseDataSet8.Method無機);
            // TODO: 這行程式碼會將資料載入 'tasks_databaseDataSet7.Method有機' 資料表。您可以視需要進行移動或移除。
            this.method有機TableAdapter.Fill(this.tasks_databaseDataSet7.Method有機);

        }

        private void checkBox_yo_CheckStateChanged(object sender, EventArgs e)
        {
            if(radioButton_yo.Checked == true)
            {
                comboBox_wu.Visible = false;
                comboBox_me_wu.Visible = false;
                comboBox_yo.Visible = true;
                comboBox_me_yo.Visible = true;
                selected = "Method有機";
                refresh2();
            }
        }

        private void checkBox_wu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_wu.Checked == true)
            {
                comboBox_wu.Visible = true;
                comboBox_me_wu.Visible = true;
                comboBox_yo.Visible = false;
                comboBox_me_yo.Visible = false;
                selected = "Method無機";
                refresh2();
            }
            else
            {
                comboBox_wu.Visible = false;
                comboBox_me_wu.Visible = false;
                comboBox_yo.Visible = true;
                comboBox_me_yo.Visible = true;
                selected = "Method有機";
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
                cmd.CommandText = "TRUNCATE TABLE " + selected;
                cmd.ExecuteNonQuery();
                db.Close();
                refresh();
                refresh2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                cmd.CommandText = "UPDATE " + selected + " SET " + comboBox_me_wu.Text + " = 1";
                cmd.ExecuteNonQuery();
                db.Close();
                refresh();
                refresh2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button_add_me_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                /*
                if (checkBox_wu.Checked == true)
                {
                    
                    DataSet ds = new DataSet();
                    SqlDataAdapter daProduct = new SqlDataAdapter("SELECT * FROM " + selected + " ORDER BY 數量 ASC", db);
                    daProduct.Fill(ds, selected);
                    label_me.DataBindings.Clear();
                    label_me.DataBindings.Add("Text", ds, selected + "." + comboBox_me_wu.Text);
                    if(label_me.Text == "False")
                    {
                        for(bm_wu.Position = 0; bm_wu.Position <= bm_wu.Count; bm_wu.Position++)
                        {
                            if(label_getname_wu.Text == comboBox_wu.Text)
                            {
                                int temp = int.Parse(label_wu.Text);
                                temp++;
                                cmd.CommandText = "UPDATE " + selected + " SET " + comboBox_me_wu.Text + " = 1, 數量 = " + temp + " WHERE 授權人員 = N'" + comboBox_wu.Text + "'";
                                break;
                            }
                        }
                    }
                    else
                    {
                        cmd.CommandText = "UPDATE " + selected + " SET " + comboBox_me_wu.Text + " = 1 WHERE 授權人員 = N'" + comboBox_wu.Text + "'";
                    }
                    
                }
                else
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter daProduct = new SqlDataAdapter("SELECT * FROM " + selected + " ORDER BY 數量 ASC", db);
                    daProduct.Fill(ds, selected);
                    label_me.DataBindings.Clear();
                    label_me.DataBindings.Add("Text", ds, selected + "." + comboBox_me_yo.Text);
                    if (label_me.Text == "False")
                    {
                        for (bm_yo.Position = 0; bm_yo.Position <= bm_yo.Count; bm_yo.Position++)
                        {
                            if (label_getname_yo.Text == comboBox_yo.Text)
                            {
                                int temp = int.Parse(label_yo.Text);
                                temp++;
                                cmd.CommandText = "UPDATE " + selected + " SET " + comboBox_me_yo.Text + " = 1, 數量 = " + temp + " WHERE 授權人員 = N'" + comboBox_yo.Text + "'";
                                break;
                            }
                        }
                    }
                    else
                    {
                        cmd.CommandText = "UPDATE " + selected + " SET " + comboBox_me_yo.Text + " = 1 WHERE 授權人員 = N'" + comboBox_yo.Text + "'";
                    }
                    
                }
                */
                if (radioButton_wu.Checked == true)
                {
                    cmd.CommandText = "UPDATE " + selected + " SET " + comboBox_me_wu.Text + " = 1 WHERE 授權人員 = N'" + comboBox_wu.Text + "'";
                }
                else
                {
                    cmd.CommandText = "UPDATE " + selected + " SET " + comboBox_me_yo.Text + " = 1 WHERE 授權人員 = N'" + comboBox_yo.Text + "'";
                }
                cmd.ExecuteNonQuery();

                

                db.Close();
                refresh();
                refresh2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_delete_me_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                /*
                if (checkBox_wu.Checked == true)
                {

                    DataSet ds = new DataSet();
                    SqlDataAdapter daProduct = new SqlDataAdapter("SELECT * FROM " + selected + " ORDER BY 數量 ASC", db);
                    daProduct.Fill(ds, selected);
                    label_me.DataBindings.Clear();
                    label_me.DataBindings.Add("Text", ds, selected + "." + comboBox_me_wu.Text);
                    if (label_me.Text != "False")
                    {
                        for (bm_wu.Position = 0; bm_wu.Position <= bm_wu.Count; bm_wu.Position++)
                        {
                            if (label_getname_wu.Text == comboBox_wu.Text)
                            {
                                int temp = int.Parse(label_wu.Text);
                                temp--;
                                cmd.CommandText = "UPDATE " + selected + " SET " + comboBox_me_wu.Text + " = 0, 數量 = " + temp + " WHERE 授權人員 = N'" + comboBox_wu.Text + "'";
                                break;
                            }
                        }
                    }
                    else
                    {
                        cmd.CommandText = "UPDATE " + selected + " SET " + comboBox_me_wu.Text + " = 0 WHERE 授權人員 = N'" + comboBox_wu.Text + "'";
                    }

                }
                else
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter daProduct = new SqlDataAdapter("SELECT * FROM " + selected + " ORDER BY 數量 ASC", db);
                    daProduct.Fill(ds, selected);
                    label_me.DataBindings.Clear();
                    label_me.DataBindings.Add("Text", ds, selected + "." + comboBox_me_yo.Text);
                    if (label_me.Text != "False")
                    {
                        for (bm_yo.Position = 0; bm_yo.Position <= bm_yo.Count; bm_yo.Position++)
                        {
                            if (label_getname_yo.Text == comboBox_yo.Text)
                            {
                                int temp = int.Parse(label_yo.Text);
                                temp--;
                                cmd.CommandText = "UPDATE " + selected + " SET " + comboBox_me_yo.Text + " = 0, 數量 = " + temp + " WHERE 授權人員 = N'" + comboBox_yo.Text + "'";
                                break;
                            }
                        }
                    }
                    else
                    {
                        cmd.CommandText = "UPDATE " + selected + " SET " + comboBox_me_yo.Text + " = 0 WHERE 授權人員 = N'" + comboBox_yo.Text + "'";
                    }

                }
                */
                if (radioButton_wu.Checked == true)
                {
                    cmd.CommandText = "UPDATE " + selected + " SET " + comboBox_me_wu.Text + " = 0 WHERE 授權人員 = N'" + comboBox_wu.Text + "'";
                }
                else
                {
                    cmd.CommandText = "UPDATE " + selected + " SET " + comboBox_me_yo.Text + " = 0 WHERE 授權人員 = N'" + comboBox_yo.Text + "'";
                }
                cmd.ExecuteNonQuery();
                db.Close();
                refresh();
                refresh2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                if (radioButton_wu.Checked == true)
                    cmd.CommandText = "UPDATE " + selected + " SET 數量 = " + textBox1.Text + "WHERE 授權人員 = N'" + comboBox_wu.Text + "'";
                else
                {
                    cmd.CommandText = "UPDATE " + selected + " SET 數量 = " + textBox1.Text + "WHERE 授權人員 = N'" + comboBox_yo.Text + "'";
                }
                cmd.ExecuteNonQuery();
                db.Close();
                refresh();
                refresh2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_ready_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                if (radioButton_wu.Checked == true)
                    cmd.CommandText = "UPDATE " + selected + " SET 就緒 = 1" + "WHERE 授權人員 = N'" + comboBox_wu.Text + "'";
                else
                {
                    cmd.CommandText = "UPDATE " + selected + " SET 就緒 = 1" + "WHERE 授權人員 = N'" + comboBox_yo.Text + "'";
                }
                cmd.ExecuteNonQuery();
                db.Close();
                refresh();
                refresh2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_not_ready_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                if (radioButton_wu.Checked == true)
                    cmd.CommandText = "UPDATE " + selected + " SET 就緒 = 0" + "WHERE 授權人員 = N'" + comboBox_wu.Text + "'";
                else
                {
                    cmd.CommandText = "UPDATE " + selected + " SET 就緒 = 0" + "WHERE 授權人員 = N'" + comboBox_yo.Text + "'";
                }
                cmd.ExecuteNonQuery();
                db.Close();
                refresh();
                refresh2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                if (radioButton_wu.Checked == true)
                    cmd.CommandText = "UPDATE " + selected + " SET 累積時間 = 0";
                else
                {
                    cmd.CommandText = "UPDATE " + selected + " SET 累積時間 = 0";
                }
                cmd.ExecuteNonQuery();
                db.Close();
                refresh();
                refresh2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
