using System;
using BUS;
using DTO;
using System.Windows.Forms;
using System.Data;
using Guna.UI2.WinForms;
using DAO;
using System.Collections;
using NPOI.SS.Formula.Functions;
using System.Globalization;

namespace GUI
{
    public partial class DiscountGUI : Form
    {
        DiscountBUS dcBUS = new DiscountBUS();
        ArrayList list_Product = new ArrayList();
        ArrayList list_Choose_Product = new ArrayList();
        ArrayList list_Product_From_Discount = new ArrayList();
        DataTable table = new DataTable();
        DataTable table_Discount = new DataTable();
        public DiscountGUI(string role_Manipulative)
        {
            InitializeComponent();
            Auto_Update_Discount();
            if (!role_Manipulative.Equals("Được thay đổi"))
            {
                btn_add_discount.Enabled = false;
                btn_delete_discount.Enabled = false;
                btn_edit_discount.Enabled = false;
            }
            table.Columns.Add("Mã sản phẩm", typeof(String));
            table.Columns.Add("Tên", typeof(String));
            table.Columns.Add("Giá cũ", typeof(String));
            table.Columns.Add("Giá mới", typeof(String));
            table.Columns.Add("Lựa chọn", typeof(bool));

            table_Discount.Columns.Add("Mã", typeof(String));
            table_Discount.Columns.Add("Giá trị(%)", typeof(String));
            table_Discount.Columns.Add("Trạng thái", typeof(String));
            fill_Combobox();
            refresh();
        }
        public void fill_Combobox()
        {
            ArrayList list = dcBUS.load_Data_Category();
            guna2ComboBox2.DataSource = list;
        }

        private void auto_Create_Id()
        {
            String Id = "KM" + dcBUS.get_All_Discount("null").Rows.Count;
            tb_madiscount.Text = Id;
        }

        private void btn_add_discount_Click(object sender, EventArgs e)
        {
            if (tb_giamgia.Text != "" && dtp_startday.Text != "" && dtp_endday.Text != "")
            {
                String madiscount = tb_madiscount.Text;
                String giagia = tb_giamgia.Text;
                String startday = dtp_startday.Text;
                String endday = dtp_endday.Text;

                if (dcBUS.check_Name(int.Parse(tb_giamgia.Text), "-1"))
                    MessageBox.Show("Giá trị đã tồn tại");
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn thêm loại giảm giá này", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DiscountDTO dcDTO = new DiscountDTO(madiscount, giagia, startday, endday, guna2ComboBox1.Text, 0);
                        if (dcBUS.addDiscount(dcDTO))
                        {
                            refresh();
                            MessageBox.Show("Thêm Thành Công !");
                        }
                        else MessageBox.Show("Thêm Thất Bại !");
                    }
                }
            }
            else MessageBox.Show("Vui lòng nhập đủ dữ liệu !");
        }

        private void dgv_discount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dgv_discount.CurrentCell.Selected = true;
                tb_madiscount.Text = dgv_discount.Rows[e.RowIndex].Cells["maDiscount"].FormattedValue.ToString();
                tb_giamgia.Text = dgv_discount.Rows[e.RowIndex].Cells["sale_percent"].FormattedValue.ToString();



                if (dcBUS.load_Discount(txt_Search.Text, guna2ComboBox3.Text).Rows.Count > e.RowIndex)
                {
                    //MessageBox.Show(dcBUS.load_Discount(txt_Search.Text, guna2ComboBox3.Text).Rows[e.RowIndex][2].ToString());
                    dtp_startday.Text = dcBUS.get_Date_From_Discount_Id(tb_madiscount.Text).Rows[0][0].ToString();
                    dtp_endday.Text = dcBUS.get_Date_From_Discount_Id(tb_madiscount.Text).Rows[0][1].ToString();
                    this.table.Rows.Clear();
                    if (dcBUS.check_Discount_Id(tb_madiscount.Text))
                    {
                        list_Choose_Product.Clear();
                        load_Product_Remaining();
                    }
                    else
                    {
                        list_Product_From_Discount = dcBUS.load_Detail_Discount(tb_madiscount.Text.ToString());
                        load_Product_From_Discount(list_Product_From_Discount);
                    }
                }
                else dataGridView1.DataSource = null;

                guna2ComboBox1.Text = dgv_discount.Rows[e.RowIndex].Cells["status"].FormattedValue.ToString();
            }
        }

        public void refresh()
        {
            tb_giamgia.Text = "";
            dtp_startday.Text = System.DateTime.Now.ToLongTimeString();
            dtp_endday.Text = System.DateTime.Now.ToLongTimeString();
            dataGridView1.DataSource = null;
            auto_Create_Id();
            dgv_discount.DataSource = dcBUS.get_All_Discount("0");
            Auto_Update_Discount();
        }

        private void btn_edit_discount_Click(object sender, EventArgs e)
        {
            if (tb_giamgia.Text != "")
            {
                String madiscount = tb_madiscount.Text;
                String giamgia = tb_giamgia.Text;
                String startday = dtp_startday.Text;
                String endday = dtp_endday.Text;
                DiscountDTO dt = new DiscountDTO(madiscount, giamgia, startday, endday, guna2ComboBox1.Text, 0);

                if (dcBUS.check_Name(int.Parse(tb_giamgia.Text), madiscount))
                    MessageBox.Show("Giá trị đã tồn tại");
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn thêm loại giảm giá này", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (dcBUS.editDiscount(dt))
                        {
                            dcBUS.delete_Detail_Discount(madiscount);
                            foreach (String id in list_Choose_Product)
                                dcBUS.insert_Detail_Discount(madiscount, id, dcBUS.get_Product_By_Id(id).Product_Name);
                            list_Choose_Product.Clear();
                            MessageBox.Show("Cập nhật thành công !");
                            refresh();
                        }
                        else MessageBox.Show("Cập nhật không thành công !");
                    }
                }
            }
            else MessageBox.Show("Vui long nhap du thong tin !");
        }

        private void btn_delete_discount_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_giamgia.Text))
                MessageBox.Show("Vui lòng chọn loại giảm giá muốn xóa");
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa mã giảm giá này", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dcBUS.deleteDiscount(tb_madiscount.Text))
                    {
                        MessageBox.Show("Xóa thành công !");
                        refresh();
                    }
                    else MessageBox.Show("Xóa không thành công !");
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saved = new SaveFileDialog();
            saved.Title = "Xuất -->> - - - ->";
            saved.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saved.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    AccountGUI.exportExcel(saved.FileName, dgv_discount);
                    MessageBox.Show("Xuất thành công <3");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất thất bai :< Errors : " + ex.Message);
                    MessageBox.Show("Phải tắt file excel khi thực hiện thao tác");
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opened = new OpenFileDialog();
            opened.Title = "Nhập -->> - - - ->";
            opened.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (opened.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // get datatable from excel
                    System.Data.DataTable dataTable = AccountGUI.importExcel(opened.FileName);

                    // insert to database brand
                    dcBUS.insertDiscounts(dataTable);

                    //get all discount
                    System.Data.DataTable dataTable2 = dcBUS.getDiscount();

                    // update dataGridView
                    dgv_discount.DataSource = dataTable2;
                    MessageBox.Show("nhập thành công <3");
                }
                catch (FormatException ex1)
                {
                    MessageBox.Show("Cột Không đúng định dạng");
                }
                catch (ApplicationException ex2)
                {
                    MessageBox.Show(ex2.Message);
                }
                catch (ArgumentException ex3)
                {
                    MessageBox.Show("Định dạng cột không đúng");
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void tb_giamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void load_Product_From_Discount(ArrayList List_Product)
        {
            list_Choose_Product.Clear();
            for (int i = 0; i < List_Product.Count; i++)
            {
                Discount_Detail_DTO dt = (Discount_Detail_DTO)List_Product[i];
                ProductDTO pd = dcBUS.get_Product_By_Id((dt.Product_Id));
                double newPrice = pd.Product_Price - (pd.Product_Price * dcBUS.get_Percent(dt.Discount_Id) / 100);
                list_Choose_Product.Add(dt.Product_Id);
                //MessageBox.Show(dt.Product_Id+"");
                this.table.Rows.Add(pd.Product_Id, pd.Product_Name, pd.Product_Price.ToString("#,#,#") + "đ", newPrice.ToString("#,#,#") + "đ", true);
            }

            ArrayList product_NotIn_Discount_Detail = dcBUS.load_Product_Remaining(guna2TextBox1.Text, guna2ComboBox2.Text);
            for (int i = 0; i < product_NotIn_Discount_Detail.Count; i++)
            {
                ProductDTO pd = (ProductDTO)product_NotIn_Discount_Detail[i];
                this.table.Rows.Add(pd.Product_Id, pd.Product_Name, pd.Product_Price, null, false);
            }

            dataGridView1.DataSource = this.table;
        }

        private void load_Product_Remaining()
        {
            ArrayList product_NotIn_Discount_Detail = dcBUS.load_Product_Remaining(guna2TextBox1.Text, guna2ComboBox2.Text);
            for (int i = 0; i < product_NotIn_Discount_Detail.Count; i++)
            {
                ProductDTO pd = (ProductDTO)product_NotIn_Discount_Detail[i];

                this.table.Rows.Add(pd.Product_Id, pd.Product_Name, pd.Product_Price, null, false);
            }
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < dataGridView1.Rows.Count - 1)
            {
                if ((bool)dataGridView1.Rows[i].Cells[4].Value == true)
                {
                    dataGridView1.Rows[i].Cells[4].Value = false;
                    list_Choose_Product.Remove(dataGridView1.Rows[i].Cells[0].Value);
                }
                else
                {
                    dataGridView1.Rows[i].Cells[4].Value = true;
                    list_Choose_Product.Add(dataGridView1.Rows[i].Cells[0].Value);
                }
            }
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.table.Rows.Clear();
            if (dcBUS.check_Discount_Id(tb_madiscount.Text))
            {
                list_Choose_Product.Clear();
                load_Product_Remaining();
            }
            else
            {
                list_Product_From_Discount = dcBUS.load_Detail_Discount(tb_madiscount.Text.ToString());
                load_Product_From_Discount(list_Product_From_Discount);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.table.Rows.Clear();
            if (dcBUS.check_Discount_Id(tb_madiscount.Text))
            {
                list_Choose_Product.Clear();
                load_Product_Remaining();
            }
            else
            {
                list_Product_From_Discount = dcBUS.load_Detail_Discount(tb_madiscount.Text.ToString());
                load_Product_From_Discount(list_Product_From_Discount);
            }
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.table_Discount.Rows.Clear();
            DataTable tb = dcBUS.load_Discount(txt_Search.Text, guna2ComboBox3.Text);
            for (int i = 0; i < tb.Rows.Count; i++)
                this.table_Discount.Rows.Add(tb.Rows[i][0].ToString(), tb.Rows[i][1].ToString(), tb.Rows[i][2].ToString());
            dgv_discount.DataSource = table_Discount;
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            this.table_Discount.Rows.Clear();
            DataTable tb = dcBUS.load_Discount(txt_Search.Text, guna2ComboBox3.Text);
            for (int i = 0; i < tb.Rows.Count; i++)
                this.table_Discount.Rows.Add(tb.Rows[i][0].ToString(), tb.Rows[i][1].ToString(), tb.Rows[i][2].ToString());
            dgv_discount.DataSource = table_Discount; ;
        }

        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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

            ArrayList list_Discount = dcBUS.get_Discount();

            for (int i = 0; i < list_Discount.Count; i++)
            {
                DiscountDTO dc = (DiscountDTO)list_Discount[i];
                if (time1.CompareTo(DateTime.ParseExact(dc.Start_day, "dd/MM/yyyy", provider)) >= 0 && time1.CompareTo(DateTime.ParseExact(dc.End_day, "dd/MM/yyyy", provider)) <= 0 && dc.Status.Equals("Ngừng áp dụng"))
                {
                    dcBUS.Auto_Update_Discount(dc.Ma_discount, "Đang áp dụng");
                }

                if (time1.CompareTo(DateTime.ParseExact(dc.Start_day, "dd/MM/yyyy", provider)) < 0 && dc.Status.Equals("Đang áp dụng") || time1.CompareTo(DateTime.ParseExact(dc.End_day, "dd/MM/yyyy", provider)) > 0 && dc.Status.Equals("Đang áp dụng"))
                {
                    dcBUS.Auto_Update_Discount(dc.Ma_discount, "Ngừng áp dụng");
                }
            }
        }
    }
}
