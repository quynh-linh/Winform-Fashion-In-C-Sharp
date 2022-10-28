using System;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class RoleGUI : Form
    {
        RoleBUS roleBUS = new RoleBUS();
        public RoleGUI()
        {
            InitializeComponent();
            dataGridView1.DataSource = roleBUS.getAllRole();
        }

        //btn Thêm
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Tự sinh ID
            string check_Id = "";
            int num = 0;
            for( int i = 0; i< dataGridView1.RowCount; i++)
            {
                check_Id = "Q" + num;
                if ( check_Id == dataGridView1.Rows[i].Cells[0].FormattedValue.ToString()) num++;
            }

            string Id = "Q" + num;
            Add_Or_Fix_RoleGUI a = new Add_Or_Fix_RoleGUI("Add Permission","Thêm",Id);
            a.Show();
        }

        //btn Sửa
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //Lấy ID dc chọn trong datagridview
            string Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Add_Or_Fix_RoleGUI a = new Add_Or_Fix_RoleGUI("Fix Permission", "Sửa", Id);
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
    }
}
