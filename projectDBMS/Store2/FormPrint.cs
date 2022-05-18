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
using System.Data.Sql;
using Ecl = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Reflection.Emit;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;
using GemBox.Pdf;
using GemBox.Pdf.Content;
using System.Printing;

namespace Store2
{
    public partial class FormPrint : Form
    {
        public FormPrint()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            InitializeComponent();
        }
        public string constring = @"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB2;Integrated Security=True";

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter =
                "XLS (*.xls)|*.xls|" +
                "XLT (*.xlt)|*.xlt|" +
                "XLSX (*.xlsx)|*.xlsx|" +
                "XLSM (*.xlsm)|*.xlsm|" +
                "XLTX (*.xltx)|*.xltx|" +
                "XLTM (*.xltm)|*.xltm|" +
                "ODS (*.ods)|*.ods|" +
                "OTS (*.ots)|*.ots|" +
                "CSV (*.csv)|*.csv|" +
                "TSV (*.tsv)|*.tsv|" +
                "HTML (*.html)|*.html|" +
                "MHTML (.mhtml)|*.mhtml|" +
                "PDF (*.pdf)|*.pdf|" +
                "XPS (*.xps)|*.xps|" +
                "BMP (*.bmp)|*.bmp|" +
                "GIF (*.gif)|*.gif|" +
                "JPEG (*.jpg)|*.jpg|" +
                "PNG (*.png)|*.png|" +
                "TIFF (*.tif)|*.tif|" +
                "WMP (*.wdp)|*.wdp";

            saveFileDialog.FilterIndex = 3;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("Sheet1");

                // From DataGridView to ExcelFile.
                DataGridViewConverter.ImportFromDataGridView(
                    worksheet,
                    this.dataGridView1,
                    new ImportFromDataGridViewOptions() { ColumnHeaders = true });

                workbook.Save(saveFileDialog.FileName);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {   //เมื่อกดปุ่มนี้จะโหลดข้อมูลที่เรากรอกไว้ในtextbox เข้าไปในdatagridview
            //ให้ join ข้อมูล เมื่อcheckbox มีหลายอัน

            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                string sql = textsqlcommand.Text;
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }
        private void textsqlcommand_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //เมื่อcheckให้โหลด employee ลงในdatagrid view
            if (checkBox1.Checked)
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SELECT Employee.PK_Employee_id,JobPosition.jobpositionName,Employee.employeeFName,Employee.employeeLName FROM Employee INNER JOIN JobPosition ON Employee.FK_JobPosition_id = JobPosition.PK_JobPosition_id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                    
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) 
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SELECT * FROM Product";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SELECT * FROM Members";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SELECT * FROM Invoice";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SELECT * FROM Receipt";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SELECT * FROM PurchaseRequisition";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox7.Checked)
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SELECT * FROM PurchaseOrder";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SELECT * FROM Claims";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SELECT * FROM Expenses";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SELECT * FROM Income";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SELECT * FROM Category";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox12.Checked)
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SELECT * FROM Category";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }
    }
}
///////////////////////////////////////////////////////////////
