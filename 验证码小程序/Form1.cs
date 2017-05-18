using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 验证码小程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateVCode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateVCode();
        }
        //全局变量s用于后续比较
        static string s = null;
        private void GenerateVCode()
        {
            s = null;
            Random r = new Random();
            //生成五个随机数
            for (int i = 0; i < 5; i++)
            {
                s += r.Next(0, 10);
            }

            //绘制s里的五个数字
            Bitmap bmp = new Bitmap(150, 40);
            Graphics g = Graphics.FromImage(bmp);

            for (int i = 0; i < s.Length; i++)
            {
                string[] fs = { "微软雅黑", "仿宋", "隶书", "黑体", "等线" };
                //Color[] cls = { Color.Yellow, Color.Blue, Color.Black, Color.Red, Color.Green };
                Point p = new Point(25 * i, 0);
                g.DrawString(s[i].ToString(), new Font(fs[r.Next(0, fs.Length)], 24), new SolidBrush(Color.Black), p);
            }

            //绘制干扰线
            for (int i = 0; i < 20; i++)
            {
                Point p1 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                Point p2 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                g.DrawLine(new Pen(Color.Black), p1, p2);
            }

            //绘制干扰点
            for (int i = 0; i < 500; i++)
            {
                Point p = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                bmp.SetPixel(p.X, p.Y, Color.Black);
            }
            //将bmp插入picturebox
            pbVCode.Image = bmp;
            
        }

        //点击确定比较
        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (tbInput.Text==s)
            {
                MessageBox.Show("眼神儿不错~");
                this.Close();
            }
            else
            {
                MessageBox.Show("不对，再仔细看看");
            }
        }
    }
}
