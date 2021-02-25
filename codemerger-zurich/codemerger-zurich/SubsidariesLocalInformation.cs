using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codemerger_zurich
{
    class SubsidariesLocalInformation
    {

        public static void AdditionalInsured(Boolean addadditional)
        {
            if(addadditional ==true)
            {
                CustomControls.click("//body[1]/div[5]/div[1]/form[1]/div[11]/div[19]/div[5]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[3]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/ins[1]", propertytype.XPath);

            }


        }
        public static void addnew()
        {


        }

        public static void LocalInformation(long insurednum, long PML)
        {

            Globalelements.Expectedresult = "Foreign Travel";
            Globalelements.Actualresult = null;

            long Max = 999999999999;
            int min = 0;

            DataValidations.Locationinfosdatavalidations();
             if (insurednum > Max || insurednum < min||PML>Max||PML<min)
            {

                Console.WriteLine("The  value for Number of insured/PML does not fall in limit,please check");
            }

          
            string insurednumm = insurednum.ToString();
            string PMLl = PML.ToString();
            // enter number of insured
             CustomControls.Entertext("/html[1]/body[1]/div[5]/div[1]/form[1]/div[11]/div[19]/div[5]/table[1]/tbody[1]/tr[1]/td[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/span[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[8]/div[1]/span[2]/div[1]/span[1]/input[1]", insurednumm, propertytype.XPath);
            //enter PML
            CustomControls.Entertext("/html[1]/body[1]/div[5]/div[1]/form[1]/div[11]/div[19]/div[5]/table[1]/tbody[1]/tr[1]/td[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/span[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[9]/div[1]/span[2]/div[1]/span[1]/input[1]", PMLl, propertytype.XPath);
            // click save
            CustomControls.click("/html[1]/body[1]/div[5]/div[1]/form[1]/div[11]/div[19]/div[5]/table[1]/tbody[1]/tr[1]/td[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/span[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[12]/div[1]/div[1]/a[1]", propertytype.XPath);
            delayfor.delay();
            //click next button
            CustomControls.click("#ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_StepNavigationTemplateContainerID_StepNextButton", propertytype.CssSelector);
            delayfor.delay();
            // verify next page
            try
            {
                Globalelements.Actualresult = CustomControlsGets.GettextfromLabel("/html[1]/body[1]/div[3]/div[1]/form[1]/div[11]/div[19]/div[5]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/div[1]/div[1]/h2[1]/span[1]", propertytype.XPath);
            }
            catch (Exception)
            {
                Globalelements.Expectedresult = "not able to get on the page";
            }
            finally
            {
                Console.WriteLine("The next screen is" + Globalelements.Actualresult);
                Assert.AreEqual(Globalelements.Expectedresult,Globalelements.Actualresult, "The number of Insured or PML may be out of limit");
            }
        }
    }
}
