namespace E_learning_App.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? userName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public List<Course>? courses { get; set; }

    }
}
