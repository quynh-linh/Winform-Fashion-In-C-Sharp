using BUS;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class ProductsGUI : Form
    {
        BrandBUS brandBUS = new BrandBUS();
        CategoryBUS categoryBUS = new CategoryBUS();
        SizeProductsBUS sizeProductsBUS = new SizeProductsBUS();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        ProductsBUS productsBUS = new ProductsBUS();
        public ProductsGUI(string role_Manipulative)
        {
            InitializeComponent();
            if (!role_Manipulative.Equals("Được thay đổi"))
            {
                guna2Button5.Enabled = false;
                guna2Button4.Enabled = false;
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnRemove.Enabled = false;
            }
        }
        private void loadCBBBrand()
        {
            comboboxBrand.DataSource = brandBUS.getBrand();
            comboboxBrand.DisplayMember = "name";
            comboboxBrand.ValueMember = "id";
            
        }
        private void loadCBBCategory()
        {
            comboboxCategory.DataSource = categoryBUS.getAllCategory();
            comboboxCategory.DisplayMember = "nameCategory";
            comboboxCategory.ValueMember = "id";
            
        }
        private void loadCBBSize()
        {
            comboboxSize.DataSource = sizeProductsBUS.getSize();
            comboboxSize.DisplayMember = "name";
            comboboxSize.ValueMember = "id";
            
        }
        private void loadDataGridview()
        {
            dataGridView.DataSource = productsBUS.getProducts();
        }

        private void ProductsGUI_Load(object sender, EventArgs e)
        {
            
            loadCBBBrand();
            loadCBBCategory();
            loadCBBSize();
            loadDataGridview();
        }
        private void reloadForm()
        {
            textboxName.Text = " ";
            textBoxId.Text = " ";
            textboxDes.Text = " ";
            textboxQuantity.Text = "  ";
            textboxPrice.Text = " ";
            pictureBox.Image = null;
        }

        private void imagebtnLoadFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(openFileDialog.FileName);
                pictureBox.ImageLocation = openFileDialog.FileName;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dataGridView.CurrentCell.Selected = true;
                textBoxId.Text = dataGridView.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                comboboxBrand.Text = dataGridView.Rows[e.RowIndex].Cells["nameBrand"].FormattedValue.ToString();
                comboboxCategory.Text = dataGridView.Rows[e.RowIndex].Cells["nameCate"].FormattedValue.ToString();
                comboboxSize.Text = dataGridView.Rows[e.RowIndex].Cells["sizename"].FormattedValue.ToString();
                textboxName.Text = dataGridView.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                textboxPrice.Text = dataGridView.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
                textboxQuantity.Text = dataGridView.Rows[e.RowIndex].Cells["quantity"].FormattedValue.ToString();
                textboxDes.Text = dataGridView.Rows[e.RowIndex].Cells["description"].FormattedValue.ToString();
                String nameImage = dataGridView.Rows[e.RowIndex].Cells["image"].FormattedValue.ToString();
                if (!nameImage.Equals(""))
                {
                    pictureBox.Image = new Bitmap(Application.StartupPath + @"\Image\" + nameImage);
                    pictureBox.ImageLocation = Application.StartupPath + @"\Image\" + nameImage;
                } else
                {
                    pictureBox.Image = null;
                    pictureBox.ImageLocation = null;
                }
            }
        }
        private void addProducts(object sender, EventArgs e)
        {
            if (textboxName.Text == " " || textBoxId.Text == " " || textboxDes.Text == " ")
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu", "Cảnh báo");
            } else
            {
                //
                DataRowView br = (DataRowView)comboboxBrand.SelectedItem;
                DataRowView ct = (DataRowView)comboboxCategory.SelectedItem;
                DataRowView s = (DataRowView)comboboxSize.SelectedItem;
                //
                String id = textBoxId.Text;
                String name = textboxName.Text;
                Double price = Convert.ToDouble(textboxPrice.Text);
                String des = textboxDes.Text;
                int quantity = Convert.ToInt32(textboxQuantity.Text);
                String nameImage = Path.GetFileName(pictureBox.ImageLocation);
                String brand = br.Row["id"].ToString();
                String category = ct.Row["id"].ToString();
                int size = Convert.ToInt32(s.Row["id"]);
                ProductDTO pd = new ProductDTO(id, name, price, nameImage, des, brand, category, size, quantity);
                if (File.Exists(Application.StartupPath + @"\Image\" + nameImage))
                {
                   MessageBox.Show(productsBUS.checkAddProducts(pd), "Thông báo");
                   loadDataGridview();
                   reloadForm();
                }
                else
                 {
                   MessageBox.Show(productsBUS.checkAddProducts(pd), "Thông báo");
                   loadDataGridview();
                   reloadForm();
                   File.Copy(openFileDialog.FileName, Application.StartupPath + @"\Image\" + nameImage);
                }  
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (textboxName.Text == " " || textBoxId.Text == " " || textboxDes.Text == " ")
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu", "Cảnh báo");
            }
            else
            {
                //
                DataRowView br = (DataRowView)comboboxBrand.SelectedItem;
                DataRowView ct = (DataRowView)comboboxCategory.SelectedItem;
                DataRowView s = (DataRowView)comboboxSize.SelectedItem;
                //
                String id = textBoxId.Text;
                String name = textboxName.Text;
                Double price = Convert.ToDouble(textboxPrice.Text);
                String des = textboxDes.Text;
                int quantity = int.Parse(textboxQuantity.Text);
                String nameImage = Path.GetFileName(pictureBox.ImageLocation);
                String brand = br.Row["id"].ToString();
                String category = ct.Row["id"].ToString();
                int size = Convert.ToInt32(s.Row["id"]);
                ProductDTO pd = new ProductDTO(id, name, price, nameImage, des, brand, category, size, quantity);
                if (File.Exists(Application.StartupPath + @"\Image\" + nameImage))
                {
                   MessageBox.Show(productsBUS.editProducts(pd), "Thông báo");
                   loadDataGridview();
                   reloadForm();
                }
                else
                {
                    MessageBox.Show(productsBUS.editProducts(pd), "Thông báo");
                    loadDataGridview();
                    reloadForm();
                    File.Copy(openFileDialog.FileName, Application.StartupPath + @"\Image\" + nameImage);
                }
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            String idProducts = textBoxId.Text;
            String nameImage = Path.GetFileName(pictureBox.ImageLocation);
            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (productsBUS.removeProducts(idProducts))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    //System.IO.File.Delete(Application.StartupPath + @"\Image\" + nameImage);
                    loadDataGridview();
                    reloadForm();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo");
                }
            } 
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text;
            if (!string.IsNullOrEmpty(keyword))
            {
                dataGridView.DataSource = productsBUS.searchProducts(keyword);
            }
            else
            {
                dataGridView.DataSource = productsBUS.getProducts();
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e) {
            SaveFileDialog saved = new SaveFileDialog();
            saved.Title = "Xuất -->> - - - ->";
            saved.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saved.ShowDialog() == DialogResult.OK) {
                try {
                    AccountGUI.exportExcel(saved.FileName, dataGridView);
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

                    // insert to database product
                    productsBUS.insertProducts(dataTable); 
                    
                    //get all product
                    System.Data.DataTable dataTable2 = productsBUS.getProducts();

                    // update dataGridView
                    dataGridView.DataSource = dataTable2;
                    MessageBox.Show("nhập thành công <3");
                }
                catch (FormatException ex1) {
                    MessageBox.Show("Cột Không đúng định dạng (int) và (string)");
                    MessageBox.Show("Chi tiết lỗi : Chỉnh giá trị từng dòng ('Thương hiệu', 'Danh mục, 'Kích cỡ') trong file excel về Mã(id) thay vì Tên(name) ");
                }
                catch (ApplicationException ex2) {
                    MessageBox.Show(ex2.Message);
                }
                catch (ArgumentException ex3) {
                    MessageBox.Show("Định dạng cột không đúng");
                }
                finally {
                    //get all product
                    System.Data.DataTable dataTable2 = productsBUS.getProducts();

                    // update dataGridView
                    dataGridView.DataSource = dataTable2;
                }
            }
        }
    }
}
