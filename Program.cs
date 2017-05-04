using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the student's name: ");
            string name01 = Console.ReadLine();

            Console.Write("Insert the student's GPA: ");
            double gpa01 = double.Parse(Console.ReadLine());

            Console.Write("Insert the student's credit hours: ");
            int credit01 = int.Parse(Console.ReadLine());

            Console.Write("Insert the student's major: ");
            string major01 = Console.ReadLine();

            Console.Write("\nInsert number of exams: ");
            int numExams01 = int.Parse(Console.ReadLine());

            CS37Student student01 = new CS37Student();
            student01.name = name01;
            student01.gpa = gpa01;
            student01.credits = credit01;
            student01.major = major01;
            double ExamsNote = student01.ExamsAverage(numExams01);

            Console.Write("\nInsert number of homeworks: ");
            int numHW01 = int.Parse(Console.ReadLine());
            double HWsNote = student01.HomeWorksAverage(numHW01);
            Console.Write(
                "\nStudent: " + student01.name +
                "\nGPA: " + student01.gpa +
                "\nCredits: " + student01.credits +
                "\nMajor: " + student01.major +
                "\nExams average: " + ExamsNote +
                "\nHomeworks average: " + HWsNote);
            Console.ReadKey();
        }
    }
}
