using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codemerger_zurich
{
    public class producerTPA
    {
       

        public static void Producer()
        {
            // click on search button

            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.click("#ctl00_cphMain_ClientBrokerContact_btnBroker", propertytype.CssSelector);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

             
            delayfor.delay();
            //enter text to search which agency

            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.Entertext("#ctl00_cphMain_ClientBrokerContact_cntrlBroker_txtBrokerLeft", "demo agency", propertytype.CssSelector);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
            delayfor.delay();
            // click to search that agency



            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.click("#ctl00_cphMain_ClientBrokerContact_cntrlBroker_btnSearch", propertytype.CssSelector);
                    delayfor.delay();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            delayfor.delay();

            // click to choose that agency from the list

            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.click("#ctl00_cphMain_ClientBrokerContact_cntrlBroker_grdBrokerList_ctl03_lnkSelect", propertytype.CssSelector);
                    break;
                }
                catch (Exception e)
                {
                   Console.WriteLine(e.Message);
                }
            }
            
        }


        public static void Agent()
        {
            // click on search button
            delayfor.delay();
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.click("#ctl00_cphMain_ClientBrokerContact_btnContact", propertytype.CssSelector);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


            delayfor.delay();
            // click to choose that agent from the list (demoagentthreeA)

            CustomControls.click("#ctl00_cphMain_ClientBrokerContact_cntrlBrokerContact_grdBrokerContact_ctl03_lnkSelect", propertytype.CssSelector);
            // get the attribute from commission text box

            Globalelements.Commision = CustomControlsGets.Geettextfromtextbox("#ctl00_cphMain_ClientBrokerContact_txtBrokerCommission", propertytype.CssSelector);
            Console.WriteLine(" The commission enetered is " + Globalelements.Commision );

            delayfor.delay();
            // click save producer
            CustomControls.click("#ctl00_cphMain_ClientBrokerContact_btnSave", propertytype.CssSelector);
            delayfor.delay();
        }   

        public static void TPA()
        {
            // click claims TPA search button

            CustomControls.click("#ctl00_cphMain_cntrlAccountTPA_btnBroker", propertytype.CssSelector);
            delayfor.delay();
            // click TPA search button
            CustomControls.click("#ctl00_cphMain_cntrlAccountTPA_cntrlBroker_btnSearch", propertytype.CssSelector);
            delayfor.delay();
            // choose TPA from the list
               
            CustomControls.click("#ctl00_cphMain_cntrlAccountTPA_cntrlBroker_grdBrokerList_ctl03_lnkSelect", propertytype.CssSelector);
            // enter flat amout for TPA ,call flatorother function

            FaltOrOther.TPAFlat("15000");

            // click save button
            CustomControls.click("#ctl00_cphMain_cntrlAccountTPA_btnSave", propertytype.CssSelector);

            // click next button
            CustomControls.click("#ctl00_cphMain_btnNextStep1", propertytype.CssSelector);
        }

    }

}