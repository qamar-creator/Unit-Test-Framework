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
    class AccountClearance
    {
        public static void accountclearance()
        {

            int flag = 0;


            delayfor.delay();

            try
            {
                //check if duplicate account
                string text=CustomControlsGets.GettextfromLabel("//a[normalize-space()='Request for Approval']", propertytype.XPath);
                Console.WriteLine(text);
            }
            catch (Exception  )
            {
                Console.WriteLine("There is no duplicate account");
                flag = 1;

            }

            finally
            {
                if (flag == 0)
                {
                    Console.WriteLine("There is a duplicate account ");
                    // click on approve button
                    CustomControls.click("//a[normalize-space()='Request for Approval']", propertytype.XPath);
                }
            }

            delayfor.delay();
           
            IWebElement button = PropertiesCollection.ngdriver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/form[1]/div[11]/div[3]/div[2]/div[1]/a[1]"));
            Assert.IsTrue(button.Enabled);
            // click to submit
            

            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.click("#ctl00_cphMain_cntrlChangeStatus_rpt_ctl00_btnStatus", propertytype.CssSelector);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


        }




    }
}