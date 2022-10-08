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
    public partial class BillGui : Form
    {
        public BillGui()
        {
            InitializeComponent();
            UC_Bill_ImportGui uC_Bill_ImportGui = new UC_Bill_ImportGui();
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
            UC_Bill_ImportGui uC_Bill_ImportGui = new UC_Bill_ImportGui();
            addUserControl(uC_Bill_ImportGui);
        }

        private void BtnBillExport_Click(object sender, EventArgs e)
        {
            UC_Bill_ExportGui uC_Bill_ExportGui = new UC_Bill_ExportGui();
            addUserControl(uC_Bill_ExportGui);
        }
    }
}
