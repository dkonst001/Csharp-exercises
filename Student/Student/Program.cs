using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using System.Windows;

namespace Student
{
    enum BatteryType { Li_Ion, NiMH, NiCd }

    class Program
    {
        static void Main(string[] args)
        {
            //q1 to q7
            StudentTest.AddStudent("name1", "course1", "subject1");
            StudentTest.AddStudent("name2", "course2", "subject2");
            StudentTest.AddStudent("name3", "course3", "subject3");
            StudentTest.FindStudent("name1");
            StudentTest.FindStudent("name2");
            StudentTest.FindStudent("name3");
            Console.ReadLine();

            //q8 to q19


            Color screenColor= Color.AliceBlue;

            //Colors color = Colors.FromKnownColor(KnownColor.MenuText);
            Battery batteryForNexus5x = new Battery("MexusBat", new TimeSpan(5, 2, 3), new TimeSpan(9, 0, 0));
            Screen screenForNexus5x = new Screen(5.5m,screenColor);

            GSM gsm;
            gsm = GSMTest.AddGSM("Nexus5x", "LG", 1500, "Danny", batteryForNexus5x, screenForNexus5x);

            Call call = new Call(DateTime.Parse("1 June 2013 12:32"), TimeSpan.Parse("0:10:35"));
            gsm.AddCall(call);

            GSMTest.PrintUsageReport();
            Console.ReadLine();



        }

        
        
        //////------------------------------------------------------------------------
        
        
        
    }
}

