using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitapçı_Dükkanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int piece;
            double price;
            piece = Convert.ToInt16(textBox1.Text);

            if (piece >= 0 && piece <= 20)
            {
                price = (piece * 8) * (0.8);
                label3.Text = price.ToString() + " TL";
            }
            if (piece >= 21 && piece <= 40)
            {
                price = (piece * 8) * (0.6);
                label3.Text = price.ToString() + " TL";
            }
            if (piece >= 41)
            {
                price = (piece * 8) * (0.5);
                label3.Text = price.ToString() + " TL";
            }
        }
    }
}
// 0-20 ==> % 20
// 21-40 ==> % 40
// 41++ ==> % 50
// Kitap = 8 Tl