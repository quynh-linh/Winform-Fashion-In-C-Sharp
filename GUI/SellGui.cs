using BUS;
using DAO;
using DTO;
using Guna.UI2.WinForms;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    
    public partial class SellGui : Form
    {
        private SellBUS sellBUS = new SellBUS();
        private Bill_BUS bill_BUS = new Bill_BUS();
        public ArrayList listOder = new ArrayList();
        public ArrayList list_Quantity_Choice = new ArrayList();
        double totalPrice = 0;
        int id_Staff = 0;
        DiscountBUS discountBUS = new DiscountBUS();
        CustomerBUS customerBUS = new CustomerBUS();
        public SellGui(string role_Manipulative, int id_Staff)
        {
            InitializeComponent();
            load_Category();
            Auto_Update_Discount();
            if (!role_Manipulative.Equals("Bán hàng "))
            {
                guna2Button1.Enabled = false;
                //guna2Button2.Enabled = false;
            }

            label4.Text = "0đ";
            this.id_Staff = id_Staff;

            ArrayList list = new ArrayList();
            FlpSanPham.Controls.Clear();
            list = sellBUS.searchProducts(TbSearch.Text, guna2ComboBox1.Text);
            for (int i = 0; i < list.Count; i++)
                addItem((ProductDTO)list[i]);
        }

        // add sp zo usercontrol
        public void addItem(ProductDTO data)
        {
            UC_Sell_Item item = new UC_Sell_Item(this);
            item.setData(data);
            item.BackColor = Color.White;
            FlpSanPham.Controls.Add(item);

        }

        //add thong tin mua vo usercontrol
        public void addItemOder(ArrayList listOder, ArrayList list_Quantity_Choice)
        {
            flp_oder.Controls.Clear();

            for (int i = 0; i < listOder.Count; i++)
            {
                UC_oder order = new UC_oder(this);
                order.setDataOder((ProductDTO)listOder[i], (int) list_Quantity_Choice[i],i);

                totalPrice += order.total;
                flp_oder.Controls.Add(order);
            }

            if (totalPrice > 0)
                label4.Text = totalPrice.ToString("#,#,#") + "đ";
            else label4.Text = "0đ";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả sản phẩm?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                listOder.Clear();
                list_Quantity_Choice.Clear();
                flp_oder.Controls.Clear();
                label4.Text = "0đ";
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(guna2TextBox1.Text)){
                double recieved = double.Parse(guna2TextBox1.Text);
                double excessed = recieved - this.totalPrice;
                label2.Text = excessed.ToString("#,#,#") + "đ";
            }
            
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public String autoGenerateId()
        {
            String bill_id = "B";
            bill_id += (bill_BUS.countGenerateId()+1);
            return bill_id;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (listOder.Count == 0)
            {

            }
            else if (String.IsNullOrEmpty(guna2TextBox1.Text) || int.Parse(guna2TextBox1.Text.ToString()) <= 0)
                MessageBox.Show("Vui lòng điền số tiền khách đưa");
            else if (double.Parse(guna2TextBox1.Text) < this.totalPrice)
                MessageBox.Show("Chưa nhận đủ tiền");
            else if (MessageBox.Show("Bạn có chắc chắn muốn thanh toán?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                String bill_Id = autoGenerateId();
                DateTime time = DateTime.Now;
                String customer_Id = "null";
                if (!guna2TextBox3.Text.Equals("Tên khách hàng :")) customer_Id = customerBUS.get_Customer_By_Phone(guna2TextBox2.Text, "id");
                Bill_DTO bill = new Bill_DTO(bill_Id, this.totalPrice, time.ToString("dd/MM/yyyy hh:mm:ss"), id_Staff, customer_Id);
                if (bill_BUS.insert_Bill(bill))
                {
                    for( int i=0;i< listOder.Count; i++)
                    {
                        ProductDTO p = (ProductDTO) listOder[i];
                        String size = "";
                        if (p.Size_id == 1) size = "S";
                        else if (p.Size_id == 2) size = "M";
                        else if (p.Size_id == 3) size = "L";
                        else if (p.Size_id == 4) size = "XL";
                        int percent = discountBUS.check_Product_Discount(p.Product_Id, p.Product_Name, "name");
                        Bill_Detail_DTO bill_Detail = new Bill_Detail_DTO(bill_Id,p.Product_Id, size, (int)list_Quantity_Choice[i], p.Product_Price + p.Product_Price, percent);
                        bill_BUS.insert_Detail_Bill(bill_Detail);
                        bill_BUS.update_Quantity_After_Payment(p.Product_Id, (int)list_Quantity_Choice[i]);
                    }
                    this.totalPrice = 0;
                    listOder.Clear();
                    list_Quantity_Choice.Clear();
                    flp_oder.Controls.Clear();
                    label4.Text = "0đ";
                    guna2TextBox1.Text = "";
                    label2.Text = "0đ";
                    MessageBox.Show("Đã thanh toán");
                }
            }
            
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            FlpSanPham.Controls.Clear();
            list = sellBUS.searchProducts(TbSearch.Text, guna2ComboBox1.Text);
            for (int i = 0; i < list.Count; i++)
                addItem((ProductDTO)list[i]);
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            FlpSanPham.Controls.Clear();
            list = sellBUS.searchProducts(TbSearch.Text, guna2ComboBox1.Text);
            for (int i = 0; i < list.Count; i++)
                addItem((ProductDTO)list[i]);
        }

        private void load_Category()
        {
            guna2ComboBox1.DataSource = discountBUS.load_Data_Category();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(guna2TextBox2.Text))
            {
                //do nothing
            }
            else
            {
                if (customerBUS.get_Customer_By_Phone(guna2TextBox2.Text,"name") != null)
                    guna2TextBox3.Text = customerBUS.get_Customer_By_Phone(guna2TextBox2.Text,"name");
                else MessageBox.Show("Không tìm thấy số điện thoại này");
            }
        }

        private void Auto_Update_Discount()
        {
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            String now = day + "/" + month + "/" + year;
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime time1 = DateTime.ParseExact(now, "dd/MM/yyyy", provider);

            ArrayList list_Discount = discountBUS.get_Discount();

            for (int i=0;i< list_Discount.Count;i++)
            {
                DiscountDTO dc = (DiscountDTO)list_Discount[i];
                if (time1.CompareTo(DateTime.ParseExact(dc.Start_day, "dd/MM/yyyy", provider)) >= 0 && time1.CompareTo(DateTime.ParseExact(dc.End_day, "dd/MM/yyyy", provider)) <= 0 && dc.Status.Equals("Ngừng áp dụng"))
                {
                    discountBUS.Auto_Update_Discount(dc.Ma_discount, "Đang áp dụng");
                }

                if (time1.CompareTo(DateTime.ParseExact(dc.Start_day, "dd/MM/yyyy", provider)) < 0 && dc.Status.Equals("Đang áp dụng") || time1.CompareTo(DateTime.ParseExact(dc.End_day, "dd/MM/yyyy", provider)) > 0 && dc.Status.Equals("Đang áp dụng"))
                {
                    discountBUS.Auto_Update_Discount(dc.Ma_discount, "Ngừng áp dụng");
                }
            }

        }
    }
}
