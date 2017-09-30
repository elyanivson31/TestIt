using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApplication3
{
    class LoginPage
    {
        [FindsBy(How = How.CssSelector, Using = "#identifierId")]
        private IWebElement userNameElement;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement passwordElement;

        [FindsBy(How = How.CssSelector, Using = "#identifierNext>content")]
        private IWebElement nextButton;

        WebDriverWait wait;
        string userName;
        string password;
        public LoginPage(string userName, string password = "")
        {
            PageFactory.InitElements(Utils._webdriver, this);
            this.userName = userName;
            this.password = password;
            wait = new WebDriverWait(Utils._webdriver, new TimeSpan(0,0,15));
        }

        public void LoginToGmail()
        {
            try
            {
                userNameElement.SendKeys(userName);
                nextButton.Click();
                //throw new Exception();
            }
            catch(Exception e) {
                throw new Exception("failed to fill uername");
            }

            passwordElement.SendKeys(password);

        }

        public class YanivException: Exception
        {

        }
    }
}
