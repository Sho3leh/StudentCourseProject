namespace StudentCourseProject
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CategoryId { get; set; } // البرمجة أو غيرها
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; } = false; // للحذف اللوجيكي

        // علاقة Many-to-Many مع Student
        public ICollection<Student> Students { get; set; }
    }

}
