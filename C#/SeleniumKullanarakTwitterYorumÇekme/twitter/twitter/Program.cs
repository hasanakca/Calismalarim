using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System.Threading;
using System.IO;
namespace twitter
{
    class Program
    {
        
        
        
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("tweets.txt");
            ChromeDriver drv; Thread th;
            bool enter = false;
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\chromedriver_win32");
            service.HideCommandPromptWindow = false;
            drv = new ChromeDriver(service);
            drv.Navigate().GoToUrl("https://twitter.com/search?q=%40pegasusdestek&src=typed_query");
            Thread.Sleep(3000);
            

            for (int i = 0; i < 5; i++)
            {
                
                IReadOnlyCollection<IWebElement> searchResult = drv.FindElements(By.CssSelector("div>div>div>article>div>div>div>div>div>div>div>div"));


                foreach (var item in searchResult)
                {
                    if (item.Text != "" && item.Text != " " && item.Text != "Sponsorlu" && item.Text.Length > 20 && !item.Text.Contains("yanıt olarak") && !item.Text.Contains("hassas içerik barındırıyor olabilir") && !item.Text.Contains("Arçelik"))
                    {
                        try
                        {
                            if (item.Text.Contains("\n") && item.Text.Contains(item.Text.Split('\n')[2]) && item.Text.Split('\n')[2].Length < 6)
                            {

                            }
                            else
                            {

                                //sw.WriteLine(item.Text.Replace('\n', ' '));
                                sw.WriteLine(item.Text.Replace('\n', ' ').Trim() + "\n");
                                Console.WriteLine(item.Text.Replace('\n', ' ').Trim() + "\n");
                            }
                        }
                        catch (Exception)
                        {

                            //sw.WriteLine(item.Text.Replace('\n', ' ') );
                            sw.WriteLine(item.Text.Replace('\n', ' ').Trim() + "\n");
                            Console.WriteLine(item.Text.Replace('\n', ' ').Trim() + "\n");
                        }





                    }

                }
                IJavaScriptExecutor js = drv as IJavaScriptExecutor;
                js.ExecuteScript("window.scrollBy(0,10000);");
                Thread.Sleep(3000);
            }
            
            

            
            sw.Close();
        }
    }
}
