using System;
using System.Collections;
using System.Drawing;

using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class BillGui : Form
    {
        string role_Manipulative;
        Bill_BUS bill_bus = new Bill_BUS();
        public BillGui(string role_Manipulative)
        {
            InitializeComponent();
            this.role_Manipulative = role_Manipulative;
            UC_Bill_ImportGui uC_Bill_ImportGui = new UC_Bill_ImportGui(role_Manipulative);
            //dataGridView12.ColumnHeadersVisible = false;

        }

        private void BillGui_Load(object sender, EventArgs e)
        {
            dataGridViewBill.DataSource = bill_bus.getBillExport();
            dgv_import_bill.DataSource = bill_bus.selectBillDetailImport();

        }
        // add detail export bill
        public void addItem(Bill_Detail_DTO data)
        {
            UC_Bill item = new UC_Bill(this);
            item.setDataBillDetall(data);
            //item.BackColor = Color.SteelBlue;
            flowLayoutPanelBill.Controls.Add(item);

        }
        // add detail import bill
        public void addItemImport(detail_importProductDTO data)
        {
            UC_Bill_import item = new UC_Bill_import(this);
            item.setDataBillDetallImport(data);
            flowLayoutPanelBillImport.Controls.Add(item);
            
        }
        private void dataGridViewBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double gia = 0;
            if (e.RowIndex != -1)
            {
                dataGridViewBill.CurrentCell.Selected = true;
                label_ma_bill.Text = dataGridViewBill.Rows[e.RowIndex].Cells["bill_Id"].FormattedValue.ToString();
                label_date_bill.Text = dataGridViewBill.Rows[e.RowIndex].Cells["bill_Time"].FormattedValue.ToString();
                label_staff_bill.Text = dataGridViewBill.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                gia = double.Parse(dataGridViewBill.Rows[e.RowIndex].Cells["bill_Total"].FormattedValue.ToString());
                label_total_bill.Text = gia.ToString("#,#,#") + "đ";
                label_customer_bill.Text = dataGridViewBill.Rows[e.RowIndex].Cells["namecustomer"].FormattedValue.ToString() ;

                ArrayList list = new ArrayList();
                flowLayoutPanelBill.Controls.Clear();
                list = bill_bus.getBillDetail(dataGridViewBill.Rows[e.RowIndex].Cells["bill_Id"].FormattedValue.ToString());
                //MessageBox.Show("hahahahaa" + ((Bill_Detail_DTO)list[0]));
                for (int i = 0; i < list.Count; i++)
                {
                    addItem((Bill_Detail_DTO)list[i]);
                    //MessageBox.Show("hahahahaa"+list[0].ToString());
                }
                    //dataGridView12.DataSource = bill_bus.selectBillDetail(dataGridViewBill.Rows[e.RowIndex].Cells["bill_Id"].FormattedValue.ToString());
            }
        }

        private void dgv_import_bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double gia = 0;
            if (e.RowIndex != -1)
            {
                dgv_import_bill.CurrentCell.Selected = true;
                label_ma_import.Text = dgv_import_bill.Rows[e.RowIndex].Cells["ma"].FormattedValue.ToString();
                label_time_import.Text = dgv_import_bill.Rows[e.RowIndex].Cells["date"].FormattedValue.ToString();
                label_ncc_import.Text = dgv_import_bill.Rows[e.RowIndex].Cells["namencc"].FormattedValue.ToString();
                gia = double.Parse(dgv_import_bill.Rows[e.RowIndex].Cells["tongtien"].FormattedValue.ToString());
                label_total_import.Text = gia.ToString("#,#,#") + "đ";
                ArrayList list = new ArrayList();
                flowLayoutPanelBillImport.Controls.Clear();
                list = bill_bus.getBillDetailImport(dgv_import_bill.Rows[e.RowIndex].Cells["ma"].FormattedValue.ToString());
                for(int i = 0; i < list.Count; i++)
                {
                    addItemImport((detail_importProductDTO)list[i]);
                }
            }
        }

        private void DateTimePicker_search_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker_search.CustomFormat = "dd-MM-yyyy";
            dataGridViewBill.DataSource = bill_bus.selectBillSearch(DateTimePicker_search.Text);
        }

        private void btn_refesh_Click(object sender, EventArgs e)
        {
            DateTimePicker_search.CustomFormat = " ";          
            dataGridViewBill.DataSource = bill_bus.getBillExport();
        }

        private void DateTimePickerSearchImport_ValueChanged(object sender, EventArgs e)
        {
            DateTimePickerSearchImport.CustomFormat = "yyyy-MM-dd";
            dgv_import_bill.DataSource = bill_bus.selectBillSearchImport(DateTimePickerSearchImport.Text);
        }

        private void btn_refesh_import_Click(object sender, EventArgs e)
        {
            DateTimePickerSearchImport.CustomFormat = " ";
            dgv_import_bill.DataSource = bill_bus.selectBillDetailImport();
        }
    }
}
