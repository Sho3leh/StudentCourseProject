namespace StudentCourseProject
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public DateTime DOB { get; set; }
        public int EducationalLevelId { get; set; } 
        public int CityId { get; set; } 
        public bool IsDeleted { get; set; } = false; 
    }

}
