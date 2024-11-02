namespace StudentCourseProject
{
    public class Teacher
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        public int MajorId { get; set; } 
        public decimal PricePerHour { get; set; }
        public bool IsDeleted { get; set; } = false; 

        
        public ICollection<Course> Courses { get; set; }
    }

}
