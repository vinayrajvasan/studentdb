using System;
using System.Collections.Generic;
using System.Linq;


namespace StudentDetails
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            int choice = 99;
            while (choice != 0)
            {
                Console.WriteLine("\n\n-------STUDENT MANAGEMENT SYSTEM--------");
                Console.WriteLine("1-VIEW||2-VIEWALL||3-ADD||4-REMOVE||5-UPDATE||6-TOTAL||0-EXIT");
                Console.WriteLine("ENTER THE CHOICE");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        view();
                        break;
                    case 2:
                        viewAll();
                        break;
                    case 3:
                        add();
                        break;
                    case 4:
                        remove();
                        break;
                    case 5:
                        update();
                        break;
                    case 6:
                        total();
                        break;
                    default:
                        Console.WriteLine("PLEASE PROVIDE VALID CHOICE");
                        break;
                }
            }
        }

        static void view()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("NO RECORS FOUND");
            }
            else
            {
                Console.WriteLine("ENTER THE ID OF THE STUDENT");
                int studentId = Convert.ToInt32(Console.ReadLine());

                var selectedStudent = from student in students where student.id == studentId select student;
                if (selectedStudent.Count() == 0)
                {
                    Console.WriteLine("NO SUCH RECORD FOUND");
                }
                else
                {
                    foreach (Student student in selectedStudent)
                    {
                        Console.WriteLine("STUDENT ID:" + student.id + "  STUDENT NAME:" + student.name + "  STUDENT AGE:" + student.age + "  STUDENT PERCENTAGE:" + student.percentage);
                    }
                }
            }
        }

        static void viewAll()
        {
            if (students.Count != 0)
            {
                foreach (Student student in students)
                {
                    Console.WriteLine("STUDENT ID:" + student.id + "  STUDENT NAME:" + student.name + "  STUDENT AGE:" + student.age + "  STUDENT PERCENTAGE:" + student.percentage);
                }
            }
            else
            {
                Console.WriteLine("NO RECORDS FOUND");
            }
        }

        static void add()
        {
            int id;
            string name;
            int age;
            int percentage;

            Console.WriteLine("ENTER THE STUDENT ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE STUDENT NAME:");
            name = Console.ReadLine();
            Console.WriteLine("ENTER STUDENT AGE");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER STUDENT PERCENTAGE");
            percentage = Convert.ToInt32(Console.ReadLine());
            students.Add(new Student(id, name, age, percentage));
        }

        static void remove()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("NO RECORS FOUND");
            }
            else
            {
                Console.WriteLine("ENTER THE ID OF THE STUDENT");
                int sid = Convert.ToInt32(Console.ReadLine());

                Student student;
                bool studentDeleted = false;
                for (int i = 0; i < students.Count; i++)
                {
                    student = students[i];

                    if (student.id == sid)
                    {
                        students.Remove(student);
                        studentDeleted = true;
                        Console.WriteLine("DELETE SUCESSFUL");

                    }
                }
                if (!studentDeleted)
                {
                    Console.WriteLine("NO SUCH RECORD FOUND");
                }
            }
        }

        static void update()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("NO RECORS FOUND");
            }
            else
            {
                Console.WriteLine("ENTER THE ID OF THE STUDENT");
                int studentId = Convert.ToInt32(Console.ReadLine());

                var selectedStudent = from student in students where student.id == studentId select student;

                if (selectedStudent.Count() == 0)
                {
                    Console.WriteLine("NO SUCH RECORD FOUND");
                }
                else
                {
                    foreach (Student student in selectedStudent)
                    {
                        Console.WriteLine("ENTER THE STUDENT NAME");
                        string name = (Console.ReadLine());
                        Console.WriteLine("ENTER THE STUDENT AGE");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ENTER THE STUDENT PERCENTAGE");
                        int percentage = Convert.ToInt32(Console.ReadLine());

                        student.name = name;
                        student.age = age;
                        student.percentage = percentage;
                        Console.WriteLine("UPDATE SUCESSFULL");
                    }
                }
            }
        }

        static void total()
        {
            Console.WriteLine("TOTAL NUMBER OF RECORDS IS " + students.Count);
        }
    }
}

