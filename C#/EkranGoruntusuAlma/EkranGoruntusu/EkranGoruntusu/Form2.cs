using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkranGoruntusu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Bitmap captureBitmap;
        private void button1_Click(object sender, EventArgs e)
        {
            
            captureBitmap.Save(@"C:\Users\Hasan\Desktop\"+textBox1.Text+".png", ImageFormat.Png);
            
            this.Close();
        }
    }
}
