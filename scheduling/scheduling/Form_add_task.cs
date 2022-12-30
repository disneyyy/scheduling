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

        private void button_yes_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|ch15DB.mdf;" +
                    "Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                //   cmd.CommandText = "INSERT INTO 員工(員工編號,姓名,職稱,薪資)VALUES('" +
                //        txtId.Text.Replace("'", "''") + "','" +     //// 雙引號取代單引號
                //       txtName.Text.Replace("'", "''") + "','" +
                //        txtP.Text.Replace("'", "''") + "'," +
                //       txtSalary.Text + ")";

                cmd.ExecuteNonQuery();
                db.Close();
                //Form_main_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
