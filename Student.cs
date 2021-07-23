namespace StudentDetails
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int percentage { get; set; }

        public Student(int id, string name, int age, int percentage)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.percentage = percentage;
        }
    }
}