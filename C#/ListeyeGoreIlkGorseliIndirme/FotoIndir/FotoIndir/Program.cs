using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;


namespace FotoIndir
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader kelimeler = new StreamReader("kelime.txt");
            List<String> baslik = new List<String>();

            while (!kelimeler.EndOfStream)
            {
                baslik.Add(kelimeler.ReadLine().Split(',')[1].Trim());
            }
            kelimeler.Close();
            //String data = "";
            
            
        
           

            //Console.ReadLine();
            
            WebClient webClient = new WebClient();
            
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            
            for (int i = 0; i < baslik.Count; i++)
            {
                String urld = "https://www.google.com/search?tbm=isch&q=" + baslik[i];
                WebRequest request = WebRequest.Create(urld);
                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(dataStream, Encoding.ASCII);
                var data = sr.ReadToEnd();
                var urls = new List<string>();
                int ndx = data.IndexOf("<img class=", StringComparison.Ordinal);
                ndx = data.IndexOf("<img", ndx, StringComparison.Ordinal);
                while (ndx >= 0)
                {
                    ndx = data.IndexOf("src=\"", ndx, StringComparison.Ordinal);
                    ndx = ndx + 5;
                    int ndx2 = data.IndexOf("\"", ndx, StringComparison.Ordinal);
                    string url = data.Substring(ndx, ndx2 - ndx);
                    urls.Add(url);
                    ndx = data.IndexOf("<img", ndx, StringComparison.Ordinal);
                }

                request = WebRequest.Create(urls[1]);
                response = request.GetResponse();
                if (!Directory.Exists("resimler"))
                {
                    Directory.CreateDirectory("resimler");
                }
                webClient.DownloadFile(urls[1], "resimler/" + baslik[i] + ".png");
                

                response.Close();
            }
            

            Console.ReadLine();

        }
    }
}
