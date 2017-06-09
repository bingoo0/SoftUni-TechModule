
namespace _2.JSON_stringify
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int[] Grades { get; set; }
    }
    class JsonStringify
    {
        public static void Main()
        {
            var students = new List<Student>();

            var inputLine = Console.ReadLine();

            while (inputLine != "stringify")
            {
                var inputParams = inputLine.Split(new[] { ' ', ',', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);

                var studentName = inputParams[0];
                var studentAge= int.Parse(inputParams[1]);
                var studentGrade = inputParams.Skip(2).Select(int.Parse).ToArray();

                Student newStudent = new Student();

                newStudent.Name = studentName;
                newStudent.Age = studentAge;
                newStudent.Grades = studentGrade;

                students.Add(newStudent);
                inputLine = Console.ReadLine();
            } // end while

            var output = string.Empty;

            output += "[";

            for (int i = 0; i < students.Count; i++)
            {
                var currentStudent = students[i];

                output += "{";

                output += "name:\"" + currentStudent.Name + "\"" + ",";
                output += "age:" + currentStudent.Age + ",";
                output += "grades:["+ string.Join(", ", currentStudent.Grades)+ "]";

                output += "}";

                if (i < students.Count - 1)
                {
                    output += ",";
                }
            }
            output += "]";

            Console.WriteLine(output);
        }
    }
}
