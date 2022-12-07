using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DAO;
using DTO;

namespace GUI
{
    public partial class Add_Or_Fix_RoleGUI : Form
    {
        RoleBUS roleBUS = new RoleBUS();
        RoleGUI roleGUI ;
        Home home;
        String role_Id = "";
        public Add_Or_Fix_RoleGUI(string title, string btn_Title, string role_Id, RoleGUI roleGUI, Home home)
        {
            InitializeComponent();
            import_Array();
            this.roleGUI = roleGUI;
            this.Text = title;
            guna2Button2.Text = btn_Title;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Check nếu là Add Permission thì gán ID tự sinh else truy vấn theo ID
            if (this.Text == "Add Permission")
                guna2TextBox1.Text = role_Id + "";
            else
                load_Role_From_Id(role_Id);
            this.home = home;
            this.role_Id = role_Id;
        }

        List<ComboBox> combo_Box;
        List<CheckBox> check_Box;

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //btn hủy
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void import_Array()
        {
            combo_Box = new List<ComboBox> { comboBox1, comboBox2, comboBox3, comboBox4,
                comboBox5, comboBox6, comboBox7, comboBox8, comboBox11, comboBox12, comboBox13 };

            check_Box = new List<CheckBox> {
                guna2CheckBox1, guna2CheckBox2, guna2CheckBox3, guna2CheckBox4,
                guna2CheckBox5, guna2CheckBox6, guna2CheckBox7, guna2CheckBox8,
                guna2CheckBox11, guna2CheckBox12,guna2CheckBox13 };

            for (int i = 0; i < check_Box.Count; i++)
                combo_Box[i].SelectedIndex = 0;
        }

        private void guna2CheckBox1_CheckStateChanged_1(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            for (int i = 0; i < check_Box.Count; i++)
            {
                if (check_Box[i] == cb)
                {
                    if (cb.Checked == true)
                        combo_Box[i].Enabled = true;
                    else
                        combo_Box[i].Enabled = false;
                }
            }
        }

        private void load_Role_From_Id(string role_Id)
        {
            RoleDTO role_DTO = roleBUS.get_Role_From_Id(role_Id);
            guna2TextBox1.Text = role_DTO.Role_Id;
            guna2TextBox2.Text = role_DTO.Role_Name;
            string role_Description = role_DTO.Role_Desciption;

            //Tách chuỗi mô tả
            string[] description = role_Description.Split(new string[] { ", " }, StringSplitOptions.None);
            String[] role;// Lưu trữ 1 tên quyền và khả năng thao tác của quyền đó
            ArrayList role_Name = new ArrayList(); // Lưu trữ mảng tên quyền
            ArrayList role_Manipulative = new ArrayList();// Lưu trữ mảng khả năng thao tác của các quyền

            //Thực hiện tách chuỗi và truyền data vào 2 mảng 
            for (int i = 0; i < description.Length; i++)
            {
                role = description[i].Split(new string[] { " : " }, StringSplitOptions.None);
                role_Name.Add(role[0]);
                role_Manipulative.Add(role[1]);
            }

            for (int i = 0; i < role_Name.Count; i++)
                for (int j = 0; j < check_Box.Count; j++)
                    if (check_Box[j].Text.Equals(role_Name[i]))
                    {
                        check_Box[j].Checked = true;
                        for (int k = 0; k < combo_Box[j].Items.Count; k++)
                            if (combo_Box[j].Items[k].ToString().Equals(role_Manipulative[i]))
                                combo_Box[j].SelectedIndex = k;
                    }    
        }

        //btn add + fix
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string role_Description = "";

            if (String.IsNullOrEmpty(guna2TextBox2.Text))
                MessageBox.Show("Tên vai trò không được bỏ trống ");
            else if (roleBUS.check_Name(guna2TextBox2.Text, guna2TextBox1.Text))
                MessageBox.Show("Tên vai trò đã tồn tại ");
            else
            {
                //Duyệt checkbox + combobox được chọn và nối chuỗi
                for (int i = 0; i < check_Box.Count; i++)
                    if (check_Box[i].Checked == true)
                        role_Description += check_Box[i].Text + " : " + combo_Box[i].GetItemText(combo_Box[i].SelectedItem) + ", ";

                if (String.IsNullOrEmpty(role_Description))
                    MessageBox.Show("Bạn chưa chọn quyền");
                else
                {
                    //Xóa dấu , cuối chuỗi
                    role_Description = role_Description.Remove(role_Description.Length - 2);
                    RoleDTO roleDTO = new RoleDTO(guna2TextBox1.Text, guna2TextBox2.Text, role_Description, 0);

                    //Tiến hành thêm
                    if (this.Text == "Add Permission")
                    {
                        if (roleBUS.addRole(roleDTO))
                        {
                            roleGUI.dataGridView1.DataSource = roleBUS.getAllRole();
                            MessageBox.Show("Thêm thành công");
                            this.Dispose();
                        }
                        else MessageBox.Show("Thêm thất bại");
                    }
                    else //Tiến hành sửa
                    {
                        if (roleBUS.fixRole(roleDTO))
                        {
                            MessageBox.Show("Sửa thành công");
                            roleGUI.dataGridView1.DataSource = roleBUS.getAllRole();
                            this.home.DisableTabsForDecentralize();

                            String description = roleBUS.get_Role_From_Id(this.role_Id).Role_Desciption;
                            //Cắt chuỗi
                            string[] description_Split = description.Split(new string[] { ", " }, StringSplitOptions.None);
                            String[] role;// Lưu trữ 1 tên quyền và khả năng thao tác của quyền đó
                            ArrayList role_Name = new ArrayList(); // Lưu trữ mảng tên quyền
                            ArrayList role_Manipulative = new ArrayList();// Lưu trữ mảng khả năng thao tác của các quyền
                            //Thực hiện tách chuỗi 1 lần nữa và truyền data vào 2 mảng 
                            for (int i = 0; i < description_Split.Length; i++)
                            {
                                role = description_Split[i].Split(new string[] { " : " }, StringSplitOptions.None);
                                role_Name.Add(role[0]);
                                role_Manipulative.Add(role[1]);
                            }

                            string manipulative = "";
                            if (role_Name.Contains("Quyền"))
                            {
                                int index = role_Name.IndexOf("Quyền");
                                manipulative = role_Manipulative[index] + "";
                                this.home.set_Background_btnPermission();
                            }

                            if (!manipulative.Equals("Được thay đổi"))
                                this.roleGUI.disable();
                            this.Dispose();
                        }
                        else MessageBox.Show(guna2TextBox1.Text +" " +guna2TextBox2.Text +" "+ role_Description);
                    }
                    
                }
            }
        }



    }
}
