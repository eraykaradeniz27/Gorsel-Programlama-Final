﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Eray_Karadeniz_20200108011.Form8;
namespace Eray_Karadeniz_20200108011
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        OkulYonetimEntities db = new OkulYonetimEntities();
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtAra.Text;
            if (cmbFiltre.Text == "Öğrenci Ad")
            {
                var degerler = from item in db.OgrenciDers
                               where item.Ogrenci.AdSoyad.Contains(aranan)
                               select new { item.Ogrenci.AdSoyad, item.Ders.Ad };
                dataGridViewOgrDrs.DataSource = degerler.ToList();
            }
            if (cmbFiltre.Text == "Ders Ad")
            {
                var degerler = from item in db.OgrenciDers
                               where item.Ders.Ad.Contains(aranan)
                               select new { item.Ogrenci.AdSoyad, item.Ders.Ad };
                dataGridViewOgrDrs.DataSource = degerler.ToList();
            }
            if (cmbFiltre.Text == "Tümü")
            {
                var degerler = from item in db.OgrenciDers
                               where item.Ogrenci.AdSoyad.Contains(aranan) || item.Ders.Ad.Contains(aranan)
                               select new { item.Ogrenci.AdSoyad, item.Ders.Ad };
                dataGridViewOgrDrs.DataSource = degerler.ToList();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridViewOgrDrs.DataSource = (from x in db.OgrenciDers
                                             select new
                                             {
                                                 x.Id,
                                                 x.Ogrenci.AdSoyad,
                                                 x.Ders.Ad,


                                             }).ToList();
        }

        private void btnSırala_Click(object sender, EventArgs e)
        {
            var data = (from x in db.OgrenciDers
                        select new
                        {
                            x.Id,
                            x.Ogrenci.AdSoyad,
                            x.Ders.Ad,
                        }).ToList();
            if (cmbÖlçü.Text == "A-Z" && cmbFiltre.Text == "Öğrenci Ad")
            {
                data = data.OrderBy(x => x.AdSoyad).ToList();
            }
            else if (cmbÖlçü.Text == "A-Z" && cmbFiltre.Text == "Ders Ad")
            {
                data = data.OrderBy(x => x.Ad).ToList();
            }
            else if (cmbÖlçü.Text == "Z-A" && cmbFiltre.Text == "Öğrenci Ad")
            {
                data = data.OrderByDescending(x => x.AdSoyad).ToList();
            }
            else if (cmbÖlçü.Text == "Z-A" && cmbFiltre.Text == "Ders Ad")
            {
                data = data.OrderByDescending(x => x.Ad).ToList();
            }
            dataGridViewOgrDrs.DataSource = data;
        }

        private void dataGridViewOgrDrs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridViewOgrDrs.SelectedCells[0].RowIndex;
            Form5 ögr_drs = new Form5();
            ögr_drs.labelId.Text = dataGridViewOgrDrs.Rows[selected].Cells["Id"].Value.ToString();
            ögr_drs.cmbÖgr.SelectedValue = dataGridViewOgrDrs.Rows[selected].Cells["AdSoyad"].Value;
            ögr_drs.cmbDers.SelectedValue = dataGridViewOgrDrs.Rows[selected].Cells["Ad"].Value;


            ögr_drs.MdiParent = this.MdiParent;
            ögr_drs.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<ComboBoxFiltre> list = new List<ComboBoxFiltre>();
            list.Add(new ComboBoxFiltre() { ID = "1", Name = "Öğrenci Ad" });
            list.Add(new ComboBoxFiltre() { ID = "2", Name = "Ders Ad" });
            list.Add(new ComboBoxFiltre() { ID = "3", Name = "Tümü" });

            cmbFiltre.DataSource = list;
            cmbFiltre.DisplayMember = "Name";
            cmbFiltre.ValueMember = "ID";

            List<ComboBoxFiltre> list1 = new List<ComboBoxFiltre>();

            list1.Add(new ComboBoxFiltre() { ID = "1", Name = "Öğrenci Ad" });
            list1.Add(new ComboBoxFiltre() { ID = "2", Name = "Ders Ad" });

            cmbSütun.DataSource = list1;
            cmbSütun.DisplayMember = "Name";
            cmbSütun.ValueMember = "ID";

            List<ComboBoxFiltre> list2 = new List<ComboBoxFiltre>();

            list2.Add(new ComboBoxFiltre() { ID = "1", Name = "A-Z" });
            list2.Add(new ComboBoxFiltre() { ID = "2", Name = "Z-A" });

            cmbÖlçü.DataSource = list2;
            cmbÖlçü.DisplayMember = "Name";
            cmbÖlçü.ValueMember = "ID";

            dataGridViewOgrDrs.DataSource = (from x in db.OgrenciDers
                                             select new
                                             {
                                                 x.Id,
                                                 x.Ogrenci.AdSoyad,
                                                 x.Ders.Ad,


                                             }).ToList();
        }
    }
}
