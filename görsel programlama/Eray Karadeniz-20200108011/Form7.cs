﻿using System;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        OkulYonetimEntities db = new OkulYonetimEntities();
        private void btnÖgrKaydet_Click(object sender, EventArgs e)
        {
            Ogrenci öğrenci = new Ogrenci();
            öğrenci.AdSoyad = txtÖgrAd.Text;
            öğrenci.KayitTarih = kytTarih.Value;
            öğrenci.OgrenciNo = mskÖgrNo.Text;
            öğrenci.DTarih = dTarih.Value;
            öğrenci.Bolum = cmbBölüm.Text;
            db.Ogrenci.Add(öğrenci);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Eklendi");
        }

        private void btnÖgrGüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(lblId.Text);
            var öğrenci = db.Ogrenci.Find(x);
            öğrenci.AdSoyad = txtÖgrAd.Text;
            öğrenci.KayitTarih = kytTarih.Value;
            öğrenci.OgrenciNo = mskÖgrNo.Text;
            öğrenci.DTarih = dTarih.Value;
            öğrenci.Bolum = cmbBölüm.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Güncellendi");
        }

        private void btnÖgrSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(lblId.Text);
            var öğrenci = db.Ogrenci.Find(x);
            db.Ogrenci.Remove(öğrenci);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Silindi");
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            List<ComboBoxBolum> list = new List<ComboBoxBolum>();
            list.Add(new ComboBoxBolum() { ID = "1", Name = "Bilgisayar Mühendisliği" });
            list.Add(new ComboBoxBolum() { ID = "2", Name = "Tıp" });
            list.Add(new ComboBoxBolum() { ID = "3", Name = "Eczacılık" });
            list.Add(new ComboBoxBolum() { ID = "4", Name = "Mekatronik" });
            list.Add(new ComboBoxBolum() { ID = "5", Name = "Kimya" });

            cmbBölüm.DataSource = list;
            cmbBölüm.DisplayMember = "Name";
            cmbBölüm.ValueMember = "ID";
        }
        internal class ComboBoxBolum
        {
            public string ID { get; set; }
            public string Name { get; set; }
        }
    }
}
