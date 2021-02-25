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

    public class submission
    {




        public static void submissionscn()

        {
            delayfor.delay();
            CustomControls.click("li[id='ctl00_MenuControl_UnderwritingBoxMenu'] span[class='caret']", propertytype.CssSelector);
            CustomControls.click("#ctl00_MenuControl_hlSubmission", propertytype.CssSelector);
            //send keys for proposed due date
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtx02ecc523-2b8f-4e40-a475-84acb1bc5e02", "2/11/2020", propertytype.CssSelector);
            // send keys for proposed effective date
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtx2418188d-557b-47f1-b6cb-c16a0a5c7384", "2/11/2020", propertytype.CssSelector);
            // click on side to disappear the calanders
            CustomControls.click("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxc5ff5bfb-0cc0-42e6-a973-93831cebffdd", propertytype.CssSelector);
        }

        public static void Accountinformation()
        {
            // sendkeys for account information

            string location = "Automation 2/24/2021";
            string address1 = "New Bridge, Lane05";
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxc5ff5bfb-0cc0-42e6-a973-93831cebffdd", location, propertytype.CssSelector);
            Globalelements.locationinfo = location;
            // sendKeys for DBA
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxf02d21b7-9f28-4330-ac9b-2a2d1be52afb", "DBA", propertytype.CssSelector);
            // sendkeys for Address1
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtx8c2cf029-d365-4cfa-89bc-0d33dd70dc1b",address1 , propertytype.CssSelector);
            Globalelements.Address1 = address1;
            // sendkeys for address2
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxa5f9fc3f-7b45-4432-ae7a-91e548bcd4be", "House no.55", propertytype.CssSelector);
             // sendkeys for city
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtx70dbfee1-01f7-45d5-8499-4d1d75a8bab0"," AlabamaCity" ,propertytype.CssSelector);
            //select state from dropdown
            CustomControls.Selectdropdown("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpl56b20cb6-929a-480f-a522-8a4dc2a4aa90", "Alabama", propertytype.CssSelector);
            // send keys for zip
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtx65de1d35-112f-4720-acd1-c7d1ac047183", "35005", propertytype.CssSelector);
            // send keys web site address
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtx685578bd-cc46-4fb7-b0c7-af1b0cea0783", "www.gboiq.com", propertytype.CssSelector);


        }
        public static void Accountcontactinfo()
        {

            //send keys for title
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxab9780f4-c715-448c-9a40-811da43e5a87", "RFP AL statevaribility", propertytype.CssSelector);
            //send keys for Name
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxe4d817f2-6eac-432a-a63b-ebac2976cdf8", "RFP AL statevaribility", propertytype.CssSelector);
            // send keys for phone
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxcc6415ab-05e8-47ba-859b-66fe5d551a30","9088777717" ,propertytype.CssSelector);
            // send keys for email
            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtx1070ad7f-68de-4c57-83f5-5730dfec076f", "gboiq@iq.com", propertytype.CssSelector);

        }

        public static void MarketProductsection()
        {
            //select market segment
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.Selectdropdown("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpladac9c07-bcb2-4090-937b-767fbf8fac3f", "Corporate", propertytype.CssSelector);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
            delayfor.delay();

            // select available form
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.Selectdropdown("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpl6269d11a-a63c-4b81-83d6-da47d249c77f", "U-VA-1001-B", propertytype.CssSelector);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
           
            delayfor.delay();

            // select product
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.Selectdropdown("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpl71437492-8fbd-497a-ac84-df35abf2c6e5", "Basic AD&D", propertytype.CssSelector);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

           
            delayfor.delay();

            // selct upc
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.Selectdropdown("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpl53e1c9b1-02b2-47ed-adc6-8257dc60037e", "0866 - CARVEOUT PRINCIPAL", propertytype.CssSelector);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
           
            delayfor.delay();
            // select available group
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.Selectdropdown("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpla1602ad7-726b-4452-ae07-73469618a59d", "Employers (employees)", propertytype.CssSelector);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
           


        }


        public static void additionalaccountinfo()

        {
            // click SIC box

            CustomControls.Entertext("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_txtxf17a9de8-10cf-4b56-9caa-96e70c0f8d85", "METAL MINING", propertytype.CssSelector);
           
            
            // select first option
            CustomControls.click("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_lbl0981a885-2078-4c7d-a056-1134315f47b7", propertytype.CssSelector);

        }


        public static void AccountRepresentative()

        {
            //underwriting Analyst

            CustomControls.Selectdropdown("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drpl55bfb7f4-3328-4677-8e0b-802fb59ac281", "System User", propertytype.CssSelector);

            // select dist.manager

            CustomControls.Selectdropdown("#ctl00_cphMain_answercontrolb1337459bb244e7989effbf59d6cb1c7_drplae6440fd-28d2-4737-b6fd-789c17e6c450", "S Test", propertytype.CssSelector);

        }

        public static void Next()

        {
            CustomControls.click("#ctl00_cphMain_btnbuttonSubmissionSaveSave", propertytype.CssSelector);


        }
    }

}