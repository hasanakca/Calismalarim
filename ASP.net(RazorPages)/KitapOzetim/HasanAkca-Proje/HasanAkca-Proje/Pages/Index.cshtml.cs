using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.Sqlite;


namespace HasanAkca_Proje.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string email { get; set; }
        [BindProperty]
        public string sifre { get; set; }

        public string hata = "";

        public List<Kullanicilar> KullaniciListe { get; set; }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            KullaniciOku();
            foreach (var item in KullaniciListe)
            {
                if (item.email == email && item.sifre == sifre)
                {
                    HttpContext.Session.SetString("Ad", item.ad);
                    HttpContext.Session.SetString("Soyad", item.soyad);
                    Response.Redirect("Anasayfa");
                }
                else
                {
                    hata = "*Kullanýcý adý veya þifre hatalý";
                }
            }

        }

        public void KullaniciOku()
        {
            KullaniciListe = new List<Kullanicilar>();
            using (var connection = new SqliteConnection("Data Source=kutuphane.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "select * from Kullanicilar";



                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Kullanicilar kullanici = new Kullanicilar();
                        kullanici.id = reader.GetInt32(0);
                        kullanici.email = reader.GetString(1);
                        kullanici.sifre = reader.GetString(2);
                        kullanici.ad = reader.GetString(3);
                        kullanici.soyad = reader.GetString(4);
                        KullaniciListe.Add(kullanici);

                    }
                }
            }
        }
        public class Kullanicilar
        {
            public int id { get; set; }
            public string email { get; set; }
            public string sifre { get; set; }
            public string ad { get; set; }
            public string soyad { get; set; }
        }
    }
}
