using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eray_Karadeniz_20200108011
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void personelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 ekle = new Form9();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void personelListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 ekle = new Form8();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void dersİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ekle = new Form2();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void dersleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ekle = new Form3();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void öğrenciEkleSilGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 ekle = new Form7();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void öğrenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 ekle = new Form6();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void öğrencilereDersİliştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 ekle = new Form5();
            ekle.MdiParent = this;
            ekle.Show();
        }

        private void öğrencilerVeDersleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 ekle = new Form4();
            ekle.MdiParent = this;
            ekle.Show();
        }
    }
}
