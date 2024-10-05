namespace SchoolApp.Data.Models
{
    public class Student
    {
        public Student()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int Grade { get; set; }

        public int ClassId { get; set; }

        public int Clasnumber { get; set; }


        public Class Class { get; set; }
    }
}
