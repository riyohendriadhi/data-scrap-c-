using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace DataScraping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var options = new ChromeOptions();
            options.AddArgument("disable-infobars");
            //options.AddArgument("user-data-dir=C:\\Users\\r.hendriadhi\\AppData\\Local\\Google\\Chrome\\UserData");

            var driver = new ChromeDriver("./",options);
            driver.Manage().Window.Maximize();
            //driver.FindElementById("player_pp_icon").Click();

            Thread.Sleep(3000);

            //driver.Url = "http://www.jango.com/music/Avenged+Sevenfold";
            //for (int i = 0; i < 5; i++)
            //{
            //    driver.FindElementById("player_ff_icon").Click();

            //}
            //driver.FindElementById("player_pp_icon").Click();

            driver.Url = "https://www.hipstercode.com/";
            driver.ExecuteJavaScript<string>("allert('Haii Test')");
            //driver.Close();

        }
    }
}
