using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace ConsoleApplication3
{
    [TestFixture]
    class Program
    {
        static void Main(string[] args)
        {
           
        }



        [OneTimeSetUp]
        public void Initialization()
        {
            Utils._webdriver = new ChromeDriver();
            Utils.UrlToNavigate = "https://accounts.google.com/signin/v2/identifier?service=mail&passive=true&rm=false&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&ss=1&scc=1&ltmpl=default&ltmplcache=2&emr=1&osid=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
        }
        [TestCase("elyanivson@gmail.com", "77777777")]
        public void Login(string userName, string password)
        {
            Utils.NavigateToUrl(Utils.UrlToNavigate);
            var LoginToGmail = new LoginPage(userName: userName, password: password);
            LoginToGmail.LoginToGmail();
        }

        [TestCase("", "77777777")]
        public void LoginFailed(string userName, string password)
        {
            Utils.NavigateToUrl(Utils.UrlToNavigate);
            var LoginToGmail = new LoginPage(userName: userName, password: password);
            Assert.Throws<Exception>(() => LoginToGmail.LoginToGmail(), "expcted login failure but login succeed");
            
        }

    }
}
