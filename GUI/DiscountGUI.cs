using System;
using BUS;
using DTO;
using System.Windows.Forms;

namespace GUI
{
    public partial class DiscountGUI : Form
    {
        DiscountBUS dcBUS = new DiscountBUS();
        public DiscountGUI()
        {
            InitializeComponent();
            fillCombobox();
        }

        private void DiscountGUI_Load(object sender, EventArgs e)
        {
            dgv_discount.DataSource = dcBUS.getDiscount();
        }
        public void fillCombobox()
        {
            cbb_maproduct.DataSource = dcBUS.getIdProduct();
            cbb_maproduct.DisplayMember = "id";
            cbb_maproduct.ValueMember = "id";
            cbb_maproduct.SelectedItem = null;
        }

        private void btn_add_discount_Click(object sender, EventArgs e)
        {
            if(tb_madiscount.Text != "" || cbb_maproduct.Text != "" || tb_giamgia.Text != "" || dtp_startday.Text != "" || dtp_endday.Text != "")
            {
                String madiscount = tb_madiscount.Text;
                String maproduct = cbb_maproduct.Text;
                String giagia = tb_giamgia.Text;
                String startday = dtp_startday.Text;
                String endday = dtp_endday.Text;

                DiscountDTO dcDTO = new DiscountDTO(madiscount, maproduct, giagia, startday, endday);
                if (dcBUS.addDiscount(dcDTO))
                {
                    Console.WriteLine("Them discount thanh cong !");
                    dgv_discount.DataSource = dcBUS.getDiscount();
                }
                else
                {
                    Console.WriteLine("Them discount khong thanh cong !");
                }
            }
            else
            {
                Console.WriteLine("Vui long nhap du du lieu !");
            }
        }

        private void dgv_discount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_discount.CurrentCell.Selected = true;
            tb_madiscount.Text = dgv_discount.Rows[e.RowIndex].Cells["maDiscount"].FormattedValue.ToString();
            cbb_maproduct.Text = dgv_discount.Rows[e.RowIndex].Cells["maProduct"].FormattedValue.ToString();
            tb_giamgia.Text = dgv_discount.Rows[e.RowIndex].Cells["sale_percent"].FormattedValue.ToString();
            dtp_startday.Value = DateTime.ParseExact(dgv_discount.Rows[e.RowIndex].Cells["start_day"].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            dtp_startday.Value = DateTime.ParseExact(dgv_discount.Rows[e.RowIndex].Cells["end_day"].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
    
}
