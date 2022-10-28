using System;
using BUS;
using DTO;
using System.Windows.Forms;
using System.Data;

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
        public void loadNullDataTimePicker()
        {
            dtp_startday.CustomFormat = " ";
            dtp_startday.Format = DateTimePickerFormat.Custom;
            dtp_endday.CustomFormat = " ";
            dtp_endday.Format = DateTimePickerFormat.Custom;
        }
        public void loadDataDataTimePicker()
        {
            dtp_startday.CustomFormat = "dd/MM/yyyy";
            dtp_startday.Format = DateTimePickerFormat.Custom;
            dtp_endday.CustomFormat = "dd/MM/yyyy";
            dtp_endday.Format = DateTimePickerFormat.Custom;
        }
        public void fillCombobox()
        {
            cbb_maproduct.DataSource = dcBUS.getIdProduct();
            cbb_maproduct.DisplayMember = "name";
            cbb_maproduct.ValueMember = "id";
            cbb_maproduct.SelectedItem = null;
        }

        private void btn_add_discount_Click(object sender, EventArgs e)
        {
            if(tb_madiscount.Text != "" || cbb_maproduct.Text != "" || tb_giamgia.Text != "" || dtp_startday.Text != "" || dtp_endday.Text != "")
            {
                DataRowView br = (DataRowView)cbb_maproduct.SelectedItem;
                String madiscount = tb_madiscount.Text;
                String maproduct = br.Row["id"].ToString();
                String giagia = tb_giamgia.Text;
                String startday = dtp_startday.Text;
                String endday = dtp_endday.Text;

                DiscountDTO dcDTO = new DiscountDTO(madiscount, maproduct, giagia, startday, endday);
                if (dcBUS.addDiscount(dcDTO))
                {
                    Console.WriteLine("Them discount thanh cong !");
                    MessageBox.Show("Thêm Thành Công !");
                    dgv_discount.DataSource = dcBUS.getDiscount();
                }
                else
                {
                    Console.WriteLine("Them discount khong thanh cong !");
                    MessageBox.Show("Thêm Thất Bại !");
                }
            }
            else
            {
                Console.WriteLine("Vui long nhap du du lieu !");
            }
        }

        private void dgv_discount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                
                dgv_discount.CurrentCell.Selected = true;
                tb_madiscount.Text = dgv_discount.Rows[e.RowIndex].Cells["maDiscount"].FormattedValue.ToString();
                cbb_maproduct.Text = dgv_discount.Rows[e.RowIndex].Cells["nameProduct"].FormattedValue.ToString();
                tb_giamgia.Text = dgv_discount.Rows[e.RowIndex].Cells["sale_percent"].FormattedValue.ToString();
                if (dtp_startday.Value.ToString() != "" || dtp_endday.Value.ToString() != "")
                {
                    dtp_startday.Value = DateTime.ParseExact(dgv_discount.Rows[e.RowIndex].Cells["start_day"].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    dtp_endday.Value = DateTime.ParseExact(dgv_discount.Rows[e.RowIndex].Cells["end_day"].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                }
               

            }
            else
            {
                loadForm();
            }
            
        }
        public void loadForm()
        {
            tb_madiscount.Text = "";
            tb_giamgia.Text = "";
            cbb_maproduct.SelectedItem = null;
        }

        private void btn_edit_discount_Click(object sender, EventArgs e)
        {
            if(tb_madiscount.Text != "" || cbb_maproduct.Text != "" || tb_giamgia.Text != "" || dtp_startday.Text != "" || dtp_endday.Text != "")
            {
                DataRowView br = (DataRowView)cbb_maproduct.SelectedItem;
                String madiscount = tb_madiscount.Text;
                String maproduct = br.Row["id"].ToString();
                String giamgia = tb_giamgia.Text;
                String startday = dtp_startday.Text;
                String endday = dtp_endday.Text;
                DiscountDTO dt = new DiscountDTO(madiscount, maproduct, giamgia, startday, endday);
                if (dcBUS.editDiscount(dt))
                {
                    MessageBox.Show("Cập nhật thành công !");
                    dgv_discount.DataSource = dcBUS.getDiscount();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công !");
                }

            }
            else
            {
                MessageBox.Show("Vui long nhap du thong tin !");
            }
        }

        private void btn_delete_discount_Click(object sender, EventArgs e)
        {
            if (dgv_discount.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_discount.SelectedRows[0];
                String id = row.Cells[0].Value.ToString();
                if (dcBUS.deleteDiscount(id))
                {
                    MessageBox.Show("Xóa thành công !");
                    dgv_discount.DataSource = dcBUS.getDiscount();
                    loadForm();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công !");
                }
            }
        }
    }
    
}
