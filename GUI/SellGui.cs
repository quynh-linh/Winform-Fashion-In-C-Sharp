using BUS;
using DAO;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections;
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
        private SellBUS sellBUS = new SellBUS();
        public static ArrayList listOder = new ArrayList();
        //public ArrayList<UC_Sell_Item> itemProduct = new ArrayList<UC_Sell_Item>();
        public SellGui(string role_Manipulative)
        {
            InitializeComponent();
            sql = new MySQLConnection();
            if (!role_Manipulative.Equals("Bán hàng "))
            {
                guna2Button1.Enabled = false;
                //guna2Button2.Enabled = false;
            }
            // do sp vao flowlayout
            ArrayList list = new ArrayList();
            list = sellBUS.getArrayListSell();
            for (int i = 0; i < list.Count; i++)
            {
                addItem((ProductDTO)list[i]);

            }
            //Sell_DetailGUI sell = new Sell_DetailGUI();
            
            for (int i = 0; i < listOder.Count; i++)
            {
                addItemOder((ProductDTO)listOder[i]);
            }

        }

        public SellGui()
        {
        }

        // add sp zo usercontrol
        public void addItem(ProductDTO data)
        {
            UC_Sell_Item item = new UC_Sell_Item();
            item.setData(data);
            item.BackColor = Color.White;
            FlpSanPham.Controls.Add(item);

        }
        //add thong tin mua vo usercontrol
        public void addItemOder(ProductDTO data)
        {
            UC_oder oder = new UC_oder(data);
            oder.setDataOder(data);
            flp_oder.Controls.Add(oder);

        }
    }
}
