using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codemerger_zurich
{
    class ForiegnTravel
    {

        

        public static void forTravle()
        {
            // clicking afganistan as a risk country
            CustomControls.click("//input[@id='ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_answercontrola6d38118b74a441898039c9321848d409R1C0B2666_chkl46364980-6b6f-4f33-ac99-0d17fefe91ea_0']", propertytype.XPath);
            // clicking next 
            CustomControls.click("//input[@id='ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_StepNavigationTemplateContainerID_StepNextButton']", propertytype.XPath);

        }

        public static void noforiegntravle()
        {
            // no travel info
           // CustomControls.click("//div[@class='icheckbox_square-green hover']//ins[@class='iCheck-helper']", propertytype.XPath);
            // clicking next 
            CustomControls.click("//input[@id='ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_StepNavigationTemplateContainerID_StepNextButton']", propertytype.XPath);
        }
    }
}
