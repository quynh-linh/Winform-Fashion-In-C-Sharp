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
        }

        private void CategoryGUI_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
