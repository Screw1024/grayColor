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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(图像*jpg)|*jpg";
            this.openFileDialog1.ShowDialog();
            //根据图像文件的路径创建位图
            Bitmap bmp = new Bitmap(openFileDialog1.FileName);
            //将图像赋给pictureBox1的Image属性
            pictureBox1.Image = bmp;
        }

        private void btnHuise_Click(object sender, EventArgs e)
        {
            //建立Bitmap对象
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            //创建新的Bitmap文件用于存储处理后的结果
            Bitmap newbmp = new Bitmap(pictureBox1.Image);
            //新建颜色对象
            Color c = new Color();
            Color NewC;
            //定义字节变量存储颜色值的红、绿、蓝
            Byte r, g, b, gray;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    //获取图像在（i行，j列的像元值）
                    c = bmp.GetPixel(i, j);
                    //获取颜色的R(红色)值
                    r = c.R;
                    g = c.G;
                    b = c.B;
                    //转为灰度的公式
                    gray = (Byte)(r * 0.3 + g * 0.59 + b * 0.11);
                    //对新颜色进行赋值
                    NewC = Color.FromArgb(gray, gray, gray);
                    //根据新的颜色对像元进行赋值
                    newbmp.SetPixel(i, j, NewC);
                }
            }
            //将新建的图像通过带参数的构造函数传给Form2
            Form2 frm = new Form2(newbmp);
            frm.ShowDialog();
        }
    }
}
