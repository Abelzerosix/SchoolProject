namespace SchoolApp.Data.Models
{
    public class Class
    {
        public Class()
        {
            this.Id = Guid.NewGuid();
            this.Students = new HashSet<Students>();
        }

        public Guid Id { get; set; }

        public int ClassNum { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public ICollection<Students> Students { get; set; }
    }
}
