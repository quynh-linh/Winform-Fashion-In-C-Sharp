using System;
using System.Windows.Forms;
using BUS;
using System.Text.RegularExpressions;
using DTO;
using Guna.UI2.WinForms;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAO;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GUI
{
    public partial class BrandGUI : Form
    {
        private BrandBUS brBUS = new BrandBUS();
        
       
        public BrandGUI(string role_Manipulative)
        {
            InitializeComponent();
            if (!role_Manipulative.Equals("Được thay đổi"))
            {
                btn_addBrand.Enabled = false;
                btn_deleteBrand.Enabled = false;
                btn_editBrand.Enabled = false;
                btn_exportExcelBrand.Enabled = false;
                btn_importExcelBrand.Enabled = false;
            }

        }

        public void BrandGUI_Load(object sender, EventArgs e)
        {
            dgv_brand.DataSource = brBUS.getBrand();
        }

        private void btn_addBrand_Click(object sender, EventArgs e)
        {
            brBUS.docBD();
            ArrayList list = new ArrayList();
            list = brBUS.GetArrayListBrand();
            string Name = utf8Convert3(Txt_nameBrand.Text.Trim() + "");
            string Id = "";
            int num = 0;
            if (!string.IsNullOrEmpty(Name))
            {
                //Gán Id = chữ cái đầu của Name
                Id = Name[0].ToString().ToUpper();// manh ne
                //Duyệt chuỗi nối Id
                for (int i = 1; i < Name.Length; i++)
                {
                    if (Name[i - 1].ToString() == " ")
                    {

                        Id += Name[i].ToString().ToUpper();
                    }
                }
                string check_Id;
                foreach (BrandDTO br in list)
                {
                    check_Id = Id + num + "";
                    if (brBUS.CheckKeyID(check_Id))
                    {
                        num++;

                    }
                }
                Id = Id + num + "";
                Txt_MaBrand.Text = Id;
            }
            else Txt_MaBrand.Text = "";
            //
            if (Txt_MaBrand.Text != "" || Txt_nameBrand.Text != "")
            {
                String id = Txt_MaBrand.Text + "";
                String name = Txt_nameBrand.Text + "";
                BrandDTO brDTO = new BrandDTO(id, name,0);
                if (brBUS.CheckKeyID(id))
                {
                    MessageBox.Show("Trùng khóa chính");
                } else
                {
                    //Kiểm tra tên trùng
                    string namee = Txt_nameBrand.Text;
                    bool flag = true;
                    for (int i = 0; i < dgv_brand.Rows.Count; i++)
                    {
                        if (namee == dgv_brand.Rows[i].Cells[1].FormattedValue.ToString())
                        {
                            MessageBox.Show("Tên thương hiệu sản phẩm đã tồn tại");
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        if (brBUS.addBrand(brDTO))
                        {
                            MessageBox.Show("Thêm thành công!");
                            removeLoadDb();
                            dgv_brand.DataSource = brBUS.getBrand();
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công !");
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin !");
            }
        }

        private void btn_editBrand_Click(object sender, EventArgs e)
        {

            if(Txt_MaBrand.Text != "" || Txt_nameBrand.Text != "")
            {
                String id = Txt_MaBrand.Text + "";
                String name = Txt_nameBrand.Text + "";
                if (brBUS.check_Name(id, name))
                {
                    MessageBox.Show("Tên thương hiệu sản phẩm đã tồn tại");
                }
                else
                {
                    BrandDTO brandDTO = new BrandDTO(id, name, 0);
                    if (brBUS.editBrand(brandDTO))
                    {
                        MessageBox.Show("Sửa thành công !");
                        removeLoadDb();
                        dgv_brand.DataSource = brBUS.getBrand();

                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công !");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu !");

            }
        }

        private void btn_deleteBrand_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa thương hiệu " + dgv_brand.CurrentRow.Cells[1].Value.ToString() + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string Id = dgv_brand.CurrentRow.Cells[0].Value.ToString();
                Console.WriteLine("ia barna : " + Id);
                brBUS.deleteBrand(Id);
                dgv_brand.DataSource = brBUS.getBrand();
                MessageBox.Show("Xóa thành công");
            }
        }
        public static string utf8Convert3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        public void removeLoadDb()
        {
            Txt_MaBrand.Text = "";
            Txt_nameBrand.Text = "";
        }

        private void loadIdautoUp(object sender, EventArgs e)
        {
           
        }

        private void dgv_brand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex != -1)
            {
                dgv_brand.CurrentCell.Selected = true;
                Txt_MaBrand.Text = dgv_brand.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                Txt_nameBrand.Text = dgv_brand.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            }
        }

        private void btn_importExcelBrand_Click(object sender, EventArgs e) {
            OpenFileDialog opened = new OpenFileDialog();
            opened.Title = "Nhập -->> - - - ->";
            opened.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (opened.ShowDialog() == DialogResult.OK) {
                try {
                    // get datatable from excel
                    System.Data.DataTable dataTable = AccountGUI.importExcel(opened.FileName);

                    // insert to database brand
                    brBUS.insertBrands(dataTable);

                    //get all product
                    System.Data.DataTable dataTable2 = brBUS.getBrand();

                    // update dataGridView
                    dgv_brand.DataSource = dataTable2;
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

        private void btn_exportExcelBrand_Click(object sender, EventArgs e) {
            SaveFileDialog saved = new SaveFileDialog();
            saved.Title = "Xuất -->> - - - ->";
            saved.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saved.ShowDialog() == DialogResult.OK) {
                try {
                    AccountGUI.exportExcel(saved.FileName, dgv_brand);
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
