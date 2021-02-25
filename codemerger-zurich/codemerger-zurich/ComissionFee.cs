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
    class ComissionFee
    {

        public static void comissionfee ()
        {
            string commissionanfservicefee = CustomControlsGets.Geettextfromtextbox("#ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_cntrl90p3081_txtBrokerCommission", propertytype.CssSelector);
            Console.WriteLine("The commisiion fee in the box is    " + commissionanfservicefee);
            Assertions.assertionequals(commissionanfservicefee, Globalelements.Commision);
            string premiumtaxLicense = CustomControlsGets.Geettextfromtextbox("#ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_cntrl90p3081_txtPremiumTax", propertytype.CssSelector);
            Console.WriteLine(" premium tax license fee in the box is    " + premiumtaxLicense);
            string otherunderwriting = CustomControlsGets.Geettextfromtextbox("#ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_cntrl90p3081_txtGeneralOperatingExpenses", propertytype.CssSelector);
            Console.WriteLine(" other underwriting fee in the box is    " + otherunderwriting);
            string profitandcontin = CustomControlsGets.Geettextfromtextbox("#ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_cntrl90p3081_txtProfitMargin", propertytype.CssSelector);
            Console.WriteLine("  profit & contingenes fee in the box is    " + profitandcontin);

            string totalexpenseNprofit = CustomControlsGets.Geettextfromtextbox("#ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_cntrl90p3081_txtFieldAmount1", propertytype.CssSelector);
            Console.WriteLine("  total profit and expense in the box is    " + totalexpenseNprofit);

            string totalLossRatio = CustomControlsGets.Geettextfromtextbox("#ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_cntrl90p3081_txtFieldAmount2", propertytype.CssSelector);
            Console.WriteLine("  total loss Ratio in the box is    " + totalLossRatio);

            //click next button
             CustomControlsGets.Geettextfromtextbox("#ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_StepNavigationTemplateContainerID_StepNextButton", propertytype.CssSelector);
        }
    }
}
