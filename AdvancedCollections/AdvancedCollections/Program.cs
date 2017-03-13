using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, List<double>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var nameAndGrade = Console.ReadLine().Split();
                var name = nameAndGrade[0];
                var grades = double.Parse(nameAndGrade[1]);

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                }
                students[name].Add(grades);

            }

            foreach (var gradesAndNames in students)
            {
                var name = string.Join(" ",gradesAndNames.Key);
                var grade = string.Join(" ", gradesAndNames.Value.Select(p => string.Format("{0:f2}", p)));

                var average = gradesAndNames.Value.Average();
                Console.WriteLine("{0} -> {1} (avg: {2:f2})", name, grade, average);
            }
        }
    }
}
