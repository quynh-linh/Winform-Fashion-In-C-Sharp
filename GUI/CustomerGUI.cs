﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using BUS;
using DTO;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class CustomerGUI : Form
    {
        private CustomerBUS customerBUS = new CustomerBUS();
        public CustomerGUI(string role_Manipulative)
        {
            InitializeComponent();
            if (!role_Manipulative.Equals("Được thay đổi"))
            {
                guna2Button1.Enabled = false;
                guna2Button4.Enabled = false;
                guna2Button3.Enabled = false;
                guna2Button2.Enabled = false;
                guna2Button5.Enabled = false;
            }
        }
        // load Dữ liệu từ DB lên form khách hàng
        private void CustomerGUI_Load(object sender, EventArgs e)
        {
            dataGridViewCustomer.DataSource = customerBUS.getThanhVien();
        }
       // thêm khách hàng vào cơ sở dữ liệu
        private void addCustomerDB(object sender, EventArgs e)
        {
            if (textBoxIdCustomer.Text != "" || textBoxNameCustomer.Text != "" || textBoxaddressCustomer.Text != "" || textBoxPhoneCustomer.Text != "")
            {

                String id = textBoxIdCustomer.Text;
                String name = textBoxNameCustomer.Text;
                String address = textBoxaddressCustomer.Text;
                int phone = int.Parse(textBoxPhoneCustomer.Text);
                String sex = "";
                if (radiobtnNam.Checked == true)
                {
                    sex = "Nam";
                }
                else if (radioNu.Checked == true)
                {
                    sex = "Nữ";
                }
                else
                {
                    sex = "Khác";
                }
                CustomerDTO customerDTO = new CustomerDTO(id, name, address, phone, sex);
                // Them
                if (customerBUS.themKhachHang(customerDTO))
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridViewCustomer.DataSource = customerBUS.getThanhVien(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu");
            }
        }
        // load lại form
        private void reloaddatagridView()
        {
            textBoxIdCustomer.Text = "";
            textBoxNameCustomer.Text = "";
            textBoxPhoneCustomer.Text = "";
            textBoxaddressCustomer.Text = "";
            radiobtnNam.Checked = false;
            radioNu.Checked = false;
            radioOther.Checked = false;
        }
        // lấy dữ liệu từ datagridview lên textbox
        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                dataGridViewCustomer.CurrentCell.Selected = true;
                textBoxIdCustomer.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells["idCustomer"].FormattedValue.ToString();
                textBoxNameCustomer.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells["nameCustomer"].FormattedValue.ToString();
                textBoxaddressCustomer.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells["address"].FormattedValue.ToString();
                textBoxPhoneCustomer.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells["phone"].FormattedValue.ToString();
                String sex = dataGridViewCustomer.Rows[e.RowIndex].Cells["sex"].FormattedValue.ToString();
                if (sex.Equals("Nam"))
                {
                    radiobtnNam.Checked = true;
                }
                else if (sex.Equals("Nữ"))
                {
                    radioNu.Checked = true;
                }
                else
                {
                    radioOther.Checked = true;
                }
                Console.Write("Dô rồi nè");
        }

        private void updateCustomer(object sender, EventArgs e)
        {
            if (textBoxIdCustomer.Text != "" || textBoxNameCustomer.Text != "" || textBoxaddressCustomer.Text != "" || textBoxPhoneCustomer.Text != "")
            {

                String id = textBoxIdCustomer.Text;
                String name = textBoxNameCustomer.Text;
                String address = textBoxaddressCustomer.Text;
                int phone = int.Parse(textBoxPhoneCustomer.Text);
                String sex = "";
                if (radiobtnNam.Checked == true)
                {
                    sex = "Nam";
                }
                else if (radioNu.Checked == true)
                {
                    sex = "Nữ";
                }
                else
                {
                    sex = "Khác";
                }
                CustomerDTO customerDTO = new CustomerDTO(id, name, address, phone, sex);
                // Them
                if (customerBUS.suaKhachHang(customerDTO))
                {
                    MessageBox.Show("Cập nhập thành công");
                    dataGridViewCustomer.DataSource = customerBUS.getThanhVien(); // refresh datagridview
                    reloaddatagridView();
                }
                else
                {
                    MessageBox.Show("Cập nhập ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu");
            }
        }

        private void removeCustomer(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dataGridViewCustomer.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dataGridViewCustomer.SelectedRows[0];
                String ID =row.Cells[0].Value.ToString();

                // Xóa
                if (customerBUS.xoaKhachHang(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridViewCustomer.DataSource = customerBUS.getThanhVien(); // refresh datagridview
                    reloaddatagridView();
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e) {
            SaveFileDialog saved = new SaveFileDialog();
            saved.Title = "Xuất -->> - - - ->";
            saved.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saved.ShowDialog() == DialogResult.OK) {
                try {
                    AccountGUI.exportExcel(saved.FileName, dataGridViewCustomer);
                    MessageBox.Show("Xuất thành công <3");
                }
                catch (Exception ex) {
                    MessageBox.Show("Xuất thất bai :< Errors : " + ex.Message);
                    MessageBox.Show("Phải tắt file excel khi thực hiện thao tác");
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e) {
            OpenFileDialog opened = new OpenFileDialog();
            opened.Title = "Nhập -->> - - - ->";
            opened.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (opened.ShowDialog() == DialogResult.OK) {
                try {
                    // get datatable from excel
                    System.Data.DataTable dataTable = AccountGUI.importExcel(opened.FileName);

                    // insert to database customer
                    customerBUS.insertCustomers(dataTable);
                    MessageBox.Show("nhập thành công <3");
                }
                catch (FormatException ex1) {
                    MessageBox.Show("Cột Không đúng định dạng");
                }
                catch (ApplicationException ex2) {
                    MessageBox.Show(ex2.Message);
                }
                catch (ArgumentException ex3) {
                    MessageBox.Show("Định dạng cột không đúng");
                }
                finally {
                    //get all customer
                    System.Data.DataTable dataTable2 = customerBUS.getThanhVien();
                    // update dataGridView
                    dataGridViewCustomer.DataSource = dataTable2;
                }
            }
        }

    }
}
