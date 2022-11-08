using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class BillGui : Form
    {
        string role_Manipulative;
        public BillGui(string role_Manipulative)
        {
            InitializeComponent();
            this.role_Manipulative = role_Manipulative;
            UC_Bill_ImportGui uC_Bill_ImportGui = new UC_Bill_ImportGui(role_Manipulative);
            addUserControl(uC_Bill_ImportGui);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelBillContainer.Controls.Clear();
            panelBillContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void BtnBillImport_Click(object sender, EventArgs e)
        {
            UC_Bill_ImportGui uC_Bill_ImportGui = new UC_Bill_ImportGui(role_Manipulative);
            addUserControl(uC_Bill_ImportGui);
        }

        private void BtnBillExport_Click(object sender, EventArgs e)
        {
            UC_Bill_ExportGui uC_Bill_ExportGui = new UC_Bill_ExportGui(role_Manipulative);
            addUserControl(uC_Bill_ExportGui);
        }
    }
}
