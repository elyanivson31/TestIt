using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
namespace ultimateqa
{
      class LoginPage
    {
        [FindsBy(How = How.Id,Using ="")]
        public static IWebElement userNameElement;

        string userName;
        string password;
        string sss = "";

       public  LoginPage(string userName,string password)
        {
            this.userName = userName;
            this.password = password;
            var driver = new ChromeDriver();
            driver.FindElement(By.Id(""));
        }

        public static  void LoginToPageSuccessfully()
        {
            userNameElement.SendKeys("");
        }
    }
}
