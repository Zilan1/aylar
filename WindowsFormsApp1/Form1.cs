using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum gunler
        {
            Ocak,
            Subat,
            Mart,
            Nisan,
            Mayis,
            Haziran,
            Temmuz,
            Agustos,
            Eylul,
            Ekim,
            Kasim,
            Aralik,
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte i = Convert.ToByte(textBox1.Text);
            gunler GunAdi;
            GunAdi = (gunler)i-1;
            MessageBox.Show(GunAdi.ToString());
        }
    }
}
