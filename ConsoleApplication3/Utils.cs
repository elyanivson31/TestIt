using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;

namespace ConsoleApplication3
{
   
    class Utils
    {
        public static IWebDriver _webdriver;
        public static string UrlToNavigate="";
        public static void NavigateToUrl(string urlToNavigate)
        {
            _webdriver.Navigate().GoToUrl(url: urlToNavigate);
        }
    }
}
