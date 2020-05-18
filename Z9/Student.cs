using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Z9
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName => Name + LastName;
        public DateTime Enlisting { get; set; }

        public override string ToString()
        {
            return FullName;
        }

    }

    public class StudentView
    {
        public StudentList List { get; set; }
        public StudentView()
        {
            List = new StudentList()
            {
                Students = new ObservableCollection<Student>()
                {
                    new Student
                    {
                        Id = 1,
                        Name = "Jan",
                        LastName = "Kowalski",
                        Enlisting = new DateTime(2000, 1, 2)
                    },
                    new Student
                    {
                        Id = 1,
                        Name = "Zenon",
                        LastName = "Wiertara",
                        Enlisting = new DateTime(2001, 2, 3)
                    },
                    new Student
                    {
                        Id = 1,
                        Name = "Grzegorz",
                        LastName = "Brzęczyszczykiewicz",
                        Enlisting = new DateTime(2002, 3, 4)
                    }
                }
            };
        }
    }
    public class StudentList
    {

        public ObservableCollection<Student> Students { get; set; } = new ObservableCollection<Student>();
    }
}
