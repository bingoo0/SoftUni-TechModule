namespace _3.JSON_parse
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
    class Program
    {
        public static void Main()
        {
            {
                var students = new List<Student>();

                var inputLine = Console.ReadLine().Split(new[] { '}' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int i = 0; i < inputLine.Count - 1; i++)
                {
                    var inputParams = inputLine[i].Split(new[] { '[',']',' ', ',',  ':', '}', '{','"',
                    ']', '['}, StringSplitOptions.RemoveEmptyEntries);

                    var studentName = inputParams[1];
                    var studentAge = int.Parse(inputParams[3]);
                    var studentGrade = inputParams.Skip(5).Select(int.Parse).ToArray();

                    Student newStudent = new Student();

                    newStudent.Name = studentName;
                    newStudent.Age = studentAge;
                    newStudent.Grades = studentGrade;

                    students.Add(newStudent);
                }


                var output = string.Empty;

                for (int i = 0; i < students.Count; i++)
                {
                    var currentStudent = students[i];


                    output += currentStudent.Name + " : ";
                    output += currentStudent.Age + "->";
                    output += string.Join(", ", currentStudent.Grades);

                    if (i < students.Count - 1)
                    {
                        output += ",";
                    }
                }

                Console.WriteLine(output);

                //foreach (var student in students)
                //{
                //    Console.WriteLine($"{student.Name} : {student.Age} -> {(student.Grades.Length > 0 ? string.Join(", ", student.Grades) : "None")}");
                //}
            }
        }
    }
}