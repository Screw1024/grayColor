using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageColor
{
    public partial class Form2 : Form
    {
        Image m_img;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Image img)
        {
            m_img = img;
            InitializeComponent();
            pictureBox2.Image = m_img;
        }
    }
}
