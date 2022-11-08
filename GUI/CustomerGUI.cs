using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
