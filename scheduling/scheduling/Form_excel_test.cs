using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.IO;
using System.Data.SqlClient;

namespace scheduling
{
    public partial class Form_excel_test : Form
    {

        public string refresh_string = "SELECT 專案編號,分析方法,數量,人員,日期 FROM 測試 ORDER BY 分析方法 ASC";

        public Form_excel_test()
        {
            InitializeComponent();
        }

        private void Form_excel_test_Load(object sender, EventArgs e)
        {
            refresh_task();
        }

        private void refresh_task()
        {
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\college\111-2\project\code\scheduling\scheduling\scheduling\tasks_database.mdf;Integrated Security=True
            //建立SqlConnection物件db
            
            SqlConnection db4 = new SqlConnection();
            db4.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|tasks_database.mdf;Integrated Security=True";
            db4.Open();
            SqlDataAdapter da4 = new SqlDataAdapter(refresh_string, db4);

            DataSet ds4 = new DataSet();
            da4.Fill(ds4, "測試");
            dataGridView1.DataSource = ds4;
            dataGridView1.DataMember = "測試";
            db4.Close();
            
        }
        private void add_sql(string task_no, string method, string num, string worker, string date)
        {
            try
            {//,天數,檢測項目/設備名稱,分析方法,數量,課別,案件負責人
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|tasks_database.mdf;Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                //cmd.CommandText = "SELECT MAX(Id) FROM 專案";
                cmd.CommandText = "INSERT INTO 測試(專案編號,分析方法,數量,人員,日期)VALUES('" +
                    task_no + "','" +     //// 雙引號取代單引號
                    method + "','" +
                    num + "',N'" +
                    worker + "','"+
                    date+"')";
                cmd.ExecuteNonQuery();
                db.Close();
                //Form_main_Load(sender, e);
                refresh_task();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void delete_all()
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|tasks_database.mdf;Integrated Security=True";
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "DELETE FROM 測試";
                cmd.ExecuteNonQuery();
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refresh_task();
        }
        private void ReadExcelFile(string filePath)
        {
            Excel.Application excelApp = new Excel.Application();
            //Application excel = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;
            Excel.Range range = null;
            //dynamic sheet = null;
            delete_all();
            try
            {
                workbook = excelApp.Workbooks.Open(filePath);
                worksheet = workbook.Sheets[1]; // Assuming the data is in the first sheet

                range = worksheet.UsedRange;
                int rowCount = range.Rows.Count;
                int colCount = range.Columns.Count;
                string task_no = "";
                string method = "";
                string num = "";
                string worker = "";
                string date = "";
                label6.Text = rowCount.ToString();
                for (int i = 9530; i <= 9927; i++)
                {
                    label6.Text = "" + i;
                    //for (int j = 1; j <= colCount; j++)
                    //{
                        /*
                        if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                        {
                            string cellValue = range.Cells[i, j].Value2.ToString();
                            Console.WriteLine("Cell({0},{1}): {2}", i, j, cellValue);
                        }
                        */
                    if(range.Cells[i,15].Value2 == null && range.Cells[i, 6].Value2 == null && range.Cells[i, 16].Value2 == null && range.Cells[i, 11].Value2 == null && range.Cells[i, 12].Value2 == null)
                    {
                        break;
                    }
                    if (range.Cells[i, 15] != null && range.Cells[i, 15].Value2 != null)
                    {
                        //人員
                        if (range.Cells[i, 15].Value2.ToString() == textBox1.Text)
                        {
                            //label1.Text = range.Cells[i, 15].Value2.ToString();
                        }
                        else
                        {
                            ///continue;
                        }
                        label1.Text = range.Cells[i, 15].Value2.ToString();
                        worker = label1.Text;
                    }

                    if (range.Cells[i, 16] != null && range.Cells[i, 16].Value2 != null)
                    {
                        //日期
                        //get date
                        double date_temp = (double)range.Cells[i, 16].Value2;
                        DateTime temp = DateTime.FromOADate(date_temp);
                        int day_compare_value = DateTime.Compare(temp, dateTimePicker1.Value.AddDays(-1));
                        int day_compare_value2 = DateTime.Compare(temp, dateTimePicker1.Value.AddDays(6));
                        if (day_compare_value >= 0 && day_compare_value2 < 0)
                        {
                            label2.Text = temp.ToString();
                            date = temp.ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (range.Cells[i, 6] != null && range.Cells[i, 6].Value2 != null)
                    {
                        //專案編號
                        task_no = range.Cells[i, 6].Value2.ToString();
                        label3.Text = range.Cells[i, 6].Value2.ToString();
                    }
                    if (range.Cells[i, 11] != null && range.Cells[i, 11].Value2 != null)
                    {
                        //方法
                        method = range.Cells[i, 11].Value2.ToString();
                        label4.Text = range.Cells[i, 11].Value2.ToString();
                    }
                    if (range.Cells[i, 12] != null && range.Cells[i, 12].Value2 != null)
                    {
                        //數量
                        num = range.Cells[i, 12].Value2.ToString();
                        label5.Text = range.Cells[i, 12].Value2.ToString();
                    }
                    
                    add_sql(task_no, method, num, worker, date);
                    //}
                }
                
                //label1.Text = range.Cells[7, 16].Value2.ToString();
                /*
                //get date
                double date_temp = (double)range.Cells[7, 16].Value2;
                DateTime temp = DateTime.FromOADate(date_temp);
                int day_compare_value = DateTime.Compare(temp, dateTimePicker1.Value);
                if(day_compare_value < 0)
                {
                   label2.Text = "early";
                }
                else
                {
                   label2.Text = "late";
                }
                */
                //workbook.Close();
                //excelApp.Quit();
            }
            catch
            {
                //excelApp.Quit();
            }
            finally
            {
                //注意: Excel是Unmanaged程式，要妥善結束才能乾淨不留痕跡
                //否則，很容易留下一堆excel.exe在記憶體中
                //所有用過的COM+物件都要使用Marshal.FinalReleaseComObject清掉
                //COM+物件的Reference Counter，以利結束物件回收記憶體
                /*
                if (range != null)
                {
                    Marshal.FinalReleaseComObject(range);
                }
                if (worksheet != null)
                {
                    Marshal.FinalReleaseComObject(worksheet);
                }
                if (workbook != null)
                {
                    workbook.Close(false); //忽略尚未存檔內容，避免跳出提示卡住
                    Marshal.FinalReleaseComObject(workbook);
                }
                */
                if (excelApp != null)
                {
                    excelApp.Workbooks.Close();
                    excelApp.Quit();
                    {             // Store all running process in the system             
                        Process[]  runingProcess= Process.GetProcesses();
                        for (int i=0; i<runingProcess.Length; i++){
                            // compare equivalent process by their name                 
                            if (runingProcess[i].ProcessName=="EXCEL") {
                             //kill  running process                    
                                runingProcess[i].Kill();
                                //break;
                            }
                            try
                            {
                                //Pass the filepath and filename to the StreamWriter Constructor
                                //Write a line of text
                                string ppath = @"Test.txt";
                                if (!File.Exists(ppath))
                                {
                                    // Create a file to write to.
                                    using (StreamWriter sw = File.CreateText(ppath))
                                    {
                                        //sw.WriteLine("Hello");
                                        //sw.WriteLine("And");
                                        //sw.WriteLine("Welcome");
                                    }
                                }

                                // This text is always added, making the file longer over time
                                // if it is not deleted.
                                using (StreamWriter sw = File.AppendText(ppath))
                                {
                                    sw.WriteLine(runingProcess[i].ProcessName);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Exception: " + e.Message);
                            }
                            
                        }
                    }
                    Marshal.FinalReleaseComObject(excelApp);
                    
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"..\test.xlsx";
            string path = System.IO.Path.GetFullPath(filePath);
            ReadExcelFile(path);
        }
    }
}
