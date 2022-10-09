using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class RoleGUI : Form
    {
        public RoleGUI()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Add_Or_Fix_RoleGUI a = new Add_Or_Fix_RoleGUI("Add Permission","Thêm");
            a.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Add_Or_Fix_RoleGUI a = new Add_Or_Fix_RoleGUI("Fix Permission", "Sửa");
            a.Show();
        }
    }
}
