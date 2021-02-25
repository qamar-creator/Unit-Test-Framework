using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codemerger_zurich
{
    class Exceptionpolicy

    {

        public static void checkExceptionpolicy( Boolean exceptionboolean)
            {
            switch (exceptionboolean)
            {

                case true:
               CustomControls.click("div[class='iradio_square-green'] ins[class='iCheck-helper']", propertytype.CssSelector);
                    break;
                
            }
                

            delayfor.delay();
            // click on next button
            CustomControls.click("#ctl00_cphMain_cntrlCoverageAddEdit_Wizard1_StepNavigationTemplateContainerID_StepNextButton", propertytype.CssSelector);


        }
    }
}
