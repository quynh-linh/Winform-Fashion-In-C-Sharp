using BUS;
using DAO;
using DTO;
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
    public partial class AccountAddOrUpdateGUI : Form
    {
        private RoleBUS roleBUS = new RoleBUS();
        private AccountBUS accountBUS = new AccountBUS();
        private List<ItemDTO> list = new List<ItemDTO>();
        public AccountAddOrUpdateGUI(String type, AccountDTO accountDTO)
        {
            InitializeComponent();
            this.btnActionAccount.Text = type;
            setTextToUpdate(accountDTO);
        }

        private void setTextToUpdate(AccountDTO accountDTO) {
            if(accountDTO != null)
            {
                idAccount.Text = accountDTO.Account_Id.ToString();
                usernameAccount.Text = accountDTO.User_Name.ToString();
                fullNameAccount.Text = accountDTO.Full_Name.ToString();
                passwordAccount.Text = accountDTO.Password.ToString();
                emailAccount.Text = accountDTO.Email.ToString();

            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string nameSelected = selectRole.SelectedItem.ToString();
            string id,roleId="", username, fullName, password, email;
            list.ForEach(itemDto =>
            {
                if (itemDto.Name.Equals(nameSelected))
                {
                    roleId = itemDto.ID;
                }
            });
            id = idAccount.Text;
            username = usernameAccount.Text;
            fullName = fullNameAccount.Text;
            password = passwordAccount.Text;
                email = emailAccount.Text;
            AccountDTO accountDTO = new AccountDTO(id, username, password, fullName, email, roleId);
            accountBUS.updateAccount(accountDTO);
        }

        private void btnResetAccount_Click(object sender, EventArgs e)
        {
            this.usernameAccount.Text = "";
            this.fullNameAccount.Text = "";
            this.passwordAccount.Text = "";
            this.emailAccount.Text = "";
        }

        private void AccountAddOrUpdateGUI_Load(object sender, EventArgs e)
        {
            List<string> names = new List<string>();
            DataTable data = new DataTable();
            data = roleBUS.getAllRole();
            foreach (DataRow dataRow in data.Rows)
            {
                list.Add(new ItemDTO(dataRow["id"].ToString(), dataRow["role_name"].ToString()));
                names.Add(dataRow["role_name"].ToString());
            }
            selectRole.DataSource = names;
        }

        private void idAccount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
