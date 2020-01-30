using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LinqToSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        LinqToSqlDataClassesDataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSQL.Properties.Settings.CSharpTutorialConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            //InsertStudents();
            //InsertStudentLectureAssociations();
            //GetStudentsWithMath();
            //UpdateJohn();
            DeleteMark();
        }

        public void InsertUniversities()
        {
            University harvard = new University();
            harvard.Name = "Harvard";
            dataContext.Universities.InsertOnSubmit(harvard);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudents()
        {
            Student newStudent = new Student();
            newStudent.Name = "Mark";
            newStudent.Gender = "Male";
            newStudent.UniversityId = 1;
            dataContext.Students.InsertOnSubmit(newStudent);

            /*Student newStudent2 = new Student();
            newStudent2.Name = "Eveline";
            newStudent2.Gender = "Female";
            newStudent2.UniversityId = 2;
            dataContext.Students.InsertOnSubmit(newStudent2);*/

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lectures;
        }

        public void InsertStudentLectureAssociations()
        {
            Student john = dataContext.Students.First(st => st.Name.Equals("John"));
            Student eveline = dataContext.Students.First(st => st.Name.Equals("Eveline"));
            Student mark = dataContext.Students.First(st => st.Name.Equals("Mark"));

            Lecture math = dataContext.Lectures.First(lect => lect.Name.Equals("Math"));
            Lecture history = dataContext.Lectures.First(lect => lect.Name.Equals("History"));

            /*dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = john, Lecture = math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = john, Lecture = history });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = eveline, Lecture = math });*/
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = mark, Lecture = history });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }

        public void GetUniversityOfToni()
        {
            Student John = dataContext.Students.First(st => st.Name.Equals("John"));

            University JohnsUniversity = John.University;

            List<University> universities = new List<University>();
            universities.Add(JohnsUniversity);

            MainDataGrid.ItemsSource = universities;
        }

        public void GetStudentsWithMath()
        {
            var mathStudents = from studentLecture in dataContext.StudentLectures
                               join student in dataContext.Students
                               on studentLecture.StudentId equals student.Id
                               join lecture in dataContext.Lectures
                               on studentLecture.LectureId equals lecture.Id
                               where lecture.Name == "Math"
                               select student;

            MainDataGrid.ItemsSource = mathStudents;

        }

        public void UpdateJohn()
        {
            Student John = dataContext.Students.First(st => st.Name.Equals("John"));
            John.Name = "Jerry";

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void DeleteMark()
        {
            Student Mark = dataContext.Students.First(st => st.Name.Equals("Mark"));
            dataContext.Students.DeleteOnSubmit(Mark);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }
    }
}
