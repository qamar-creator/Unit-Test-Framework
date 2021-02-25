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
    public class HazardVariabilityAL

    {



        [TestMethod]
        [Priority(1)]
        public void a_ALSubmission_Screen()

        {

            SETUP.TestMethodLogin();
            submission.submissionscn();
            submission.Accountinformation();
            submission.Accountcontactinfo();
            submission.MarketProductsection();
            submission.additionalaccountinfo();
            submission.AccountRepresentative();
            submission.Next();
            

        }

        [TestMethod]
        [Priority(2)]
        public void b_ProducerAgentTPA()
      {
            producerTPA.Producer();
            producerTPA.Agent();
            producerTPA.TPA();


      }

        [TestMethod]
        [Priority(3)]

        public  void c_CheckAccountClearance()
        {
               AccountClearance.accountclearance();
        }


        [TestMethod]
        [Priority(6)]
        public void d_exceptionpolicy()
        {
            Exceptionpolicy.checkExceptionpolicy(false);
        }


         //[TestMethod]
         //[Priority(7)]
        public void e_CommissionFeeScr5()
        {
            ComissionFee.comissionfee();

        }
        [TestMethod]
        [Priority(8)]


        public void f_Subsidarieslocalinformationscrn()
        {
            SubsidariesLocalInformation.LocalInformation(2, 0);

        }


        [TestMethod]
        [Priority(9)]


        public void g_ForeignTravel()
        {
            ForiegnTravel.noforiegntravle();

        }
        [TestMethod]
        [Priority(10)]


        public void h_policyexclusionslimitations()
        {
            PolicyexclusionsNlimitations.policyexclusionslimitations();

        }




        [TestMethod]
        [Priority(11)]


        public void i_policydefinitions()
        {
            PolicyDefinitions.policydefinitions();

        }


        [TestMethod]
        [Priority(12)]


        public void j_classdetails()
        {
            Classdetails.classdetails();

        }
    }
}
