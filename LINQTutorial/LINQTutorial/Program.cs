using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*UniversityManager um = new UniversityManager();

            um.MaleStudents();
            um.FemaleStudents();

            um.SortStudentsByAge();

            um.AllStudentsFromHarvard();

            um.AllStudentsFromUniversity(1);

            um.StudentAndUniversityNameCollection();

            Console.ReadKey();*/


            string studentsXML =
                @"<Students>
                    <Student>
                        <Name>Toni</Name>
                        <Age>21</Age>
                        <University>Yale</University>
                        <Class>2B</Class>
                    </Student>
                    <Student>
                        <Name>Carla</Name>
                        <Age>17</Age>
                        <University>Yale</University>
                        <Class>1A</Class>
                    </Student>
                    <Student>
                        <Name>Leyla</Name>
                        <Age>19</Age>
                        <University>Harvard</University>
                        <Class>3A</Class>
                    </Student>
                    <Student>
                        <Name>Bobby</Name>
                        <Age>18</Age>
                        <University>Harvard</University>
                        <Class>2C</Class>
                    </Student>
                    
                </Students>";

            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Class = student.Element("Class").Value
                           };

            foreach (var student in students)
            {
                Console.WriteLine("Student {0} with age {1} from University {2} Class {3}", student.Name, student.Age, student.University, student.Class);
            }

            Console.ReadKey();
            
        }
    }
}
