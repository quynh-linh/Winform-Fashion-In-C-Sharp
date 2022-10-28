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
        
       
        public BrandGUI()
        {
            InitializeComponent();
            
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
                Id = Name[0].ToString().ToUpper();
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
                BrandDTO brDTO = new BrandDTO(id, name);
                if (brBUS.CheckKeyID(id))
                {
                    MessageBox.Show("Trùng khóa chính");
                } else
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
                BrandDTO brandDTO = new BrandDTO(id, name);
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
            else
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu !");

            }
        }

        private void btn_deleteBrand_Click(object sender, EventArgs e)
        {
            if(dgv_brand.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_brand.SelectedRows[0];
                String id = row.Cells[0].Value.ToString();
                if (brBUS.deleteBrand(id))
                {
                    MessageBox.Show("Xóa thành công !");
                    dgv_brand.DataSource = brBUS.getBrand();
                    removeLoadDb();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công !");
                }
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
    }
}
