using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace codemerger_zurich
{
    class Classdetails
    {
        public static void classdetails()
        {
            //choose from dropdown for description
            CustomControls.Selectdropdown("#ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_cntrl13p4419_drpListClass", "All active pilots of the Policyholder.", propertytype.CssSelector);
            //SIC
            delayfor.delay();
            CustomControls.Entertext("#ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_cntrl13p4419_txtASic", "(1100)ANTHRACITE MINING", propertytype.CssSelector);
            Thread.Sleep(9000);
            // enter  eligible employee  
            CustomControls.Entertext("#ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_cntrl13p4419_txtEligibleEmployees", "1", propertytype.CssSelector);
            
            // comments
            CustomControls.Entertext("//textarea[@id='ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_cntrl13p4419_txtComments']", "1", propertytype.XPath);
            // save

            CustomControls.click("#ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_cntrl13p4419_lnkAdd", propertytype.CssSelector );
             
            // next
            CustomControls.click("#ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_StepNavigationTemplateContainerID_StepNextButton", propertytype.CssSelector);


        }
    }
}
