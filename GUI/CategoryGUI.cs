using System;
using System.Windows.Forms;
using BUS;
using DTO;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class CategoryGUI : Form
    {
        CategoryBUS categoryBUS = new CategoryBUS();
        public CategoryGUI(string role_Manipulative)
        {
            InitializeComponent();
            if (!role_Manipulative.Equals("Được thay đổi"))
            {
                create_Id.Enabled = false;
                btn_Add.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Fix.Enabled = false;
            }
            txt_Id_Category.Text = "CT" + categoryBUS.count();
        }

        private void CategoryGUI_Load(object sender, EventArgs e)
        {
            dataGridViewCategory.DataSource = categoryBUS.getAllCategory();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Name_Category.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu");
            }
            else if (string.IsNullOrEmpty(txt_Id_Category.Text))
            {
                MessageBox.Show("Vui lòng tạo mã");
            }
            else
            {
                //Kiểm tra tên trùng
                string name = txt_Name_Category.Text;
                bool flag = true;
                for (int i = 0; i < dataGridViewCategory.Rows.Count; i++)
                {
                    if (name == dataGridViewCategory.Rows[i].Cells[1].FormattedValue.ToString())
                    {
                        MessageBox.Show("Tên loại sản phẩm đã tồn tại");
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    CategoryDTO categoryDTO = new CategoryDTO(txt_Id_Category.Text, txt_Name_Category.Text,0);

                    if (categoryBUS.addCategory(categoryDTO))
                    {
                        MessageBox.Show("Thêm thành công");
                        dataGridViewCategory.DataSource = categoryBUS.getAllCategory();
                        reloaddatagridView();
                    }
                    else MessageBox.Show("Thêm không thành công");
                }
            }
        }


        private void btn_Fix_Click(object sender, EventArgs e)
        {
            if (txt_Name_Category.Text != "")
            {
                String id = txt_Id_Category.Text;
                String name = txt_Name_Category.Text;

                if (categoryBUS.check_Name(id,name))
                {
                    MessageBox.Show("Tên loại sản phẩm đã tồn tại");
                }
                else
                {
                    CategoryDTO categoryDTO = new CategoryDTO(id, name,0);

                    if (categoryBUS.fixCategory(categoryDTO))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        dataGridViewCategory.DataSource = categoryBUS.getAllCategory(); // refresh datagridview
                        reloaddatagridView();
                    }
                    else MessageBox.Show("Cập nhật ko thành công");
                }
            }
            else MessageBox.Show("Vui lòng nhập đủ dữ liệu");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string Id = dataGridViewCategory.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc muốn xóa thể loại " + dataGridViewCategory.CurrentRow.Cells[1].Value.ToString() + "?\n Hiện đang có "+categoryBUS.count_Product_Belong_Category(Id)+" sản phẩm thuộc thể loại này!", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                categoryBUS.deleteCategory(Id);
                categoryBUS.delete_Product_From_Category(Id);
                dataGridViewCategory.DataSource = categoryBUS.getAllCategory();
                MessageBox.Show("Xóa thành công");
            }
        }

        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCategory.CurrentCell.Selected = true;
            if (e.RowIndex != -1)
            {
                txt_Id_Category.Text = dataGridViewCategory.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                txt_Name_Category.Text = dataGridViewCategory.Rows[e.RowIndex].Cells["nameCategory"].FormattedValue.ToString();
            }
        }

        private void reloaddatagridView()
        {
            txt_Id_Category.Text = "";
            txt_Name_Category.Text = "";
            txt_Search.Text = "";
        }

        //Nút tạo mã
        private void create_Id_Click(object sender, EventArgs e)
        {
            reloaddatagridView();           
            txt_Id_Category.Text = "CT" + categoryBUS.count(); 
        }

        //Search

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_Search.Text;
            if (!string.IsNullOrEmpty(keyword))
            {
                dataGridViewCategory.DataSource = categoryBUS.searchCategory(keyword);
            }
            else
            {
                dataGridViewCategory.DataSource = categoryBUS.getAllCategory();
            }
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e) {

        }

        private void import_Click(object sender, EventArgs e) {
            OpenFileDialog opened = new OpenFileDialog();
            opened.Title = "Nhập -->> - - - ->";
            opened.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (opened.ShowDialog() == DialogResult.OK) {
                try {
                    // get datatable from excel
                    System.Data.DataTable dataTable = AccountGUI.importExcel(opened.FileName);

                    // insert to database product
                    categoryBUS.insertCategories(dataTable);

                    //get all product
                    System.Data.DataTable dataTable2 = categoryBUS.getAllCategory();

                    // update dataGridView
                    dataGridViewCategory.DataSource = dataTable2;
                    MessageBox.Show("nhập thành công <3");
                }
                catch (FormatException ex1) {
                    MessageBox.Show("Cột Không đúng định dạng");
                }
                catch (ApplicationException ex2) {
                    MessageBox.Show(ex2.Message);
                }
                catch (ArgumentException ex3) {
                    MessageBox.Show("Định dạng cột không đúng");
                }
            }
        }

        private void export_Click(object sender, EventArgs e) {
            SaveFileDialog saved = new SaveFileDialog();
            saved.Title = "Xuất -->> - - - ->";
            saved.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saved.ShowDialog() == DialogResult.OK) {
                try {
                    AccountGUI.exportExcel(saved.FileName, dataGridViewCategory);
                    MessageBox.Show("Xuất thành công <3");
                }
                catch (Exception ex) {
                    MessageBox.Show("Xuất thất bai :< Errors : " + ex.Message);
                    MessageBox.Show("Phải tắt file excel khi thực hiện thao tác");
                }
            }
        }
    }
}
