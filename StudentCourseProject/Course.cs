namespace StudentCourseProject
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CategoryId { get; set; } 
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; } = false; 

        
        public ICollection<Student> Students { get; set; }
    }

}
