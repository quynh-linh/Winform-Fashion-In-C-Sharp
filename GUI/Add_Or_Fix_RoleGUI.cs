using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class Add_Or_Fix_RoleGUI : Form
    {
        public Add_Or_Fix_RoleGUI(string title, string btn_Title)
        {
            InitializeComponent();
            import_Array();
            this.Text = title;
            guna2Button2.Text = btn_Title;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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

        private void import_Array()
        {
            combo_Box = new List<ComboBox> { comboBox1, comboBox2, comboBox3, comboBox4,
                comboBox5, comboBox6, comboBox7, comboBox8, comboBox9, comboBox10,
                comboBox11, comboBox12, comboBox13 };

            check_Box = new List<CheckBox> {
                guna2CheckBox1, guna2CheckBox2, guna2CheckBox3, guna2CheckBox4,
                guna2CheckBox5, guna2CheckBox6, guna2CheckBox7, guna2CheckBox8,
                guna2CheckBox9, guna2CheckBox10, guna2CheckBox11, guna2CheckBox12,
                guna2CheckBox13 };

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

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
