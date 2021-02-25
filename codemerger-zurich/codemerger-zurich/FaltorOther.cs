using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codemerger_zurich
{
    class FaltOrOther
    {

      public static void TPApercentage(string percentage)
      
        {
            // enter TPA percentage
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.Entertext("#ctl00_cphMain_cntrlAccountTPA_txtTPACommission", percentage, propertytype.CssSelector);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
           
        }


        public static void TPAFlat (string flat)

        {

            // check the flat checkbox
           for(int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.click("div[class='iradio_square-green checked'] ins[class='iCheck-helper']", propertytype.CssSelector);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
           
            //enter TPA Flat amount
            for(int i = 0; i <= 2; i++)
            {
                try
                {
                    CustomControls.Entertext("#ctl00_cphMain_cntrlAccountTPA_txtTPAFlatAmount", flat, propertytype.CssSelector);
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
