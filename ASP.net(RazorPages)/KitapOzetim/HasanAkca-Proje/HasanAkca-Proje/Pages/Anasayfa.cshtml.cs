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
    public class AnasayfaModel : PageModel
    {
        public string ad, soyad;

        public List<Kitaplar> KitapListe { get; set; }
        public void OnGet()
        {
            if (HttpContext.Session.GetString("Ad") != null)
            {
                ad = HttpContext.Session.GetString("Ad");
                soyad = HttpContext.Session.GetString("Soyad");
                KitapAc();
            }
            else
            {
                KitapAc();
                //Response.Redirect("Index");
            }
           
        }
        public void KitapAc()
        {
            KitapListe = new List<Kitaplar>();
            using (var connection = new SqliteConnection("Data Source=kutuphane.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "select * from Kitaplar order by KitapAd";



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
        public class Kitaplar
        {
            public int id { get; set; }
            public string kitapAd { get; set; }
            public string kitapYazar { get; set; }
            public string kitapAdres { get; set; }
            public float kitapPuan { get; set; }
            public int oylayanSayi { get; set; }
        }
    }
}
