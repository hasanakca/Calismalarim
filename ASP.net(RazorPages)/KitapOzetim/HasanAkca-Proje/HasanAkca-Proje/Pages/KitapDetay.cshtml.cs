using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.Sqlite;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace HasanAkca_Proje.Pages
{
    public class KitapDetayModel : PageModel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public List<Kitaplar> KitapListe { get; set; }
        public List<Yorumlar> YorumListe { get; set; }
        [BindProperty][Required (ErrorMessage ="*Özetini yazmalýsýn."),MinLength(300,ErrorMessage ="*Minimum 300 harf içermelidir.")]
        public string yorum { get; set; }
        [BindProperty][Required(ErrorMessage ="*Puan vermelisin.")]
        public int Puan { get; set; }
        public void OnGet(int Id)
        {
            try
            {
                if (HttpContext.Session.GetString("Ad") != null)
                {
                    Ad = HttpContext.Session.GetString("Ad");
                    Soyad = HttpContext.Session.GetString("Soyad");
                    KitapAc(Id);
                    YorumAc(Id);
                }
                else
                {
                    Response.Redirect("Index");
                }
            }
            catch (Exception)
            {

                Response.Redirect("Index");
            }
            KitapAc(Id);
            YorumAc(Id);

        }
        public IActionResult OnPost(int Id)
        {
            Ad = HttpContext.Session.GetString("Ad");
            Soyad = HttpContext.Session.GetString("Soyad");
            if (yorum!=null)
            {
                while (yorum.Contains("\r\n\r\n") || yorum.Contains("  "))
                {
                    yorum = yorum.Replace("\r\n\r\n", "\r\n");
                    yorum = yorum.Replace("  ", " ");
                    int x = yorum.Count();
                }
            }
            
            if (ModelState.IsValid)
            {
                

                try
                {
                    YorumKaydet(Id, Ad, Soyad);
                    PuanKaydet(Id, Puan);
                }
                catch (Exception)
                {


                }

                KitapAc(Id);
                YorumAc(Id);
                Response.Redirect("KitapDetay?Id=" + Id);
                return null;
            }
            else
            {
                
                KitapAc(Id);
                YorumAc(Id);

                return Page();

            }
            
        }
        public void KitapAc(int Id)
        {
            KitapListe = new List<Kitaplar>();
            using (var connection = new SqliteConnection("Data Source=kutuphane.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "select * from Kitaplar where ID='"+Id+"'";
                int x = command.ExecuteNonQuery();


                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Kitaplar kitap = new Kitaplar();
                        kitap.id = reader.GetInt32(0);
                        kitap.kitapAd = reader.GetString(1);
                        kitap.kitapYazar = reader.GetString(2);
                        kitap.kitapAdres = "/Resimler/" + kitap.kitapAd.ToLower().Trim().Replace(" ", "").Replace("?", "") + ".jpg";
                        kitap.kitapPuan = reader.GetFloat(3);
                        kitap.oylayanSayi = reader.GetInt32(4);
                        KitapListe.Add(kitap);
                    }
                }
            }
        }
        public void YorumAc(int Id)
        {
            YorumListe = new List<Yorumlar>();
            using (var connection = new SqliteConnection("Data Source=kutuphane.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                try
                {
                    command.CommandText = "select * from '" + Id + "'";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Yorumlar yorum = new Yorumlar();
                            yorum.id = reader.GetInt32(0);
                            yorum.OgrenciAd = reader.GetString(1);
                            yorum.OgrenciSoyad = reader.GetString(2);
                            yorum.Yorum = reader.GetString(3);
                            yorum.Tarih = reader.GetString(4);
                            YorumListe.Add(yorum);

                        }
                    }
                }
                catch (Exception)
                {

                    command.CommandText = "create table '" + Id + "' ('ID'	INTEGER NOT NULL UNIQUE,'OgrenciAd' TEXT NOT NULL,	'OgrenciSoyad'  TEXT NOT NULL,	'Yorum' TEXT NOT NULL UNIQUE, 'Tarih' TEXT NOT NULL,   PRIMARY KEY('ID' AUTOINCREMENT))";
                    command.ExecuteNonQuery();
                }
                
                



               
            }

        }
        public void YorumKaydet(int Id,string ad,string soyad)
        {
        
                using (var connection = new SqliteConnection("Data Source=kutuphane.db"))
                {

                    connection.Open();

                    var command = connection.CreateCommand();
                    yorum = yorum.Replace("'", "''");

                    command.CommandText = "Insert into '" + Id + "'(OgrenciAd, OgrenciSoyad, Yorum, Tarih) Values ('" + ad + "','" + soyad + "','" + yorum + "','" + DateTime.Now.ToString("dd/MMMM/yyyy") + "') ";
                    command.ExecuteNonQuery();
                }
          

        }
        public void PuanKaydet(int Id,int puan)
        {
            using (var connection = new SqliteConnection("Data Source=kutuphane.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "Update Kitaplar set KitapPuan=KitapPuan+" + puan + " , OylayanSayi=OylayanSayi+1 where ID='" + Id + "'";
                command.ExecuteNonQuery();

            }
        }
        public class Kitaplar
        {
            public int id { get; set; }
            public string kitapAd { get; set; }
            public string kitapYazar { get; set; }
            public string kitapAdres { get; set; }
            public float kitapPuan { get; set; }
            public int oylayanSayi { get; set; }
        }
        public class Yorumlar
        {
            public int id { get; set; }
            public string OgrenciAd { get; set; }
            public string OgrenciSoyad { get; set; }
            public string Yorum { get; set; }
            public string Tarih { get; set; }

        }
    }
}
