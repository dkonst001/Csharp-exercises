using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targilim1_Maman11
{
    class Program
    {
        static void Main(string[] args)
        {
            //q2
            Painting painting = new Painting(2013);
            painting.PaintingPrint();
            //StatuePrint does not exist in class Painting
            //painting.StatuePrint();
            painting.ExhibitPrint();
            Exhibit exhibit1 = new Exhibit(2000);
            exhibit1.ExhibitPrint();
            // PaintingPrint does not exist in class Exhibit
            //exhibit1.PaintingPrint();
            ((Painting)exhibit1).PaintingPrint();
            //Missing creationYear as constructor parameters
            //Exhibit exhibit2 = new Painting();
            //Wrong Instance name
            //Exhibit1.ExhibitPrint();
            //PhotographPrint does not exist in class Exhibit
            //exhibit1.PhotographPrint();
            Statue exhibit3 = new Statue(2010);
            exhibit3.ExhibitPrint();
            Photograph exhibit4 = new Photograph(2005);
            exhibit4.PhotographPrint();

            //q3
            //This is a great painting
            //The exhibit was created in 2013
            //This is a great exhibit
            //This is a great painting
            //The statue was created in 2010
            //This is a great photograph

            //q4
            //Shape צורה
               //TwoDimensionalShape צורה דו - ממדית
                   //Triangle משולש
                     //RightTriangle משולש ישר - זווית
                     //IsoscelesTriangle משולש שווה - שוקיים
                        //EquilateralTriangle משולש שווה - צלעות

                    //Circle עיגול
                    //Square ריבוע
                       //Rectangle מלבן

            //ThreeDimensionalShape צורה תלת - ממדית

               //Sphere כדור
               //Box תיבה

                   //Pyramid פירמידה
                   //Cube קוביה

               //Cylinder גליל
                 //Cones חרוט

        }
    }
}
