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
        List<ComboItem> comboItems;
        class ComboItem{
            public string Value { get; set; }
            public string Text { get; set; }
        }
        public AccountAddOrUpdateGUI(String type, AccountDTO accountDTO)
        {
            InitializeComponent();
            comboItems = new List<ComboItem>();
            this.btnActionAccount.Text = type;
            roleBUS.getRoles().ForEach(role => {
                comboItems.Add(new ComboItem { Value = role.Role_Id,Text = role.Role_Name});
            });
            this.roles.DataSource = comboItems;
            this.roles.DisplayMember = "Text";
            this.roles.ValueMember = "Value";
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
            string id, username, fullName, password, email, role;
            id = idAccount.Text +"";
            username = usernameAccount.Text + "";
            fullName = fullNameAccount.Text + "";
            password = passwordAccount.Text + "";
            email = emailAccount.Text + "";
            role = comboItems[roles.SelectedIndex].Value;
            try
            {
                if (this.btnActionAccount.Text == "Update")
                {
                    AccountDTO accountDTO = new AccountDTO(Int32.Parse(id), username, password, fullName, email, role);
                    accountBUS.updateAccount(accountDTO);
                    MessageBox.Show("Sua tai khoan thanh cong", "Successfully");
                }
                else if (this.btnActionAccount.Text == "Add")
                {
                    AccountDTO accountDTO = new AccountDTO();
                    accountDTO.User_Name = username;
                    accountDTO.Password = password;
                    accountDTO.Full_Name = fullName;
                    accountDTO.Email = email;
                    accountDTO.Role_Id = role;
                    accountBUS.createAccount(accountDTO);
                    MessageBox.Show("Them tai khoan thanh cong", "Successfully");
                }
            }
            catch (ApplicationException e1) {
                MessageBox.Show(e1.Message, "Cảnh báo");
            }
            catch (FormatException e1) {
                MessageBox.Show("Email không đúng định dạng", "Cảnh báo");
            }
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
          
        }

        private void idAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullNameAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void guna2HtmlLabel5_Click_1(object sender, EventArgs e) {

        }
    }
}
