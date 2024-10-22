﻿using System;
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
using Document = iTextSharp.text.Document;
using Microsoft.Win32;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using System.Runtime.InteropServices.ComTypes;

namespace GUI
{
    public partial class ImportProductsGUI : Form
    {
        ImportProductBUS importProductBUS = new ImportProductBUS();
        BrandBUS brandBUS = new BrandBUS();
        AccountBUS accountBUS = new AccountBUS();
        ProductsBUS productsBUS = new ProductsBUS();
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
            loadCBBBrandSearch();
            dataGridViewDetailImportProducts.AllowUserToAddRows = false;
            dataGridViewSanPham.AllowUserToAddRows = false;
            guna2DataGridView1.AllowUserToAddRows = false;
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
        private void loadCBBBrandSearch()
        {
            guna2ComboBoxBrand.DataSource = brandBUS.getBrand();
            guna2ComboBoxBrand.DisplayMember = "name";
            guna2ComboBoxBrand.ValueMember = "id";
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
            // < 0 ngày thứ nhất lớn hơn ngày thứ 2
            //if (result < 0)
            //{
            //    MessageBox.Show("Ngày trước không lớn hơn ngày sau");
            //}
            // 1 ngày thứ nhất nhỏ hơn ngày thứ 2
            //else if (result > 0)
            //{
            dataGridViewImprotProducts.DataSource = importProductBUS.searchDateImportProduct(dFirst, dEnd);
            //}
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
                String sizename = dataGridViewSanPham.Rows[e.RowIndex].Cells["sizename"].FormattedValue.ToString();
                if (!sizename.Equals(""))
                {
                    textBox_size_ImportProducts.Text = sizename;
                }
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
            string format = "yyyy-MM-dd";
            DateTime now = DateTime.Now;
            // ==> 18/03/2016 23:49:39
            string ngayNhap = now.ToString(format);
            //
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
        //public void PdfSharp()
        //{
        //    // lưu file
        //    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        //    saveFileDialog1.Filter = "PDF(*.pdf)|*.pdf";
        //    saveFileDialog1.Title = "Save an Image File";
        //    saveFileDialog1.ShowDialog();
        //    if (saveFileDialog1.FileName != "")
        //    {
        //        iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 10f, 10f, 0f);

        //        FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create);
        //        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
        //        pdfDoc.Open();
        //        //
        //        PdfContentByte cb = writer.DirectContent;
        //        //
        //        BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
        //        cb.SetColorFill(BaseColor.DARK_GRAY);
        //        cb.SetFontAndSize(bf, 15);
        //        //
        //        cb.BeginText();
        //        string text = "HÓA ĐƠN NHẬP ";
        //        cb.ShowTextAligned(Element.ALIGN_LEFT, text, 400, 800, 0);
        //        cb.EndText();
        //        //
        //        cb.BeginText();
        //        text = String.Format("Coupon Code : {0}", textboxMaPhieuNhap_Detail.Text);
        //        cb.ShowTextAligned(Element.ALIGN_LEFT, text, 100, 750, 0);
        //        cb.EndText();
        //        //
        //        cb.BeginText();
        //        text = String.Format("Date Added : {0}", textBoxImportDate_Detail.Text);
        //        cb.ShowTextAligned(Element.ALIGN_LEFT, text, 100, 700, 0);
        //        cb.EndText();
        //        //
        //        cb.BeginText();
        //        text = String.Format("Brand : {0}", textBoxBrand_Detail.Text);
        //        cb.ShowTextAligned(Element.ALIGN_LEFT, text, 100, 650, 0);
        //        cb.EndText();
        //        //
        //        cb.BeginText();
        //        text = String.Format("Staff : {0}", textBoxStaff_Detail.Text);
        //        cb.ShowTextAligned(Element.ALIGN_LEFT, text, 100, 600, 0);
        //        cb.EndText();
        //        //
        //        cb.BeginText();
        //        text = String.Format("Total Money : {0}", textBox_TongTien_Detail.Text);
        //        cb.ShowTextAligned(Element.ALIGN_LEFT, text, 100, 550, 0);
        //        cb.EndText();
        //        // Thêm table
        //        PdfPTable pdfTable = new PdfPTable(dataGridViewDetailImportProducts.ColumnCount);
        //        pdfTable.TotalWidth = pdfDoc.PageSize.Width;
        //        pdfTable.DefaultCell.BorderWidth = 1;
        //        //Adding DataRow
        //        foreach (DataGridViewColumn col in dataGridViewDetailImportProducts.Columns)
        //        {
        //            PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
        //            pdfTable.AddCell(pCell);
        //        }
        //        foreach (DataGridViewRow row in dataGridViewDetailImportProducts.Rows)
        //        {
        //            foreach (DataGridViewCell dcell in row.Cells)
        //            {
        //                pdfTable.AddCell(dcell.FormattedValue.ToString());
        //            }
        //        }
        //        pdfDoc.Add(pdfTable);
        //        pdfTable.WriteSelectedRows(0, -1, 50, 400, writer.DirectContent);
        //        pdfDoc.Close();
        //        stream.Close();
        //        writer.Close();
        //    }
        //}
        private void savePDF(object sender, EventArgs e)
        {
            PDFSave();
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
            }
            else
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeImportProducts(object sender, EventArgs e)
        {
            if (dataGridViewImprotProducts.SelectedRows.Count > 0)
            {
                int index = dataGridViewImprotProducts.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridViewImprotProducts.Rows[index];
                string maPhieuNhap = Convert.ToString(selectedRow.Cells["maPhieuNhap"].Value);
                MessageBox.Show(importProductBUS.removeImportProductToID(maPhieuNhap), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDBtoImportProducts();
            }
        }

        private void PDFSave()
        {
            int number = dataGridViewDetailImportProducts.Rows.Count;
            if (number > 1)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "PDF(*.pdf)|*.pdf";
                saveFileDialog1.Title = "Save an Image File";
                string id = textboxMaPhieuNhap_Detail.Text.ToString();
                saveFileDialog1.FileName = Application.StartupPath + @"\PDF_Import\" + id + ".pdf";
                if (File.Exists(Application.StartupPath + @"\PDF_Import\" + id + ".pdf") == true)
                {
                    MessageBox.Show("PDF file has been exported in the link" + Application.StartupPath + @"\PDF_Import\", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    if (saveFileDialog1.FileName != "")
                    {
                        Document document = new Document(new Rectangle(288f, 144f), 10, 10, 10, 10);
                        document.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
                        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog1.FileName, FileMode.Create));
                        iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 11);
                        document.Open();
                        PdfPTable table = new PdfPTable(dataGridViewDetailImportProducts.Columns.Count);
                        PdfPCell cell;
                        Font ColFont = FontFactory.GetFont("Segoe UI", (float)20.0, BaseColor.BLACK);
                        Chunk chunkCols = new Chunk("IMPORT COUPON", ColFont);
                        Paragraph header = new Paragraph(chunkCols);
                        cell = new PdfPCell(header);
                        cell.Colspan = dataGridViewDetailImportProducts.Columns.Count;
                        cell.PaddingLeft = 10;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(217, 234, 247);
                        cell.Padding = 5;
                        table.AddCell(cell);
                        PdfPCell cellH;
                        Font ColFont3 = FontFactory.GetFont("Segoe UI", (float)15.0, BaseColor.BLACK);
                        Chunk chunkCols1 = new Chunk(
                            "Bill Info : " + "\n" +
                            "" + "\n" +
                            "Id : " + textboxMaPhieuNhap_Detail.Text.ToString() + "\n" +
                            "" + "\n" +
                            "Date : " + textBoxImportDate_Detail.Text.ToString() + "\n" +
                            "" + "\n" +
                            "Supplier :" + textBoxBrand_Detail.Text.ToString() + "\n" +
                            "" + "\n" +
                            "Staff :" + textBoxStaff_Detail.Text.ToString() + "\n" +
                            "" + "\n"
                            , ColFont3);
                        cellH = new PdfPCell(new Paragraph(chunkCols1));
                        cellH.Colspan = dataGridViewDetailImportProducts.Columns.Count;
                        cellH.Padding = 10;
                        table.AddCell(cellH);
                        table.DefaultCell.BorderWidth = 1;
                        Font ColFont4 = FontFactory.GetFont("Segoe UI", (float)13.0, BaseColor.BLACK);
                        foreach (DataGridViewColumn col in dataGridViewDetailImportProducts.Columns)
                        {
                            Chunk chunkCols4 = new Chunk(col.HeaderText, ColFont4);
                            PdfPCell pCell = new PdfPCell(new Phrase(chunkCols4));
                            pCell.BackgroundColor = new iTextSharp.text.BaseColor(217, 234, 247);
                            pCell.Padding = 10;
                            table.AddCell(pCell);
                        }
                        foreach (DataGridViewRow row in dataGridViewDetailImportProducts.Rows)
                        {
                            foreach (DataGridViewCell dcell in row.Cells)
                            {
                                Chunk chunkCols4 = new Chunk(dcell.FormattedValue.ToString());
                                PdfPCell pCell1 = new PdfPCell(new Phrase(chunkCols4));
                                pCell1.Padding = 10;
                                table.AddCell(pCell1);
                            }
                        }
                        PdfPCell cellF;
                        Font ColFont5 = FontFactory.GetFont("Segoe UI", (float)15.0, BaseColor.BLACK);
                        Chunk chunkCols5 = new Chunk("Total Money :" + textBox_TongTien_Detail.Text.ToString(), ColFont5);
                        cellF = new PdfPCell(new Paragraph(chunkCols5));
                        cellF.Colspan = dataGridViewDetailImportProducts.Columns.Count;
                        cellF.Padding = 10;
                        cellF.HorizontalAlignment = Element.ALIGN_RIGHT;
                        table.AddCell(cellF);
                        document.Add(table);
                        Paragraph footer = new Paragraph("COMANY NAME", FontFactory.GetFont(FontFactory.TIMES, 10, iTextSharp.text.Font.NORMAL));
                        footer.Alignment = Element.ALIGN_RIGHT;
                        PdfPTable footerTbl = new PdfPTable(1);
                        footerTbl.TotalWidth = 1000;
                        footerTbl.HorizontalAlignment = Element.ALIGN_CENTER;
                        PdfPCell cell2 = new PdfPCell(footer);
                        cell2.Border = 0;
                        cell2.PaddingLeft = 10;
                        footerTbl.AddCell(cell2);
                        footerTbl.WriteSelectedRows(0, -1, 550, 30, writer.DirectContent);
                        document.Close();
                        MessageBox.Show("Export PDF file successfully", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Diagnostics.Process.Start(saveFileDialog1.FileName);
                    }
                }     
            } else
            {
                MessageBox.Show("Error", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private void searchImportProduct(object sender, EventArgs e)
        {
            searchDateImportProduct();
        }

        private void guna2Button7_Click(object sender, EventArgs e) {
            SaveFileDialog saved = new SaveFileDialog();
            saved.Title = "Xuất -->> - - - ->";
            saved.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saved.ShowDialog() == DialogResult.OK) {
                try {

                    DataTable dataTable = new DataTable();
                    DataColumn col1 = new DataColumn("Size");
                    DataColumn col2 = new DataColumn("Id");
                    DataColumn col3 = new DataColumn("Product");
                    DataColumn col4 = new DataColumn("Quantity");
                    DataColumn col5 = new DataColumn("Price");
                    DataColumn col6 = new DataColumn("Summoney");
                    dataTable.Columns.Add(col1);
                    dataTable.Columns.Add(col2);
                    dataTable.Columns.Add(col3);
                    dataTable.Columns.Add(col4);
                    dataTable.Columns.Add(col5);
                    dataTable.Columns.Add(col6);
                    foreach (DataGridViewRow dtgv in dataGridViewDetailImportProducts.Rows) {
                        DataRow dtrow = dataTable.NewRow();
                        dtrow[0] = dtgv.Cells[0].Value;
                        dtrow[1] = dtgv.Cells[1].Value;
                        dtrow[2] = dtgv.Cells[2].Value;
                        dtrow[3] = dtgv.Cells[3].Value;
                        dtrow[4] = dtgv.Cells[4].Value;
                        dtrow[5] = dtgv.Cells[5].Value;
                        dataTable.Rows.Add(dtrow);
                    }
                    exportExcel2(dataTable, "THANH", "THANH");
                    MessageBox.Show("Xuất thành công <3");
                }
                catch (Exception ex) {
                    MessageBox.Show("Xuất thất bai :< Errors : " + ex.Message);
                }
            }

        }
        public void exportExcel2(DataTable dataTable, string sheetName, string title) {


            //Tạo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "F1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề hàng
            Microsoft.Office.Interop.Excel.Range cl1_c = oSheet.get_Range("A2", "A2");

            cl1_c.Value2 = "Bill Information : ";

            cl1_c.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2_c = oSheet.get_Range("A3", "A3");
            Microsoft.Office.Interop.Excel.Range cl2_c_value = oSheet.get_Range("B3", "B3");

            cl2_c.Value2 = "ID";

            cl2_c.ColumnWidth = 12;

            cl2_c_value.Value2 = textboxMaPhieuNhap_Detail.Text;

            Microsoft.Office.Interop.Excel.Range cl3_c = oSheet.get_Range("A4", "A4");
            Microsoft.Office.Interop.Excel.Range cl3_c_value = oSheet.get_Range("B4", "B4");

            cl3_c.Value2 = "DATE";

            cl3_c.ColumnWidth = 12;

            cl3_c_value.Value2 = textBoxImportDate_Detail.Text;

            Microsoft.Office.Interop.Excel.Range cl4_c = oSheet.get_Range("A5", "A5");
            Microsoft.Office.Interop.Excel.Range cl4_c_value = oSheet.get_Range("B5", "B5");

            cl4_c.Value2 = "SUPPLIER";

            cl4_c.ColumnWidth = 12;
            cl4_c_value.Value2 = textBoxBrand_Detail.Text;

            Microsoft.Office.Interop.Excel.Range cl5_c = oSheet.get_Range("A6", "A6");
            Microsoft.Office.Interop.Excel.Range cl5_c_value = oSheet.get_Range("B6", "B6");

            cl5_c.Value2 = "STAFF";
            cl5_c_value.Value2 = textBoxStaff_Detail.Text;

            cl5_c.ColumnWidth = 12;

            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A7", "A7");

            cl1.Value2 = "Size";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B7", "B7");

            cl2.Value2 = "Id";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C7", "C7");

            cl3.Value2 = "Product";
            cl3.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D7", "D7");

            cl4.Value2 = "Quantity";

            cl4.ColumnWidth = 10.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E7", "E7");

            cl5.Value2 = "Price";

            cl5.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F7", "F7");

            cl6.Value2 = "Sum money";

            cl6.ColumnWidth = 18.5;

           

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A7", "F7");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++) {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++) {
                    arr[row, col] = dataRow[col];
                }
            }
           

            //Thiết lập vùng điền dữ liệu

            int rowStart = 9;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 2;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            //Sum money
            Microsoft.Office.Interop.Excel.Range c_sum_1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 1, 1];
            Microsoft.Office.Interop.Excel.Range c_sum_2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd + 1, columnEnd];
            Microsoft.Office.Interop.Excel.Range range_sum = oSheet.get_Range(c_sum_1, c_sum_2);
            range_sum.MergeCells = true;
            range_sum.Value2 = "Sum money : " + textBox_TongTien_Detail.Text;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            Microsoft.Office.Interop.Excel.Range range2 = oSheet.get_Range(head, c2);
            range2.BorderAround();


            // Căn giữa cột mã nhân viên

            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void searchBrandCombobox(object sender, EventArgs e)
        {
            DataRowView br = (DataRowView)guna2ComboBoxBrand.SelectedItem;
            string maBrand = br.Row["id"].ToString();
            dataGridViewSanPham.DataSource = productsBUS.getProductsToBrand(maBrand);
        }

        private void searchNameProducts(object sender, EventArgs e)
        {
            string keyword = guna2TextBoxSearchNameProduct.Text;
            if (!string.IsNullOrEmpty(keyword))
            {
                dataGridViewSanPham.DataSource = productsBUS.searchProductsToBrand(keyword);
            }
            else
            {
                dataGridViewSanPham.DataSource = productsBUS.getProducts();
            }
        }

        private void reLoadDataGridViewProduct(object sender, EventArgs e)
        {
            dataGridViewSanPham.DataSource = importProductBUS.getProducts();
            guna2TextBoxSearchNameProduct.Text = "";
        }
    }
}
