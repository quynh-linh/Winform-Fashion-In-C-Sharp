using DAO;
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
    
    public partial class SellGui : Form
    {
        MySQLConnection sql;
 
        public SellGui()
        {
            InitializeComponent();
            sql = new MySQLConnection();

        }
        
        private void uC_Sell_Item1_Click(object sender, EventArgs e)
        {
            Sell_DetailGUI sell_DetailGUI = new Sell_DetailGUI();
            sell_DetailGUI.Show();
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //
        private void GetData()
        {
           
        }

        private void SellGui_Load(object sender, EventArgs e)
        {

        }
    }
}
