using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationC_PracticeConsoleApp.LinqQueriesBasicToAdvance
{
    public class JoinOperations
    {
        public void JoinExample()
        {
            List<Student> students = new List<Student>()
            {
                new Student() {Id = 1, Name = "anish", DepartmentId = 1 },
                new Student() {Id = 2, Name = "divesh", DepartmentId = 2 },
                new Student() {Id = 3, Name = "brijesh", DepartmentId = 3 },
                new Student() {Id = 4, Name = "somesh", DepartmentId = 4 },
            };

            List<Department> departments = new List<Department>()
            {
                new Department() {Id = 1, DepartmentName = "ML"},
               new Department() {Id = 2, DepartmentName = "AI"},
               new Department() {Id = 3, DepartmentName = "Nural Networks"}
            };

            var result = students.Join(
                departments,   // inner sequence
                s => s.Id,     // outer key selector
                d => d.Id,     // inner key selector
                (s, d) => new
                {
                    StudentName = s.Name,
                    Department = d.DepartmentName
                }
             ).ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.StudentName} - {item.Department}");
            }

        }

        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int DepartmentId { get; set; }
        }

        class Department
        {
            public int Id { get; set; }
            public string DepartmentName { get; set; }
        }
    }
}
