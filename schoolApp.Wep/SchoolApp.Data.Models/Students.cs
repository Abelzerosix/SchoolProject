namespace SchoolApp.Data.Models
{
    public class Students
    {
        public Students()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string SecondName { get; set; } = null!;

        public DateTime BirthDate { get; set; }

        public int EGN { get; set; } = 0!;

        public int PhoneNumder { get; set; }

        //
        public Guid StudentId { get; set; }
        public Class Student { get; set; }
    }
}
