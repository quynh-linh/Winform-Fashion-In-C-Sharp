using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class CategoryGUI : Form
    {
        CategoryBUS categoryBUS = new CategoryBUS();
        public CategoryGUI()
        {
            InitializeComponent();
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
                    CategoryDTO categoryDTO = new CategoryDTO(txt_Id_Category.Text, txt_Name_Category.Text);

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

                CategoryDTO categoryDTO = new CategoryDTO(id, name);

                if (categoryBUS.fixCategory(categoryDTO))
                {
                    MessageBox.Show("Cập nhật thành công");
                    dataGridViewCategory.DataSource = categoryBUS.getAllCategory(); // refresh datagridview
                    reloaddatagridView();
                }
                else
                {
                    MessageBox.Show("Cập nhật ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa thể loại " + dataGridViewCategory.CurrentRow.Cells[1].Value.ToString() + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string Id = dataGridViewCategory.CurrentRow.Cells[0].Value.ToString();
                categoryBUS.deleteCategory(Id);
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
            string Id = "CT";
            int num = 0;

            //check Id có trùng vs các Id đã tồn tại hay k
            string check_Id;
            for (int i = 0; i < dataGridViewCategory.Rows.Count; i++)
            {
                check_Id = Id + num + "";
                if (check_Id == dataGridViewCategory.Rows[i].Cells[0].FormattedValue.ToString())
                    num++;
            }
            Id += num + "";
            txt_Id_Category.Text = Id;
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
    }
}
