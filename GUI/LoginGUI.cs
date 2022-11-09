using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginGUI : Form
    {
        LoginBUS loginBUS = new LoginBUS();
        AccountBUS account_BUS = new AccountBUS();

        public LoginGUI()
        {
            InitializeComponent();
            ReadSettings();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SaveSettings();
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Chưa nhập dữ liệu", "Cảnh báo");
            }
            else
            {
                String password = textBoxPassword.Text;
                String username = textBoxUsername.Text;
                if (checkPassword(password) || checkUser(username))
                {
                    String equal = loginBUS.checkLogin(username, password);
                    if ( equal.Equals("Đăng nhập thành công"))
                    {
                        MessageBox.Show(equal);
                        Home h = new Home(account_BUS.loginAccount(username, password));
                        h.Show();
                        SetVisibleCore(false);
                    }
                    else MessageBox.Show(equal);
                }

            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool checkUser (string username)
        {
            // kiểm tra độ dài
            if (username.Length < 8)
            {
                MessageBox.Show("Độ dài không phù hợp", "Cảnh báo");
                return false;
            }
            if (username.Contains(" "))
            {
                MessageBox.Show("Không được có khoảng trắng", "Cảnh báo");
                return false;
            }
            return true;
        }
        private bool checkPassword(string password)
        {
            // kiểm tra độ dài
            if (password.Length < 8 || password.Length > 14)
            {
                MessageBox.Show("Độ dài không phù hợp", "Cảnh báo");
                return false;
            }
            // có một chữ hoa
            if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Phải có ít nhất một chữ hoa", "Cảnh báo");
                return false;
            }
            // có ít nhất một chữ thường
            if (!password.Any(char.IsLower))
            {
                MessageBox.Show("Phải có ít nhất một chữ thường", "Cảnh báo");
                return false;
            }
            // không có khoảng trắng
            if (password.Contains(" "))
            {
                MessageBox.Show("Không được có khoảng trắng", "Cảnh báo");
                return false;
            }
            // phải có ít nhất một ký tự đăc biệt
            //string specialCh = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            //char[] specialChArray = specialCh.ToCharArray();
            //foreach (char ch in specialChArray)
            //{
            //    if (!password.Contains(ch))
            //    {
            //        MessageBox.Show("Phải có ít nhất một ký tự đặc biệt", "Cảnh báo");
            //        Console.WriteLine(ch);
            //        return false;
            //    }

            //}
            return true;
        }
        private void ReadSettings()
        {
            if (Properties.Settings.Default.RememberMe == true)
            {
                textBoxUsername.Text = Properties.Settings.Default.UserName;
                textBoxPassword.Text = Properties.Settings.Default.Password;
                toggleswitch_Save.Checked = true;
            }
            else
            {
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                toggleswitch_Save.Checked = false;
            }
        }
        private void SaveSettings()
        {
            if (toggleswitch_Save.Checked)
            {
                Properties.Settings.Default.UserName = this.textBoxUsername.Text;
                Properties.Settings.Default.Password = this.textBoxPassword.Text;
                Properties.Settings.Default.RememberMe = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = this.textBoxUsername.Text;
                Properties.Settings.Default.Password = this.textBoxPassword.Text;
                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.Save();
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
