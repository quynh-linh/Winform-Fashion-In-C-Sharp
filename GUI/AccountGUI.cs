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
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using static Guna.UI2.Native.WinApi;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class AccountGUI : Form
    {
        private int currentIndex = 0;
        private AccountBUS accountBUS = new AccountBUS();
        public AccountGUI( string role_Manipulative)
        {
            InitializeComponent();
            if (!role_Manipulative.Equals("Được thay đổi"))
            {
                guna2Button1.Enabled = false;
                guna2Button4.Enabled = false;
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
            AccountDTO accountDTO = null;
            AccountAddOrUpdateGUI accountAddOrUpdateGUI = null;
            Console.WriteLine(currentIndex);
            if (currentIndex >= 0) {
                accountDTO = new AccountDTO(Int32.Parse(dataGridViewAccount.Rows[currentIndex].Cells[0].Value.ToString()), dataGridViewAccount.Rows[currentIndex].Cells[1].Value.ToString(), dataGridViewAccount.Rows[currentIndex].Cells[2].Value.ToString(), dataGridViewAccount.Rows[currentIndex].Cells[4].Value.ToString(), dataGridViewAccount.Rows[currentIndex].Cells[3].Value.ToString(), dataGridViewAccount.Rows[currentIndex].Cells[5].Value.ToString());
                 accountAddOrUpdateGUI = new AccountAddOrUpdateGUI("Update", accountDTO);
            }
            else {
                accountDTO = new AccountDTO();
                 accountAddOrUpdateGUI = new AccountAddOrUpdateGUI("Add", accountDTO);
            }
            accountAddOrUpdateGUI.Show();
        }

        private void AccountGUI_Load(object sender, EventArgs e)
        {
            dataGridViewAccount.DataSource = accountBUS.getAllAccount();
        }

        private void dataGridViewAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = e.RowIndex;
            Console.WriteLine(currentIndex);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click_1(object sender, EventArgs e) {
            SaveFileDialog saved = new SaveFileDialog();
            saved.Title = "Xuất -->> - - - ->";
            saved.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if(saved.ShowDialog() == DialogResult.OK) {
                try {
                    exportExcel(saved.FileName, dataGridViewAccount,"Excel Tài Khoản","Tài Khoản");
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
                    System.Data.DataTable dataTable = importExcel(opened.FileName);
                    accountBUS.insertAccounts(dataTable);
                    MessageBox.Show("nhập thành công <3");
                }
                catch (FormatException ex1) {
                    MessageBox.Show("ID không đúng định dạng (int) thay vì (string)");
                }
                catch (ApplicationException ex2) {
                    MessageBox.Show(ex2.Message);
                }
                catch (ArgumentException ex3) {
                    MessageBox.Show("Định dạng cột không đúng");
                }
                finally {
                    System.Data.DataTable dataTable2 = accountBUS.getAllAccount();
                    dataGridViewAccount.DataSource = dataTable2;
                }
            }
        }

        public static void exportExcel(string exportUrl, DataGridView dataGridView, String title = "Nhập và xuất excel", String sheetName = "Lập trình C#") {
            Excel.Application application = new Excel.Application();
            //Tạo mới một Excel WorkBook 
            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            application.Visible = true;

            application.DisplayAlerts = false;

            application.Application.SheetsInNewWorkbook = 1;

            oBooks = application.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(application.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.Range[oSheet.Cells[1, 1], oSheet.Cells[1, dataGridView.Columns.Count]]; ;

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // create header rows 
            for (int i = 0; i < dataGridView.Columns.Count; i++) {
                oSheet.Cells[2, i + 1] = dataGridView.Columns[i].HeaderText;
            }
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.Range[oSheet.Cells[2,1], oSheet.Cells[2, dataGridView.Columns.Count]];
                
            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // insert rows
            for (int i = 0; i < dataGridView.Rows.Count; i++) {
                for (int j = 0; j < dataGridView.Columns.Count; j++) {
                    oSheet.Cells[i + 3, j + 1] = dataGridView.Rows[i].Cells[j].Value;
                }
            }

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[1, 1];
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[dataGridView.Rows.Count+1, dataGridView.Columns.Count];

            // kẻ viền
            oSheet.get_Range(c1, c2).Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;


            oSheet.Rows.AutoFit();
            oSheet.Columns.AutoFit();
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
        public static System.Data.DataTable importExcel(string importUrl) {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(importUrl))) {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                System.Data.DataTable dataTable = new System.Data.DataTable();
                for (int i = worksheet.Dimension.Start.Column; i <= worksheet.Dimension.End.Column; i++) {
                    dataTable.Columns.Add(worksheet.Cells[2, i].Value.ToString());
                }
                for (int i = (worksheet.Dimension.Start.Row + 2); i <= worksheet.Dimension.End.Row; i++) {
                    List<string> rows = new List<string>();
                    for (int j = worksheet.Dimension.Start.Column; j <= worksheet.Dimension.End.Column; j++) {
                        rows.Add(worksheet.Cells[i, j].Value.ToString());
                    }
                    dataTable.Rows.Add(rows.ToArray());
                }
                return dataTable;
            }
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e) {
            List<AccountDTO> accounts = accountBUS.getAllAccountBySearchKey(searchAccount.Text);
            dataGridViewAccount.DataSource = accounts;
        }
    }
}
