using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class CS37Student : UndergradStudent
    {
        private double examAve;
        private double hwAve;

        public double ExamsAverage(int numExams)
        {
            double y = 0;
            for (int i = 0; i < numExams; i++)
            {
                Console.Write("Insert exam number " + (i + 1) + " : ");
                double Exam = double.Parse(Console.ReadLine());
                y = Exam + y;

            }
            examAve = y / numExams;
            return examAve;
        }

        public double HomeWorksAverage(int numHWs)
        {
            double y = 0;
            for (int i = 0; i < numHWs; i++)
            {
                Console.Write("Insert homework number " + (i + 1) + " : ");
                double HW = double.Parse(Console.ReadLine());
                y = HW + y;

            }
            hwAve = y / numHWs;
            return hwAve;
        }
    }
}
