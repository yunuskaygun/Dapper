using System;
using System.Data;
using System.Data.SqlClient;
using Dapper.Model;
using System.Collections.Generic;
using System.Linq;

namespace Dapper
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        public Form1()
        {
            InitializeComponent();


        }
        private string conStr = "Server=(local);Database=dbOgrenci; Trusted_Connection = True;";
        public void ListeleDapper()
        {
            try
            {
                DateTime t1 = DateTime.Now;

                using (SqlConnection db = new SqlConnection(conStr))
                {

                    if (db.State == ConnectionState.Closed) db.Open();
                    var sonuc = db.Query<Ogrenci>("Select * From Ogrenci");
                    ogrenciBindingSource.DataSource = sonuc; 

                }

                DateTime t2 = DateTime.Now;
                TimeSpan ts = t2 - t1;
                lblHiz.Text += "Dapper: " + ts.TotalMilliseconds.ToString() + "ms.\n";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ListeleDapperTumu()
        {
            try
            {
                List<Ogrenci> ogrenciListesi = new List<Ogrenci>();
                List<Satis> satisListesi = new List<Satis>();
                List<OdemePlan> odemePlanListesi = new List<OdemePlan>();
                List<Evrak> evrakListesi = new List<Evrak>();
                using (SqlConnection db = new SqlConnection(conStr))
                {

                    if (db.State == ConnectionState.Closed) db.Open();
                    var sonuc = db.QueryMultiple("spOgrenci", new { ISLEM = 1 }, commandType: CommandType.StoredProcedure);

                    ogrenciListesi = sonuc.Read<Ogrenci>().ToList();
                    satisListesi = sonuc.Read<Satis>().ToList();
                    odemePlanListesi = sonuc.Read<OdemePlan>().ToList();
                    evrakListesi = sonuc.Read<Evrak>().ToList();

                }                

                foreach (Ogrenci o in ogrenciListesi)
                {
                    //Satışlar Ekleniyor
                    var _satisList = satisListesi.Where(u => u.ID_OGRENCI == o.ID_OGRENCI).ToList();
                    if (_satisList != null)
                    {
                        o.SatisListesi = new List<Satis>();
                        o.SatisListesi.AddRange(_satisList);
                        foreach (Satis s in _satisList)
                        {
                            //Satışa ait ödeme planları ekleniyor
                            var _odemePlanList = odemePlanListesi.Where(u => u.ID_SATIS == s.ID_SATIS).ToList();
                            if (_odemePlanList != null)
                            {
                                s.OdemePlanListesi = new List<OdemePlan>();
                                s.OdemePlanListesi.AddRange(_odemePlanList);
                            }
                        }
                    }

                    //Evraklar ekleniyor
                    var _evrakListesi = evrakListesi.Where(u => u.ID_OGRENCI == o.ID_OGRENCI).ToList();
                    if (_evrakListesi != null)
                    {
                        o.EvrakListesi = new List<Evrak>();
                        o.EvrakListesi.AddRange(_evrakListesi);
                    }

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection db = new SqlConnection(conStr))
                {
                    if (db.State == ConnectionState.Closed) db.Open();
                    var sonuc = db.Query<Ogrenci>("spOgrenci", new { ADSOYAD = txtAdSoyad.Text, ADRES = txtAdres.Text, ISLEM = 2 }, commandType: CommandType.StoredProcedure).ToList();
                    MetroFramework.MetroMessageBox.Show(this, sonuc[0].ID_OGRENCI.ToString() + " Kaydedilen ID", "Bilgilendirme", 100);
                }
                ListeleDapper();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Ogrenci ogr = ogrenciBindingSource.Current as Ogrenci;
                using (SqlConnection db = new SqlConnection(conStr))
                {
                    if (db.State == ConnectionState.Closed) db.Open();
                    var sonuc = db.Execute("spOgrenci", new { ID_OGRENCI = ogr.ID_OGRENCI, ISLEM = 3 }, commandType: CommandType.StoredProcedure);
                    if (sonuc == 1) ogrenciBindingSource.RemoveCurrent();
                    else MetroFramework.MetroMessageBox.Show(this, "Öğrenci Silinemedi", "Bilgilendirme", 100);
                }
                ListeleDapper();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ListeleEF()
        {
            DateTime t1 = DateTime.Now;
            using (EF.EF1 e = new EF.EF1())
            {
                e.Configuration.LazyLoadingEnabled = false;
                //e.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                ogrenciBindingSource.DataSource = e.Ogrenci.AsNoTracking().ToList();
            }
            DateTime t2 = DateTime.Now;
            TimeSpan ts = t2 - t1;
            lblHiz.Text += "EF: " + ts.TotalMilliseconds.ToString() + " ms.\n";
        }

        public void ListeleAdonet()
        {
            try
            {
                DateTime t1 = DateTime.Now;

                using (SqlConnection db = new SqlConnection(conStr))
                {
                    List<Ogrenci> liste = new List<Ogrenci>();
                    if (db.State == ConnectionState.Closed) db.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = db;
                    cmd.CommandText = "Select * From Ogrenci";
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        liste.Add(
                            new Ogrenci()
                            {
                                ID_OGRENCI = Convert.ToInt32(dr["ID_OGRENCI"]),
                                ADSOYAD = dr["ADSOYAD"].ToString(),
                                ADRES = dr["ADRES"].ToString()
                            }
                            );
                    }
                    ogrenciBindingSource.DataSource = liste;
                }

                DateTime t2 = DateTime.Now;
                TimeSpan ts = t2 - t1;
                lblHiz.Text += "Adonet: " + ts.TotalMilliseconds.ToString() + "ms.\n";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ListeleLinqToSql()
        {
            DateTime t1 = DateTime.Now;
            using (Linq2Sql.lqDataContext e = new Linq2Sql.lqDataContext(conStr))
            {
                ogrenciBindingSource.DataSource = e.Ogrencis.ToList();
            }
            DateTime t2 = DateTime.Now;
            TimeSpan ts = t2 - t1;
            lblHiz.Text += "LinqToSql: " + ts.TotalMilliseconds.ToString() + " ms.\n";
        }

        private void btnListeleEF_Click(object sender, EventArgs e)
        {
            ListeleEF();
        }

        private void btnListeleDapper_Click(object sender, EventArgs e)
        {
            ListeleDapper();
        }

        private void btnAdonet_Click(object sender, EventArgs e)
        {
            ListeleAdonet();
        }

        private void btnLinqToSql_Click(object sender, EventArgs e)
        {
            ListeleLinqToSql();
        }

        private void btnMultipleTest_Click(object sender, EventArgs e)
        {
            ListeleDapperTumu();
        }
    }
}
