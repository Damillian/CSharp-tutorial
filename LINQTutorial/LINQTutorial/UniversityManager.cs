using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTutorial
{
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Harvard" });

            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "John", Gender = "male", Age = 19, UniversityId = 1 });
            students.Add(new Student { Id = 13, Name = "Leyla", Gender = "female", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 14, Name = "Linda", Gender = "female", Age = 21, UniversityId = 2 });
            students.Add(new Student { Id = 156, Name = "James", Gender = "male", Age = 24, UniversityId = 2 });
            students.Add(new Student { Id = 122, Name = "Larry", Gender = "male", Age = 17, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male - Students: ");
            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female - Students: ");
            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("Students sorted by age: ");

            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromHarvard()
        {
            IEnumerable<Student> hvStudents = from student in students
                                              join university in universities on student.UniversityId equals university.Id
                                              where university.Name == "Harvard"
                                              select student;
            Console.WriteLine("Students from Harvard: ");

            foreach (Student student in hvStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromUniversity(int id)
        {
            IEnumerable<Student> uniStudents = from student in students
                                              join university in universities on student.UniversityId equals university.Id
                                              where university.Id == id
                                              select student;
            Console.WriteLine("Students from University with ID {0}: ", id);

            foreach (Student student in uniStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("New Collections: ");

            foreach (var col in newCollection)
            {
                Console.WriteLine("Student {0} from University {1}", col.StudentName, col.UniversityName);
            }
        }
    }
}
