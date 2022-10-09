using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Media;
using FontAwesome.Sharp;
using TheArtOfDevHtmlRenderer.Adapters.Entities;
using Color = System.Drawing.Color;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Documents;

namespace GUI
{
    public partial class CategoryGUI : Form
    {
        public CategoryGUI()
        {
            InitializeComponent();
            string[] item = new string[] {"AK0", "Áo Khoác"};
            list.Add(item);
            item = new string[] { "QT0", "Quần Tây" };
            list.Add(item);
        }

        List<string[]> list = new List<string[]>();

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        //Hàm chuyển chuỗi có dấu thành không dấu
        //VD: Áo khoác đẹp --> Ao khoac dep
        public static string utf8Convert3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(guna2TextBox2.Text) )
            {
                MessageBox.Show("Text is null!!!!");
            }
            else
            { 
                string[] item = new string[] { guna2TextBox1.Text, guna2TextBox2.Text.Trim() };
                list.Add(item);
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            string Name = utf8Convert3(guna2TextBox2.Text.Trim() + "");
            string Id = "";

            if (!string.IsNullOrEmpty(Name))
            {
                //Gán Id = chữ cái đầu của Name
                Id = Name[0].ToString().ToUpper();
                int num = 0;

                //Duyệt chuỗi nối Id
                for (int i = 1; i < Name.Length; i++)
                {
                    if (Name[i - 1].ToString() == " ")
                    {
                        Id += Name[i].ToString().ToUpper();
                    }
                }
                string check_Id;
                //check Id có trùng vs các Id đã tồn tại hay k
                for (int i = 0; i < list.Count(); i++)
                {
                    check_Id = Id + num + "";
                    if (check_Id == list[i][0])
                    {
                        num++;
                    }
                }
                Id = Id + num + "";
                guna2TextBox1.Text = Id;
            }
            else guna2TextBox1.Text = "";
        }
    }
}
