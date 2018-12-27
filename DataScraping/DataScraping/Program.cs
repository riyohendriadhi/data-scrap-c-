using OpenQA.Selenium.Chrome;
using System;

namespace DataScraping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var option = new ChromeOptions();
            option.AddArgument("disable-infobars");
            option.AddArgument("user-data-dir=C:\\Users\\r.hendriadhi\\AppData\\Local\\Google\\Chrome\\UserData");

            var driver = new ChromeDriver("./");
            driver.Manage().Window.Maximize();
            for (int i = 0; i < 5; i++)
            {
                driver.Url = "http://www.jango.com/music/Avenged+Sevenfold";
                driver.FindElementById("player_pp_icon").Click();

                driver.FindElementById("player_ff_icon").Click();

                driver.FindElementById("player_pp_icon").Click();
            }

            //driver.Close();

        }
    }
}
