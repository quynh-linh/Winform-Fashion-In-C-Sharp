using System;
using System.Data;
using System.Windows.Forms;
using BUS;
using DTO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using static NPOI.HSSF.Util.HSSFColor;
using NPOI.XWPF.UserModel;
using System.Xml.Linq;
using System.Windows.Input;

namespace GUI
{
    public partial class ImportProductsGUI : Form
    {
        ImportProductBUS importProductBUS = new ImportProductBUS();
        BrandBUS brandBUS = new BrandBUS();
        AccountBUS accountBUS = new AccountBUS();
        private int id_nv;
        private double currentPrice;
        private int currentQuantity;
        public ImportProductsGUI(string role_Manipulative, string name_Id, int id_Staff)
        {
            InitializeComponent();
            if (!role_Manipulative.Equals("Nhập hàng"))
            {

            }
            textBoxStaff.Text = name_Id;
            id_nv = id_Staff;
            loadCBBBrand();
            loadCBBBrand_List();
            loadCBBAccount_List();
            loadDBtoImportProducts();
            dataGridViewDetailImportProducts.AllowUserToAddRows = false;
        }
        private void ImportProductsGUI_Load(object sender, EventArgs e)
        {
            dataGridViewSanPham.DataSource = importProductBUS.getProducts();
        }
        private void loadCBBBrand()
        {
            comboboxBrand.DataSource = brandBUS.getBrand();
            comboboxBrand.DisplayMember = "name";
            comboboxBrand.ValueMember = "id";

        }
        private void loadCBBBrand_List()
        {
            comboboxNCC.DataSource = brandBUS.getBrand();
            comboboxNCC.DisplayMember = "name";
            comboboxNCC.ValueMember = "id";
        }
        private void loadCBBAccount_List()
        {
            comboboxStaff.DataSource = accountBUS.getAllAccount();
            comboboxStaff.DisplayMember = "full_name";
            comboboxStaff.ValueMember = "id";
        }
        private void loadDBtoImportProducts()
        {
            dataGridViewImprotProducts.DataSource = importProductBUS.getImportProducts();
        }
        private void loadDBtoDetailImportProducts()
        {
            string maPhieuNhap = textboxMaPhieuNhap_Detail.Text;
            if (maPhieuNhap != "")
            {
                dataGridViewDetailImportProducts.DataSource = importProductBUS.getDetailImportProducts(maPhieuNhap);
            }
        }
        private void searchDateImportProduct()
        {
            String dFirst = dateFirstTime.Text;
            DateTime dateFirst = DateTime.Parse(dFirst);
            String dEnd = dateEndTime.Text;
            DateTime dateEnd = DateTime.Parse(dEnd);
            int result = DateTime.Compare(dateFirst, dateEnd);
            // ==1 ngày thứ nhất lớn hơn ngày thứ 2
            if (result == 1)
            {
                MessageBox.Show("Ngày trước không lớn hơn ngày sau");
            }
            // 1 ngày thứ nhất nhỏ hơn ngày thứ 2
            else if (result == 1)
            {
                dataGridViewDetailImportProducts.DataSource = importProductBUS.searchDateImportProduct(dFirst, dEnd);
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void loadDatatoGroupBoxInfoProduct(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dataGridViewSanPham.CurrentCell.Selected = true;
                textBoxMaSanPham.Text = dataGridViewSanPham.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                textBoxMaPhieu.Text = dataGridViewSanPham.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                textBoxQuantity.Text = dataGridViewSanPham.Rows[e.RowIndex].Cells["quantity"].FormattedValue.ToString();
                textBoxPrice.Text = dataGridViewSanPham.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
                textBox_size_ImportProducts.Text = dataGridViewSanPham.Rows[e.RowIndex].Cells["sizename"].FormattedValue.ToString();
            }
        }
        private void LoadSumMoney()
        {
            if (guna2DataGridView1.Rows.Count > 0)
            {
                double sum = 0;
                for (int i = 0; i < guna2DataGridView1.Rows.Count; i++)
                {
                    double item = Convert.ToDouble(guna2DataGridView1.Rows[i].Cells["sunmoney"].Value);
                    sum += item;
                }
                textBoxSumMoney.Text = Convert.ToString(sum);
            }
        }
        private void ReLoadForm()
        {
            textboxMaPhieuNhap_Detail.Text = "";
            textBoxImportDate_Detail.Text = "";
            textBoxBrand_Detail.Text = "";
            textBoxStaff_Detail.Text = "";
            textBox_TongTien_Detail.Text = "";
            ReLoadDetailForm();
        }
        private void ReLoadDetailForm()
        {
            textBox_MaChiTiet_Detail.Text = "";
            textBox_SanPham_Detail.Text = "";
            textBox_SoLuong_Detail.Text = "";
            textBox_GiaNhap_Detail.Text = "";
            textBoxTongTien_Detail.Text = "";
            textbox_size_detail.Text = "";
        }

        private void addProductsToCart(object sender, EventArgs e)
        {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(guna2DataGridView1);
            newRow.Cells[0].Value = textBoxMaSanPham.Text;
            newRow.Cells[1].Value = textBoxMaPhieu.Text;
            newRow.Cells[2].Value = textBox_size_ImportProducts.Text;
            newRow.Cells[3].Value = textBoxQuantity.Text;
            newRow.Cells[4].Value = textBoxPrice.Text;
            Double tongTien = Convert.ToDouble(textBoxPrice.Text) * Convert.ToDouble(textBoxQuantity.Text);
            newRow.Cells[5].Value = tongTien;
            guna2DataGridView1.Rows.Add(newRow);
            LoadSumMoney();
        }
        private void removeRowAllCart()
        {
            guna2DataGridView1.Rows.Clear();
        }

        private void removeRowCart(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.guna2DataGridView1.SelectedRows)
            {
                guna2DataGridView1.Rows.RemoveAt(item.Index);
            }
            LoadSumMoney();
        }
        private void guna2DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int size_id(string size_name)
        {
            int id = 0;
            if (size_name.Trim().Equals("S"))
            {
                id = 1;
            }
            else if (size_name.Trim().Equals("M"))
            {
                id = 2;
            }
            else if (size_name.Trim().Equals("L"))
            {
                id = 3;
            }
            else if (size_name.Trim().Equals("XL"))
            {
                id = 4;
            }
            return id;
        }
        private string size_name(int id)
        {
            string name = "";
            if (id == 1)
            {
                name = "S";
            }
            else if (id == 2)
            {
                name = "M";
            }
            else if (id == 3)
            {
                name = "L";
            }
            else if (id == 4)
            {
                name = "XL";
            }
            return name;
        }

        private void addImportProducts(object sender, EventArgs e)
        {
            string format = "dd/MM/yyyy";
            DateTime now = DateTime.Now;
            // ==> 18/03/2016 23:49:39
            string ngayNhap = now.ToString(format);
            String maPhieuNhap = textBoxMaPhieuNhap.Text;
            int maNhanVien = id_nv;
            DataRowView br = (DataRowView)comboboxBrand.SelectedItem;
            string maBrand = br.Row["id"].ToString();
            double tongTien = Convert.ToDouble(textBoxSumMoney.Text);
            if (ngayNhap != "" || maNhanVien > -1 || maBrand != "" || tongTien > 0)
            {
                ImprotProductDTO improtProductDTO = new ImprotProductDTO(maPhieuNhap, ngayNhap, maNhanVien, maBrand, tongTien);
                if (importProductBUS.addImportProduct(improtProductDTO))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (guna2DataGridView1.Rows.Count > 0)
                    {
                        for (int i = 0; i < guna2DataGridView1.Rows.Count; i++)
                        {
                            string maSP = Convert.ToString(guna2DataGridView1.Rows[i].Cells[0].Value);
                            int soLuong = Convert.ToInt32(guna2DataGridView1.Rows[i].Cells[3].Value);
                            string size = Convert.ToString(guna2DataGridView1.Rows[i].Cells[2].Value);
                            int size_Id = size_id(size);
                            double giaNhap = Convert.ToDouble(guna2DataGridView1.Rows[i].Cells[4].Value);
                            double sumMoney = Convert.ToDouble(guna2DataGridView1.Rows[i].Cells[5].Value);
                            if (maSP != "" || soLuong > 0 || giaNhap > 0 || sumMoney > 0)
                            {
                                importProductBUS.addDetailImportProduct(new detail_importProductDTO(maSP, soLuong, giaNhap, sumMoney, maPhieuNhap, size_Id));
                                importProductBUS.updatePriceAndQuantity(giaNhap, soLuong, maSP);
                            }
                        }
                        dataGridViewImprotProducts.DataSource = importProductBUS.getImportProducts();
                        dataGridViewSanPham.DataSource = importProductBUS.getProducts();
                        removeRowAllCart();
                        textBoxMaPhieuNhap.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void loadDataImportProductToDetail(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dataGridViewImprotProducts.CurrentCell.Selected = true;
                textboxMaPhieuNhap_Detail.Text = dataGridViewImprotProducts.Rows[e.RowIndex].Cells["maPhieuNhap"].FormattedValue.ToString();
                textBoxImportDate_Detail.Text = dataGridViewImprotProducts.Rows[e.RowIndex].Cells["ngayNhap"].FormattedValue.ToString();
                textBoxBrand_Detail.Text = dataGridViewImprotProducts.Rows[e.RowIndex].Cells["name_Brand"].FormattedValue.ToString();
                textBoxStaff_Detail.Text = dataGridViewImprotProducts.Rows[e.RowIndex].Cells["full_name"].FormattedValue.ToString();
                textBox_TongTien_Detail.Text = dataGridViewImprotProducts.Rows[e.RowIndex].Cells["tongTien"].FormattedValue.ToString();
            }
        }

        private void textboxMaPhieuNhap_Detail_TextChanged(object sender, EventArgs e)
        {
            loadDBtoDetailImportProducts();
        }

        private void loadDetailImportProductToTextBox(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dataGridViewDetailImportProducts.CurrentCell.Selected = true;
                textBox_MaChiTiet_Detail.Text = dataGridViewDetailImportProducts.Rows[e.RowIndex].Cells["maChiTiet"].FormattedValue.ToString();
                textBox_SoLuong_Detail.Text = dataGridViewDetailImportProducts.Rows[e.RowIndex].Cells["so_luong"].FormattedValue.ToString();
                textBoxTongTien_Detail.Text = dataGridViewDetailImportProducts.Rows[e.RowIndex].Cells["tong_tien"].FormattedValue.ToString();
                textBox_SanPham_Detail.Text = dataGridViewDetailImportProducts.Rows[e.RowIndex].Cells["maSP"].FormattedValue.ToString();
                textBox_GiaNhap_Detail.Text = dataGridViewDetailImportProducts.Rows[e.RowIndex].Cells["gia_nhap"].FormattedValue.ToString();
                int id_size = Convert.ToInt32(dataGridViewDetailImportProducts.Rows[e.RowIndex].Cells["size_detail"].Value);
                textbox_size_detail.Text = size_name(id_size);
                currentPrice = Convert.ToDouble(textBox_GiaNhap_Detail.Text) * Convert.ToDouble(textBox_SoLuong_Detail.Text);
                currentQuantity = Convert.ToInt32(textBox_SoLuong_Detail.Text);
            }
        }
        public void PdfSharp()
        {
            // lưu file
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF(*.pdf)|*.pdf";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 10f, 10f, 0f);

                FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                //
                PdfContentByte cb = writer.DirectContent;
                //
                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                cb.SetColorFill(BaseColor.DARK_GRAY);
                cb.SetFontAndSize(bf, 15);
                //
                cb.BeginText();
                string text = "HÓA ĐƠN NHẬP ";
                cb.ShowTextAligned(Element.ALIGN_LEFT, text, 400, 800, 0);
                cb.EndText();
                //
                cb.BeginText();
                text = String.Format("Coupon Code : {0}", textboxMaPhieuNhap_Detail.Text);
                cb.ShowTextAligned(Element.ALIGN_LEFT, text, 100, 750, 0);
                cb.EndText();
                //
                cb.BeginText();
                text = String.Format("Date Added : {0}", textBoxImportDate_Detail.Text);
                cb.ShowTextAligned(Element.ALIGN_LEFT, text, 100, 700, 0);
                cb.EndText();
                //
                cb.BeginText();
                text = String.Format("Brand : {0}", textBoxBrand_Detail.Text);
                cb.ShowTextAligned(Element.ALIGN_LEFT, text, 100, 650, 0);
                cb.EndText();
                //
                cb.BeginText();
                text = String.Format("Staff : {0}", textBoxStaff_Detail.Text);
                cb.ShowTextAligned(Element.ALIGN_LEFT, text, 100, 600, 0);
                cb.EndText();
                //
                cb.BeginText();
                text = String.Format("Total Money : {0}", textBox_TongTien_Detail.Text);
                cb.ShowTextAligned(Element.ALIGN_LEFT, text, 100, 550, 0);
                cb.EndText();
                // Thêm table
                PdfPTable pdfTable = new PdfPTable(dataGridViewDetailImportProducts.ColumnCount);
                pdfTable.TotalWidth = pdfDoc.PageSize.Width;
                pdfTable.DefaultCell.BorderWidth = 1;
                //Adding DataRow
                foreach (DataGridViewColumn col in dataGridViewDetailImportProducts.Columns)
                {
                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                    pdfTable.AddCell(pCell);
                }
                foreach (DataGridViewRow row in dataGridViewDetailImportProducts.Rows)
                {
                    foreach (DataGridViewCell dcell in row.Cells)
                    {
                        pdfTable.AddCell(dcell.FormattedValue.ToString());
                    }
                }
                pdfDoc.Add(pdfTable);
                pdfTable.WriteSelectedRows(0, -1, 50, 400, writer.DirectContent);
                pdfDoc.Close();
                stream.Close();
                writer.Close();
            }
        }
        private void savePDF(object sender, EventArgs e)
        {
            PdfSharp();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            searchDateImportProduct();
        }

        private void updateDetailImportProducts(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_MaChiTiet_Detail.Text))
            {
                int maChiTiet = Convert.ToInt32(textBox_MaChiTiet_Detail.Text);
                int soLuong = Convert.ToInt32(textBox_SoLuong_Detail.Text);
                double giaNhap = Convert.ToDouble(textBox_GiaNhap_Detail.Text);
                double tongTien = soLuong * giaNhap;
                String nameSp = textBox_SanPham_Detail.Text;
                string size_name = textbox_size_detail.Text;
                int size = size_id(size_name);
                string maPhieuNhap = textboxMaPhieuNhap_Detail.Text;
                String maSp = importProductBUS.getIdProduct(nameSp, size);
                detail_importProductDTO detail = new detail_importProductDTO(maChiTiet, maSp, soLuong, giaNhap, tongTien, maPhieuNhap, size);
                double currentSum = Convert.ToDouble(textBox_TongTien_Detail.Text);
                double sum = (currentSum - currentPrice) + tongTien;
                int soLuongProduct;
                if (soLuong > currentQuantity)
                {
                    soLuongProduct = soLuong - currentQuantity;
                    importProductBUS.updatePriceAndQuantity(giaNhap, soLuongProduct, maSp);
                }
                else
                {
                    soLuongProduct = currentQuantity - soLuong;
                    importProductBUS.updatePriceAndQuantityReduce(giaNhap, soLuongProduct, maSp);
                }
                MessageBox.Show(importProductBUS.updateDetailImportProduct(detail, sum), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_TongTien_Detail.Text = Convert.ToString(sum);
                dataGridViewDetailImportProducts.DataSource = importProductBUS.getDetailImportProducts(maPhieuNhap);
                dataGridViewSanPham.DataSource = importProductBUS.getProducts();
                ReLoadDetailForm();
            } 
            else
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void removeDetail(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_MaChiTiet_Detail.Text))
            {
                int maChiTiet = Convert.ToInt32(textBox_MaChiTiet_Detail.Text);
                int soLuong = Convert.ToInt32(textBox_SoLuong_Detail.Text);
                double giaNhap = Convert.ToDouble(textBox_GiaNhap_Detail.Text);
                double tongTien = Convert.ToDouble(textBoxTongTien_Detail.Text);
                String nameSp = textBox_SanPham_Detail.Text;
                string size_name = textbox_size_detail.Text;
                int size = size_id(size_name);
                string maPhieuNhap = textboxMaPhieuNhap_Detail.Text;
                String maSp = importProductBUS.getIdProduct(nameSp, size);
                int number = dataGridViewDetailImportProducts.Rows.Count;
                if (number > 1)
                {
                    if (importProductBUS.removeDetailImportProduct(maChiTiet))
                    {
                        double currentSum = Convert.ToDouble(textBox_TongTien_Detail.Text);
                        double sum = currentSum - tongTien;
                        if (importProductBUS.updateTotalMonetImportProduct(maPhieuNhap, sum))
                        {
                            if (importProductBUS.updateQuantity(soLuong, maSp, size))
                            {
                                textBox_TongTien_Detail.Text = Convert.ToString(sum);
                                MessageBox.Show("Xóa thành công");
                                dataGridViewDetailImportProducts.DataSource = importProductBUS.getDetailImportProducts(maPhieuNhap);
                                dataGridViewSanPham.DataSource = importProductBUS.getProducts();
                                ReLoadDetailForm();
                            }
                        }
                    }
                }
                else if (number == 1)
                {
                    if (importProductBUS.removeDetailImportProduct(maChiTiet))
                    {
                        importProductBUS.removeImportProduct(textboxMaPhieuNhap_Detail.Text.ToString());
                        dataGridViewDetailImportProducts.DataSource = importProductBUS.getDetailImportProducts(maPhieuNhap);
                        ReLoadForm();
                    }
                }
            } else
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeImportProducts(object sender, EventArgs e)
        {
            if(dataGridViewImprotProducts.SelectedRows.Count > 0)
            {
                int index = dataGridViewImprotProducts.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridViewImprotProducts.Rows[index];
                string maPhieuNhap = Convert.ToString(selectedRow.Cells["maPhieuNhap"].Value);
                MessageBox.Show(importProductBUS.removeImportProductToID(maPhieuNhap),"Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                loadDBtoImportProducts();
            }
        }
    }
}
