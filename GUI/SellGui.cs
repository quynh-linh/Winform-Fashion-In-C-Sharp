using BUS;
using DAO;
using DTO;
using Guna.UI2.WinForms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Ink;

namespace GUI
{
    
    public partial class SellGui : Form
    {
        private SellBUS sellBUS = new SellBUS();
        private Bill_BUS bill_BUS = new Bill_BUS();
        public ArrayList listOder = new ArrayList();
        public ArrayList list_Quantity_Choice = new ArrayList();
        public double totalPrice = 0;
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
                guna2Button2.Enabled = false;
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
            item.BackColor = Color.SteelBlue;
            FlpSanPham.Controls.Add(item);

        }

        //add thong tin mua vo usercontrol
        public void addItemOder(ArrayList listOder, ArrayList list_Quantity_Choice)
        {
            flp_oder.Controls.Clear();
            totalPrice = 0;

            for (int i = 0; i < listOder.Count; i++)
            {
                UC_oder order = new UC_oder(this);
                order.setDataOder((ProductDTO)listOder[i], (int) list_Quantity_Choice[i],i);

                totalPrice += order.total;
                flp_oder.Controls.Add(order);
            }

            if (totalPrice > 0)
                label4.Text = totalPrice.ToString("#,#,#") + "đ";
            else
            {
                totalPrice = 0;
                label4.Text = "0đ";
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả sản phẩm?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                listOder.Clear();
                list_Quantity_Choice.Clear();
                flp_oder.Controls.Clear();
                label4.Text = "0đ";
                totalPrice = 0;
                guna2TextBox2.Text = "";
                guna2TextBox3.Text = "";
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
                if (!guna2TextBox3.Text.Equals("Tên khách hàng :")&& !guna2TextBox3.Text.Equals("")) customer_Id = customerBUS.get_Customer_By_Phone(guna2TextBox2.Text, "id");
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
                        Bill_Detail_DTO bill_Detail = new Bill_Detail_DTO(bill_Id,p.Product_Id, size, (int)list_Quantity_Choice[i], p.Product_Price + p.Product_Price * 5/100, percent);
                        bill_BUS.insert_Detail_Bill(bill_Detail);
                        bill_BUS.update_Quantity_After_Payment(p.Product_Id, (int)list_Quantity_Choice[i]);
                    }
                    PDF(bill_Id);
                    this.totalPrice = 0;
                    listOder.Clear();
                    list_Quantity_Choice.Clear();
                    flp_oder.Controls.Clear();
                    label4.Text = "0đ";
                    guna2TextBox1.Text = "";
                    label2.Text = "0đ";
                    guna2TextBox2.Text = "";
                    guna2TextBox3.Text = "";
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
                if (customerBUS.get_Customer_By_Phone(guna2TextBox2.Text, "name") != null)
                    guna2TextBox3.Text = customerBUS.get_Customer_By_Phone(guna2TextBox2.Text, "name");
                else
                {
                    if(MessageBox.Show("Không tìm thấy số điện thoại này? \n Bạn muốn thêm khách hàng???","",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Add_Customer_GUI form = new Add_Customer_GUI(this);
                        form.Show();
                    }
                }
            }
        }

        private void Auto_Update_Discount()
        {
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            String now = day + "/" + month + "/" + year;
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime time1 = DateTime.ParseExact(now, "d/M/yyyy", provider);

            ArrayList list_Discount = discountBUS.get_Discount();

            for (int i=0;i< list_Discount.Count;i++)
            {
                DiscountDTO dc = (DiscountDTO)list_Discount[i];
                if (time1.CompareTo(DateTime.ParseExact(dc.Start_day, "d/M/yyyy", provider)) >= 0 && time1.CompareTo(DateTime.ParseExact(dc.End_day, "dd/MM/yyyy", provider)) <= 0 && dc.Status.Equals("Ngừng áp dụng"))
                {
                    discountBUS.Auto_Update_Discount(dc.Ma_discount, "Đang áp dụng");
                }

                if (time1.CompareTo(DateTime.ParseExact(dc.Start_day, "d/M/yyyy", provider)) < 0 && dc.Status.Equals("Đang áp dụng") || time1.CompareTo(DateTime.ParseExact(dc.End_day, "dd/MM/yyyy", provider)) > 0 && dc.Status.Equals("Đang áp dụng"))
                {
                    discountBUS.Auto_Update_Discount(dc.Ma_discount, "Ngừng áp dụng");
                }
            }

        }

        public void PDF(String id)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = Application.StartupPath + @"\PDF_Bill\" + id + ".pdf";
            iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 10f, 10f, 0f);

            FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

            pdfDoc.Open();

            PdfContentByte cb = writer.DirectContent;

            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb.SetColorFill(BaseColor.DARK_GRAY);
            cb.SetFontAndSize(bf, 15);

            Bill_DTO b = bill_BUS.get_Bill_By_Id(id);
            ArrayList bd = bill_BUS.get_Detail_Bill_By_Id(id);

            cb.BeginText();
            string text = "BILL";
            cb.ShowTextAligned(Element.ALIGN_LEFT, text, 300, 800, 0);

            text = String.Format("Coupon Code : {0}", id);
            cb.ShowTextAligned(Element.ALIGN_LEFT, text, 100, 750, 0);
            
            text = String.Format("Date : {0}", b.Bill_Time);
            cb.ShowTextAligned(Element.ALIGN_LEFT, text, 350, 750, 0);
            
            String name = bill_BUS.get_Name_Staff_By_Id(b.Account_Id);
            text = String.Format("Staff : {0}", name);
            cb.ShowTextAligned(Element.ALIGN_LEFT, text, 100, 700, 0);
            //
            if (b.Customer_Id.Equals("null")) { }
            else
            {
                text = String.Format("Customer : {0}", bill_BUS.get_Name_Customer_By_Id(b.Customer_Id));
                cb.ShowTextAligned(Element.ALIGN_LEFT, text, 350, 700, 0);
            }
            //
            text = "-------------------------------------------------------------------------------------------------------";
            cb.ShowTextAligned(Element.ALIGN_LEFT, text, 50, 650, 0);
            cb.EndText();
            //

            //
            cb.BeginText();
            text = "Quantity";
            cb.ShowTextAligned(Element.ALIGN_CENTER, text, 100, 600, 0);
            text = "Price";
            cb.ShowTextAligned(Element.ALIGN_CENTER, text, 200, 600, 0);
            text = "Discount";
            cb.ShowTextAligned(Element.ALIGN_CENTER, text, 350, 600, 0);
            text = "Total";
            cb.ShowTextAligned(Element.ALIGN_CENTER, text, 500, 600, 0);
            cb.EndText();
            //
            int y = 600;
            int STT = 0;
            if(bd.Count > 0)
            {
                for (int i = 0; i < bd.Count; i++)
                {
                    if( y < 200)
                    {
                        y = 800;
                        pdfDoc.Add(new Paragraph());
                        pdfDoc.NewPage();
                    }
                    STT++;
                    Bill_Detail_DTO bill_Dtail = (Bill_Detail_DTO)bd[i];

                    int size = 0;
                    if (bill_Dtail.Size.Equals("S")) size = 1;
                    else if(bill_Dtail.Size.Equals("M")) size = 2;
                    else if (bill_Dtail.Size.Equals("L")) size = 3;
                    else if (bill_Dtail.Size.Equals("XL")) size = 4;
                    ProductDTO pd = bill_BUS.get_Product_In_Detail_Bill(bill_Dtail.Product_Id, size);

                    String s = "";
                    if (pd.Size_id == 1) s = "S";
                    else if (pd.Size_id == 2) s = "M";
                    else if (pd.Size_id == 3) s = "L";
                    else if (pd.Size_id == 4) s = "XL";

                    cb.BeginText();
                    text = STT + ". " + pd.Product_Name + " (" + s +")";
                    y = y - 50;
                    cb.ShowTextAligned(Element.ALIGN_LEFT, text, 90, y, 0);
                    y = y - 50;
                    text = bill_Dtail.Quantity + "";
                    cb.ShowTextAligned(Element.ALIGN_CENTER, text, 100, y , 0);
                    text = bill_Dtail.Price.ToString("#,#,#") ;
                    cb.ShowTextAligned(Element.ALIGN_CENTER, text+ " VND", 200, y, 0);
                    if (bill_Dtail.Percent > 0)
                    {
                        text = (bill_Dtail.Price - bill_Dtail.Price* bill_Dtail.Percent/100).ToString("#,#,#") ;
                        cb.ShowTextAligned(Element.ALIGN_CENTER, text+ " VND", 350, y, 0);
                        text = ((bill_Dtail.Price - bill_Dtail.Price * bill_Dtail.Percent / 100) * bill_Dtail.Quantity).ToString("#,#,#") ;
                        cb.ShowTextAligned(Element.ALIGN_CENTER, text+ " VND", 500, y, 0);
                    }

                    else
                    {
                        text = (bill_Dtail.Price * bill_Dtail.Quantity).ToString("#,#,#") ;
                        cb.ShowTextAligned(Element.ALIGN_CENTER, text+ " VND", 500, y, 0);
                    }
                    cb.EndText();
                }
            }


            if (y <= 400)
            {
                y = 800;
                pdfDoc.Add(new Paragraph());
                pdfDoc.NewPage();
            }
            cb.BeginText();
            BaseFont bf1 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb.SetColorFill(BaseColor.DARK_GRAY);
            cb.SetFontAndSize(bf1, 15);
            text = "---------------------------------------------------------------------------------------------------------------";
            y = y - 50;
            cb.ShowTextAligned(Element.ALIGN_LEFT, text, 50, y, 0);
            text = "Total : " + b.Total.ToString("#,#,#") ;
            y = y - 50;
            cb.ShowTextAligned(Element.ALIGN_LEFT, text+ " VND", 300, y, 0);
            text = "Recieved Money : " + Double.Parse(guna2TextBox1.Text).ToString("#,#,#") ;
            y = y - 50;
            cb.ShowTextAligned(Element.ALIGN_LEFT, text+  " VND", 300, y, 0);
            text = "Excess Money : " + label2.Text;
            y = y - 50;
            cb.ShowTextAligned(Element.ALIGN_LEFT, text+ " VND", 300, y, 0);
            cb.EndText();


            pdfDoc.Close();
            stream.Close();
            writer.Close();
            System.Diagnostics.Process.Start(saveFileDialog1.FileName);
        }
    }
}
