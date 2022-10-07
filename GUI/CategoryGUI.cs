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
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
            if (guna2TextBox2.Text == null)
            {
                MessageBox.Show("Text is null!!!!");
            }
            else
            {
                string Name = utf8Convert3(guna2TextBox2.Text+"");
                //Gán Id = chữ cái đầu của Name
                string Id = Name[0].ToString().ToUpper();
                int num = 0;

                //Duyệt chuỗi nếu gặp khoảng cách thì nối chuỗi Id vs kí tự phía sau
                //khoảng cách
                for(int i=0; i< Name.Length; i++ ){
                    if (Name[i].ToString() ==" ")
                    {
                        Id += Name[i + 1].ToString().ToUpper();
                    }
                }
                string check_Id;
                //check Id có trùng vs các Id đã tồn tại hay k
                for(int i=0; i< list.Count(); i++)
                {
                    check_Id = Id + num + "";
                    if (check_Id == list[i][0])
                    {
                        num++;
                    }
                }
                Id = Id + num +"";
                string[] item = new string[] { Id, guna2TextBox2.Text };
                list.Add(item);
                guna2TextBox1.Text = Id;
            }
        }
    }
}
