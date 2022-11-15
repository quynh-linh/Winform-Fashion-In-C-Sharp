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
        //public ArrayList<UC_Sell_Item> itemProduct = new ArrayList<UC_Sell_Item>();
        public SellGui(string role_Manipulative)
        {
            InitializeComponent();
            sql = new MySQLConnection();
            if (!role_Manipulative.Equals("Bán hàng "))
            {
                guna2Button1.Enabled = false;
                guna2Button2.Enabled = false;
            }
            ArrayList list = new ArrayList();
            list = sellBUS.getArrayListSell();
            for (int i = 0; i < list.Count; i++)
            {
                addItem((ProductDTO)list[i]);

            }


        }
        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //
        private void GetData()
        {

        }
        public void addItem(ProductDTO data)
        {
            UC_Sell_Item item = new UC_Sell_Item();
            item.setData(data);
            item.BackColor = Color.White;
            FlpSanPham.Controls.Add(item);

        }
        private void SellGui_Load(object sender, EventArgs e)
        {
            // ProductDTO prd = new ProductDTO();
            //var data = sellBUS.getArrayListSell(prd);
            //var list = new UC_Sell_Item[data.Count];
            //int i = 0;

            //itemProduct = new List<UC_Sell_Item>();
            //foreach (var item in data)
            //{
            // list[i] = new UC_Sell_Item();
            //list[i].uri_product = @"Image\" + item;
            //list[i].name = item + "";
            //list[i].price = item + "";
            //list[i].loadImageAsync();
            // itemProduct.Add(list[i]);
            //i++;
            // }
            // FlpSanPham.Controls.AddRange(list);
        }
    }
}
