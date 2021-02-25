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
    [TestClass]
   
    public  class Login
    {
            

        [TestMethod]
        [Priority(4)]
        public  void LogIN()

        {
            SETUP.TestMethodLogin();
            
        }

        [TestMethod]
        [Priority(5)]
        public  void Teardown()
        {

            PropertiesCollection.ngdriver.Close();
            PropertiesCollection.ngdriver.Quit();
        }
         
    }
}
