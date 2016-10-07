using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public static class GSMTest
    {
        static GSM firstGSM = null;
        static GSM lastGSM = null;

        public static GSM AddGSM(string model,
            string manufacturer, decimal price, string owner,
            Battery phoneBattery, Screen phoneScreen)
        {
            GSM gsm = new GSM(model, manufacturer, price, owner, phoneBattery, phoneScreen);
            if (lastGSM == null)
            {
                firstGSM = gsm;
                firstGSM.NextGSM = null;
                lastGSM = firstGSM;
            }
            else
            {
                lastGSM.NextGSM = gsm;
                lastGSM = gsm;
            }

            return gsm;

        }

        public static GSM FindGSM(string model, string owner)
        {
            GSM tempGSM = firstGSM;
            while (tempGSM != null)
            {
                if ((tempGSM.Model == model) && (tempGSM.Owner == owner))
                {
                    Console.WriteLine(tempGSM.ToString());
                    return tempGSM;
                }

                tempGSM = tempGSM.NextGSM;
            }
            return null;
        }

        public static void PrintUsageReport()
        {
            GSM tempGSM = firstGSM;
            while (tempGSM != null)
            {
                Console.WriteLine("Total cost of calls for {0} {1} is: {2} ", tempGSM.Owner, tempGSM.Model, tempGSM.TotalAmount(3.23m));
                tempGSM = tempGSM.NextGSM;
            }
            

            
        }
    }
}
