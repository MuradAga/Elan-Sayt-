using System;
using System.Windows.Forms;

namespace Elanlar
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            Kateqoriya kateqoriya = new Kateqoriya();
            kateqoriya.MdiParent = this;
            kateqoriya.FormBorderStyle = FormBorderStyle.Fixed3D;
            kateqoriya.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fealiyyet fealiyyet = new Fealiyyet();
            fealiyyet.MdiParent = this;
            fealiyyet.FormBorderStyle = FormBorderStyle.None;
            fealiyyet.Show();
        }
    }
}
