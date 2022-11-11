using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using BUS;
using DTO;
using Guna.UI2.WinForms;
using NPOI.SS.Util;

namespace GUI
{
    public partial class ImportProductsGUI : Form
    {
        ImportProductBUS importProductBUS = new ImportProductBUS();
        BrandBUS brandBUS = new BrandBUS();
        private int id_nv;
        public ImportProductsGUI(string role_Manipulative , string name_Id , int id_Staff)
        {
            InitializeComponent();
            if (!role_Manipulative.Equals("Nhập hàng"))
            {
                
            }
            textBoxStaff.Text = name_Id;
            id_nv = id_Staff;
            loadCBBBrand();
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

        private void addProductsToCart(object sender, EventArgs e)
        {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dataGridView1);
            newRow.Cells[0].Value = textBoxMaSanPham.Text;
            newRow.Cells[1].Value = textBoxMaPhieu.Text;
            newRow.Cells[2].Value = textBoxQuantity.Text;
            newRow.Cells[3].Value = textBoxPrice.Text;
            Double tongTien = Convert.ToInt32(textBoxPrice.Text) * Convert.ToInt32(textBoxQuantity.Text);
            newRow.Cells[4].Value = tongTien;
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

        private void addImportProducts(object sender, EventArgs e)
        {
            string format = "dd/MM/yyyy";
            DateTime now = DateTime.Now;
            // ==> 18/03/2016 23:49:39
            string ngayNhap = now.ToString(format);
            String maPhieuNhap = textBoxMaPhieuNhap.Text;
            int maNhanVien =  id_nv;
            DataRowView br =  (DataRowView)comboboxBrand.SelectedItem;
            string maBrand =  br.Row["id"].ToString();
            double tongTien = Convert.ToDouble(textBoxSumMoney.Text);
            if(ngayNhap != "" || maNhanVien > -1 || maBrand != "" || tongTien > 0)
            {
                ImprotProductDTO improtProductDTO = new ImprotProductDTO(maPhieuNhap,ngayNhap, maNhanVien, maBrand, tongTien);
                if (importProductBUS.addImportProduct(improtProductDTO))
                {
                    MessageBox.Show("Thêm thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if (guna2DataGridView1.Rows.Count > 0)
                    {
                        for (int i = 0; i < guna2DataGridView1.Rows.Count; i++)
                        {
                            string maSP = Convert.ToString(guna2DataGridView1.Rows[i].Cells[0].Value);
                            int soLuong = Convert.ToInt32(guna2DataGridView1.Rows[i].Cells[2].Value);
                            double giaNhap = Convert.ToDouble(guna2DataGridView1.Rows[i].Cells[3].Value);
                            double sumMoney = Convert.ToDouble(guna2DataGridView1.Rows[i].Cells[4].Value);
                            if(maSP != "" || soLuong > 0 || giaNhap > 0 || sumMoney > 0)
                            {
                                importProductBUS.addDetailImportProduct(new detail_importProductDTO(maSP, soLuong, giaNhap, sumMoney, maPhieuNhap));
                                importProductBUS.updatePriceAndQuantity(giaNhap, soLuong, maSP);
                                dataGridViewSanPham.DataSource = importProductBUS.getProducts();
                                removeRowAllCart();
                                textBoxMaPhieuNhap.Text = "";
                            }   
                        }
                    }
                }else
                {
                    MessageBox.Show("Thêm không thành công", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
