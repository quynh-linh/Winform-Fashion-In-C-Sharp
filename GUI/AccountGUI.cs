using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using PdfSharp.Charting;

namespace GUI
{
    public partial class AccountGUI : Form
    {
        private AccountDTO accountDTO;
        private AccountBUS accountBUS = new AccountBUS();
        public AccountGUI( string role_Manipulative)
        {
            InitializeComponent();
            if (!role_Manipulative.Equals("Được thay đổi"))
            {
                guna2Button1.Enabled = false;
                guna2Button4.Enabled = false;
                guna2Button3.Enabled = false;
                guna2Button2.Enabled = false;
                guna2Button6.Enabled = false;
            }

        }



        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AccountAddOrUpdateGUI accountAddOrUpdateGUI = new AccountAddOrUpdateGUI("Add", null);
            accountAddOrUpdateGUI.Show();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AccountAddOrUpdateGUI accountAddOrUpdateGUI = new AccountAddOrUpdateGUI("Update", accountDTO);
            accountAddOrUpdateGUI.Show();
        }

        private void AccountGUI_Load(object sender, EventArgs e)
        {
            dataGridViewAccount.DataSource = accountBUS.getAllAccount();
            DataGridViewRow row = dataGridViewAccount.Rows[0];
            accountDTO = new AccountDTO(Int32.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[3].Value.ToString(),row.Cells[5].Value.ToString());
        }

        private void dataGridViewAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridViewAccount.Rows[rowIndex];
            accountDTO = new AccountDTO(Int32.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[5].Value.ToString());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void exportExcel(string exportUrl) {
            Excel.Application application =  new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);

            // create header rows 
            for (int i=0;i< dataGridViewAccount.Columns.Count; i++) {
                application.Cells[1, i + 1] = dataGridViewAccount.Columns[i].HeaderText;
            }
            // insert rows
            for (int i = 0; i < dataGridViewAccount.Rows.Count; i++) {
                for (int j = 0; j < dataGridViewAccount.Columns .Count; j++) {
                    application.Cells[i + 2, j + 1] = dataGridViewAccount.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(exportUrl);
            application.ActiveWorkbook.Saved = true;
        }
        private void importExcel(string importUrl) {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(importUrl))) {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                System.Data.DataTable dataTable = new System.Data.DataTable();
                for (int i = worksheet.Dimension.Start.Column;i<= worksheet.Dimension.End.Column;i++) {
                    dataTable.Columns.Add(worksheet.Cells[2, i].Value.ToString());
                }
                for(int i = (worksheet.Dimension.Start.Row + 1);i<= worksheet.Dimension.End.Row; i++) {
                    List<string> rows = new List<string>();
                    for (int j = worksheet.Dimension.Start.Column; j <= worksheet.Dimension.End.Column; j++) {
                        rows.Add(worksheet.Cells[i, j].Value.ToString());
                    }
                   dataTable.Rows.Add(rows.ToArray());
                }
                if (false) {
                    dataGridViewAccount.DataSource = dataTable;
                }
                else {
                    MessageBox.Show("conccac");
                }
            }

        }

        private void guna2Button6_Click_1(object sender, EventArgs e) {
            SaveFileDialog saved = new SaveFileDialog();
            saved.Title = "Xuất -->> - - - ->";
            saved.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if(saved.ShowDialog() == DialogResult.OK) {
                try {
                    exportExcel(saved.FileName);
                    MessageBox.Show("Xuất thành công <3");
                }catch(Exception ex) {
                    MessageBox.Show("Xuất thất bai :< Errors : "+ex.Message);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e) {
            OpenFileDialog opened = new OpenFileDialog();
            opened.Title = "Nhập -->> - - - ->";
            opened.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (opened.ShowDialog() == DialogResult.OK) {
                try {
                    importExcel(opened.FileName);
                    MessageBox.Show("nhập thành công <3");
                }
                catch (Exception ex) {
                    MessageBox.Show("nhập thất bai :< Errors : " + ex.Message);
                }
            }
        }
    }
}
