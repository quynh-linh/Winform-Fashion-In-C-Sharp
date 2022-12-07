using System;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class RoleGUI : Form
    {
        RoleBUS roleBUS = new RoleBUS();
        Home home;
        public RoleGUI(String role_Manipulative, Home home)
        {
            InitializeComponent();
            dataGridView1.DataSource = roleBUS.getAllRole();
            if(role_Manipulative.Equals("Được thay đổi"))
            {

            }
            else disable();

            this.home = home;
        }

        public void disable()
        {
            guna2Button1.Enabled = false;
            guna2Button4.Enabled = false;
            guna2Button3.Enabled = false;
        }

        //btn Thêm
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Tự sinh ID
            string Id = "Q" + roleBUS.count();
            Add_Or_Fix_RoleGUI a = new Add_Or_Fix_RoleGUI("Add Permission","Thêm",Id, this, this.home);
            a.Show();
        }

        //btn Sửa
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //Lấy ID dc chọn trong datagridview
            string Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Add_Or_Fix_RoleGUI a = new Add_Or_Fix_RoleGUI("Fix Permission", "Sửa", Id, this, this.home);
            a.Show();
            dataGridView1.DataSource = roleBUS.getAllRole();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Bạn có chắc muốn xóa vai trò "+ dataGridView1.CurrentRow.Cells[1].Value.ToString() +"?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
           {
                string Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                roleBUS.deleteRole(Id);
                dataGridView1.DataSource = roleBUS.getAllRole();
                MessageBox.Show("Xóa thành công");
            }
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = roleBUS.searchRole(TbSearch.Text);
        }

        private void guna2Button2_Click(object sender, EventArgs e) {
            OpenFileDialog opened = new OpenFileDialog();
            opened.Title = "Nhập -->> - - - ->";
            opened.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (opened.ShowDialog() == DialogResult.OK) {
                try {
                    // get datatable from excel
                    System.Data.DataTable dataTable = AccountGUI.importExcel(opened.FileName);

                    // insert to database role
                    roleBUS.insertRoles(dataTable);

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
                finally {
                    //get all role
                    System.Data.DataTable dataTable2 = roleBUS.getAllRole();

                    // update dataGridView
                    dataGridView1.DataSource = dataTable2;
                }
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e) {
            SaveFileDialog saved = new SaveFileDialog();
            saved.Title = "Xuất -->> - - - ->";
            saved.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saved.ShowDialog() == DialogResult.OK) {
                try {
                    AccountGUI.exportExcel(saved.FileName, dataGridView1);
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
