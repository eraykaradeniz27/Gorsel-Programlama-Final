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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        OkulYonetimEntities db = new OkulYonetimEntities();
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtAra.Text;
            if (cmbFiltre.Text == "İsim")
            {
                var degerler = from item in db.Personel
                               where item.AdSoyad.Contains(aranan)
                               select new { item.AdSoyad, item.Görevi, item.YönetimTip };
                dataGridViewPersonel.DataSource = degerler.ToList();
            }
            if (cmbFiltre.Text == "Görev")
            {
                var degerler = from item in db.Personel
                               where item.Görevi.Contains(aranan)
                               select new { item.AdSoyad, item.Görevi, item.YönetimTip };
                dataGridViewPersonel.DataSource = degerler.ToList();
            }
            if (cmbFiltre.Text == "Departman")
            {
                var degerler = from item in db.Personel
                               where item.YönetimTip.ToString().Contains(aranan)
                               select new { item.AdSoyad, item.Görevi, item.YönetimTip };
                dataGridViewPersonel.DataSource = degerler.ToList();
            }
            if (cmbFiltre.Text == "Tümü")
            {
                var degerler = from item in db.Personel
                               where item.AdSoyad.Contains(aranan) || item.Görevi.Contains(aranan) || item.YönetimTip.ToString().Contains(aranan)
                               select new { item.AdSoyad, item.Görevi, item.YönetimTip };
                dataGridViewPersonel.DataSource = degerler.ToList();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridViewPersonel.DataSource = (from x in db.Personel
                                               select new
                                               {
                                                   x.Id,
                                                   x.AdSoyad,
                                                   x.Görevi,
                                                   x.YönetimTip
                                               }).ToList();
        }

        private void btnSırala_Click(object sender, EventArgs e)
        {
            var data = (from x in db.Personel
                        select new
                        {
                            x.Id,
                            x.AdSoyad,
                            x.Görevi,
                            x.YönetimTip
                        }).ToList();
            if (cmbÖlçü.Text == "A-Z")
            {
                data = data.OrderBy(x => x.AdSoyad).ToList();
            }
            else if (cmbÖlçü.Text == "Z-A")
            {
                data = data.OrderByDescending(x => x.AdSoyad).ToList();
            }
            dataGridViewPersonel.DataSource = data;
        }

        private void dataGridViewPersonel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridViewPersonel.SelectedCells[0].RowIndex;
            Form9 personel = new Form9();

            personel.labelId.Text = dataGridViewPersonel.Rows[selected].Cells[0].Value.ToString();
            personel.txtPersonelAd.Text = dataGridViewPersonel.Rows[selected].Cells[1].Value.ToString();
            personel.txtGörev.Text = dataGridViewPersonel.Rows[selected].Cells[2].Value.ToString();
            personel.cmbDepartman.Text = dataGridViewPersonel.Rows[selected].Cells[3].Value.ToString();

            personel.MdiParent = this.MdiParent;
            personel.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            List<ComboBoxFiltre> list = new List<ComboBoxFiltre>();

            list.Add(new ComboBoxFiltre() { ID = "1", Name = "İsim" });
            list.Add(new ComboBoxFiltre() { ID = "2", Name = "Görev" });
            list.Add(new ComboBoxFiltre() { ID = "3", Name = "Departman" });
            list.Add(new ComboBoxFiltre() { ID = "4", Name = "Tümü" });

            cmbFiltre.DataSource = list;
            cmbFiltre.DisplayMember = "Name";
            cmbFiltre.ValueMember = "ID";

            List<ComboBoxFiltre> list1 = new List<ComboBoxFiltre>();

            list1.Add(new ComboBoxFiltre() { ID = "1", Name = "Ad-Soyad" });

            cmbSütun.DataSource = list1;
            cmbSütun.DisplayMember = "Name";
            cmbSütun.ValueMember = "ID";

            List<ComboBoxFiltre> list2 = new List<ComboBoxFiltre>();

            list2.Add(new ComboBoxFiltre() { ID = "1", Name = "A-Z" });
            list2.Add(new ComboBoxFiltre() { ID = "2", Name = "Z-A" });

            cmbÖlçü.DataSource = list2;
            cmbÖlçü.DisplayMember = "Name";
            cmbÖlçü.ValueMember = "ID";

            dataGridViewPersonel.DataSource = (from x in db.Personel
                                               select new
                                               {
                                                   x.Id,
                                                   x.AdSoyad,
                                                   x.Görevi,
                                                   x.YönetimTip
                                               }).ToList();
        }
        internal class ComboBoxFiltre
        {
            public string ID { get; set; }
            public string Name { get; set; }
        }
    }
}
