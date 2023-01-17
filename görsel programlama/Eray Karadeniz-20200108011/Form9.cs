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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        OkulYonetimEntities db = new OkulYonetimEntities();
        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.AdSoyad = txtPersonelAd.Text;
            personel.Görevi = txtGörev.Text;
            personel.YönetimTip = int.Parse(cmbDepartman.SelectedValue.ToString());
            db.Personel.Add(personel);
            db.SaveChanges();
            MessageBox.Show("Personel Eklendi");
        }

        private void btnPersonelGüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var personel = db.Personel.Find(x);
            personel.AdSoyad = txtPersonelAd.Text;
            personel.Görevi = txtGörev.Text;
            personel.YönetimTip = int.Parse(cmbDepartman.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Personel Güncellendi");
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(labelId.Text);
            var personel = db.Personel.Find(x);
            db.Personel.Remove(personel);
            db.SaveChanges();
            MessageBox.Show("Personel Silindi");
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            List<ComboBoxYonetimTip> list = new List<ComboBoxYonetimTip>();
            list.Add(new ComboBoxYonetimTip() { ID = "11", Name = "İdare" });
            list.Add(new ComboBoxYonetimTip() { ID = "12", Name = "Öğretmen" });
            list.Add(new ComboBoxYonetimTip() { ID = "13", Name = "Öğrenciİşleri" });

            cmbDepartman.DataSource = list;
            cmbDepartman.DisplayMember = "Name";
            cmbDepartman.ValueMember = "ID";
        }
        internal class ComboBoxYonetimTip
        {
            public string ID { get; set; }
            public string Name { get; set; }
        }
    }
}
