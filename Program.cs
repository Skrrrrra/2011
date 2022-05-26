using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AgeAnalysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //путь
            string inputpath = "D:\\SolutionsForSpaceApp\\2011\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2011\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();

            int age = Convert.ToInt32(File.ReadAllText(inputpath));

            int grade = age - 7;
            int path = age - 18;
            List<string> pathh = new List<string>() { "first year", "second year", "third year", "fourth year", "fifth year" };

            if (age > 150 && age < 0)
            {
                File.WriteAllText(outputpath,"Incorrect age, try again");
            }
            else
            {
                if (age < 7)
                {
                    File.WriteAllText(outputpath, "u're a preschool child");
                }
                else if (age <= 17 && age >= 7)
                {
                    File.WriteAllText(outputpath, $"u're a schoolchild and u learn in { grade}th grade");
                }
                else if (age <= 22 && age >= 18)
                {
                    File.WriteAllText(outputpath, $"u're a {pathh[path]} student");
                }
                else if (age > 22)
                {
                    File.WriteAllText(outputpath, "u're a specialist");
                }
            }





        }
    }
}
