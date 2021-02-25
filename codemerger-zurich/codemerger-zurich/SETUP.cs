using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using System.IO;
using OpenQA.Selenium.Support.UI;
using Protractor;

namespace codemerger_zurich
{
   public class SETUP
    {
        public static string Expectedresult;
        public static string Actualresult;
      

        public  static void TestMethodLogin()
        {
            Expectedresult = "Dashboard";
            PropertiesCollection.ngdriver = new ChromeDriver();
            string url = ConfigurationManager.AppSettings.Get("url");
                      
            PropertiesCollection.ngdriver.Navigate().GoToUrl(url);
            Console.WriteLine("landed on the login page");
            CustomControls.Entertext("#txtLoginId", ConfigurationManager.AppSettings.Get("username"), propertytype.CssSelector);
            CustomControls.Entertext("#txtPassword", ConfigurationManager.AppSettings.Get("password"), propertytype.CssSelector);
            CustomControls.click("#btnLogin", propertytype.CssSelector);
            delayfor.delay();
            Actualresult = CustomControlsGets.GettextfromLabel("div[class='col-lg-7'] h2", propertytype.CssSelector);
            Console.WriteLine("The landed page lands on " + Actualresult);
            Assertions.assertionequals(Actualresult, Expectedresult);
        }



        
    }
}
