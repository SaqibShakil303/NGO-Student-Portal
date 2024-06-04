namespace Student_Managment_Portal.Models
{
    public class AddStudentViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CourseName { get; set; }
        public string BatchCoordinator { get; set; }
    }
}
