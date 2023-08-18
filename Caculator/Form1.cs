using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, KetQua;
            a= int.Parse(textBox1.Text);
            b= int.Parse(textBox2.Text);
            Caculation c = new Caculation(a, b);
            KetQua = c.Exectute("+");
            txtketqua.Text = KetQua.ToString();
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, KetQua;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            Caculation c = new Caculation(a, b);
            KetQua = c.Exectute("-");
            txtketqua.Text = KetQua.ToString();
        }
    }
}
