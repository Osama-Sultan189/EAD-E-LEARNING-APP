namespace E_learning_App.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? userName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public List<Course>? courses { get; set; }

    }
}
