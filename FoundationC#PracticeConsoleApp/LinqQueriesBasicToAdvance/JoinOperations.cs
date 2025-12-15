using System;
using System.Collections.Generic;
using System.Linq;

namespace FoundationC_PracticeConsoleApp.LinqQueriesBasicToAdvance
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
    }
    public class JoinOperations
    {
        public void JoinExample()
        {
            List<Student> students = new List<Student>()
            {
                new Student() {Id = 1, Name = "anish", DepartmentId = 1 },
                new Student() {Id = 2, Name = "divesh", DepartmentId = 2 },
                new Student() {Id = 3, Name = "brijesh", DepartmentId = 3 },
                new Student() {Id = 4, Name = "somesh", DepartmentId = 4 }, // Unmatched DepartmentId
                new Student() {Id = 5, Name = "rakesh", DepartmentId = 2 }
            };
             
            List<Department> departments = new List<Department>()
            {
                new Department() {Id = 1, DepartmentName = "ML"},
                new Department() {Id = 2, DepartmentName = "AI"},
                new Department() {Id = 3, DepartmentName = "Neural Networks"},
                new Department() {Id = 5, DepartmentName = "Robotics"} // Unmatched Department ID
            };

            Console.WriteLine("--- 1. INNER JOIN (MATCHED ONLY) ---");
            InnerJoin(students, departments);
            Console.WriteLine("\n--- 2. LEFT OUTER JOIN (ALL STUDENTS) ---");
            LeftOuterJoin(students, departments);
            Console.WriteLine("\n--- 3. CROSS JOIN (EVERY COMBINATION) ---");
            CrossJoin(students, departments);
        }

        // returns only the students who have a matching DepartmentId
        public void InnerJoin(List<Student> students, List<Department> departments)
        {
            // 

            // A. Method Syntax
            var innerJoinMethod = students.Join(
                departments,
                s => s.DepartmentId,    // Key from Student list s.DepartmentId
                d => d.Id,              // Key from Department list d.Id
                (s, d) => new
                {
                    StudentName = s.Name,
                    Department = d.DepartmentName
                }
            ).ToList();

            Console.WriteLine("  [Method Syntax] Output:");
            foreach (var item in innerJoinMethod)
            {
                Console.WriteLine($"  -> {item.StudentName} - {item.Department}");
            }

            // B. Query Syntax
            var innerJoinQuery = from s in students
                                 join d in departments on s.DepartmentId equals d.Id // on clause specifies the match
                                 select new
                                 {
                                     StudentName = s.Name,
                                     Department = d.DepartmentName
                                 };

            Console.WriteLine("  [Query Syntax] Output:");
            foreach (var item in innerJoinQuery)
            {
                Console.WriteLine($"  -> {item.StudentName} - {item.Department}");
            }
            
        }

        // returns ALL students, even if they don't have a matching department.
        public void LeftOuterJoin(List<Student> students, List<Department> departments)
        {

            // A. Method Syntax (Requires GroupJoin, SelectMany, DefaultIfEmpty)
            var leftOuterJoinMethod = students.GroupJoin(
                departments,
                s => s.DepartmentId,
                d => d.Id,
                (s, matchedDepts) => new { Student = s, MatchedDepts = matchedDepts } // Group the data
            )
            .SelectMany(
                temp => temp.MatchedDepts.DefaultIfEmpty(), // Flatten the groups, insert null for unmatched
                (temp, dept) => new // Step 3: Project the final result
                {
                    StudentName = temp.Student.Name,
                    Department = dept == null ? "Unassigned" : dept.DepartmentName // Check for null the Unassigned case
                }
            ).ToList();

            Console.WriteLine("  [Method Syntax] Output:");
            foreach (var item in leftOuterJoinMethod)
            {
                Console.WriteLine($"  -> {item.StudentName} - {item.Department}");
            }

            var leftOuterJoinQuery = from s in students
                                     join d in departments on s.DepartmentId equals d.Id into deptGroup // The into performs the GroupJoin
                                     from dept in deptGroup.DefaultIfEmpty()                            // Flatten and handle null
                                     select new
                                     {
                                         StudentName = s.Name,
                                         Department = dept == null ? "Unassigned" : dept.DepartmentName
                                     };

            Console.WriteLine("  [Query Syntax] Output:");
            foreach (var item in leftOuterJoinQuery)
            {
                Console.WriteLine($"  -> {item.StudentName} - {item.Department}");
            }
           
        }

        // returns every possible combination (Cartesian Product) of students and departments.
        public void CrossJoin(List<Student> students, List<Department> departments)
        {
            // 

            var crossJoinMethod = students.SelectMany(
                d => departments, // Inner sequence
                (s, d) => new // Result selector
                {
                    StudentName = s.Name,
                    Department = d.DepartmentName
                }
            ).ToList();

            Console.WriteLine("  [Method Syntax] Output (First 5 of 20 results):");
            foreach (var item in crossJoinMethod.Take(5)) // Showing only the first few results
            {
                Console.WriteLine($"  -> {item.StudentName} - {item.Department}");
            }


            var crossJoinQuery = from s in students
                                 from d in departments // A second 'from' with no join condition
                                 select new
                                 {
                                     StudentName = s.Name,
                                     Department = d.DepartmentName
                                 };

            Console.WriteLine("  [Query Syntax] Output (First 5 of 20 results):");
            foreach (var item in crossJoinQuery.Take(5)) // Showing only the first few results
            {
                Console.WriteLine($"  -> {item.StudentName} - {item.Department}");
            }
        }

    }
}