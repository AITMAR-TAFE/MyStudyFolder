using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UIExercise
{
    class DataService
    {
       private List<Student> students = new List<Student>();
        private const string filename = "student_data.json";

        public DataService()
        {
            /*            students.Add(new Student(1, "Bob", "Ross", EnrolmentStatus.Enrolled));
                        students.Add(new Student(2, "James", "Ross", EnrolmentStatus.Enrolled));
                        students.Add(new Student(3, "Mary", "Sue", EnrolmentStatus.Withdrawn));
                        students.Add(new Student(4, "Peter", "Smith", EnrolmentStatus.Enrolled));
                        students.Add(new Student(5, "Jane", "Doe", EnrolmentStatus.Paid));*/
            if (System.IO.File.Exists(filename))
            {
                string data = System.IO.File.ReadAllText(filename);
                students = JsonConvert.DeserializeObject<List<Student>>(data);
            }
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public void StoreData() {
            string datastr=JsonConvert.SerializeObject(students);
            //string data = System.IO.File.ReadAllText("student_data.json");
            System.IO.File.WriteAllText(filename,datastr);
        }
    }
}
