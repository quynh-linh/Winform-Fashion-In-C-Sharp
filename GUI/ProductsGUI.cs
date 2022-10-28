using BUS;
using DTO;
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
        public ProductsGUI()
        {
            InitializeComponent();
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
            comboboxBrand.SelectedIndex = 0;
            comboboxCategory.SelectedIndex = 0;
            comboboxSize.SelectedIndex = 0;
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
                int quantity = int.Parse(textboxQuantity.Text);
                String nameImage = Path.GetFileName(pictureBox.ImageLocation);
                String brand = br.Row["id"].ToString();
                String category = ct.Row["id"].ToString();
                String size = s.Row["id"].ToString();
                ProductDTO pd = new ProductDTO(id, name, price, nameImage, des, brand, category, size, quantity);
                if (File.Exists(Application.StartupPath +  @"\Image\" + nameImage))
                {
                    if (productsBUS.addProducts(pd))
                    {
                        MessageBox.Show("Thêm thành công","Thông báo");
                        loadDataGridview();
                        reloadForm();
                    }             
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo");
                    }   
                }
                else
                {
                    if (productsBUS.addProducts(pd))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        loadDataGridview();
                        reloadForm();
                        File.Copy(openFileDialog.FileName, Application.StartupPath + @"\Image\" + nameImage);
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo");
                    }  
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
                String size = s.Row["id"].ToString();
                ProductDTO pd = new ProductDTO(id, name, price, nameImage, des, brand, category, size, quantity);
                if (File.Exists(Application.StartupPath + @"\Image\" + nameImage))
                {
                    if (productsBUS.editProducts(pd))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo");
                        loadDataGridview();
                        reloadForm();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công", "Thông báo");
                    }
                }
                else
                {
                    if (productsBUS.editProducts(pd))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo");
                        loadDataGridview();
                        reloadForm();
                        File.Copy(openFileDialog.FileName, Application.StartupPath + @"\Image\" + nameImage);
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công", "Thông báo");
                    }
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
    }
}
