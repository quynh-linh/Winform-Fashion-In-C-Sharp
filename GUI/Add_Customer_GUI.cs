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
using NPOI.SS.Formula.Functions;

namespace GUI
{
    public partial class Add_Customer_GUI : Form
    {
        private CustomerBUS customerBUS = new CustomerBUS();
        private SellGui sell;
        public Add_Customer_GUI( SellGui sell)
        {
            InitializeComponent();
            this.sell = sell;
            auto_Id();
        }

        public void auto_Id()
        {
            guna2TextBox1.Text = "C" + customerBUS.count();
        }

        private void guna2TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            if ( guna2TextBox2.Text != "" || guna2TextBox3.Text != "" || guna2TextBox4.Text != "")
            {

                String id = guna2TextBox1.Text;
                String name = guna2TextBox2.Text;
                String address = guna2TextBox3.Text;
                int phone = int.Parse(guna2TextBox4.Text);
                String sex = "";
                if (guna2RadioButton1.Checked == true)
                    sex = "Nam";
                else if (guna2RadioButton2.Checked == true)
                    sex = "Nữ";
                else sex = "Khác";
                CustomerDTO customerDTO = new CustomerDTO(id, name, address, phone, sex);
                // Them
                if (customerBUS.themKhachHang(customerDTO))
                {
                    MessageBox.Show("Thêm thành công");
                    this.sell.guna2TextBox3.Text = name;
                    this.sell.guna2TextBox2.Text = phone+"";
                    this.Dispose();
                }
                else MessageBox.Show("Thêm ko thành công");
            }
            else MessageBox.Show("Vui lòng nhập đủ dữ liệu");
        }
    }
}
