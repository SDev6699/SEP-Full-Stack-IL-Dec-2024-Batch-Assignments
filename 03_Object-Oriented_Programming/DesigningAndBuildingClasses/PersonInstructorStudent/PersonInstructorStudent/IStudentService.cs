namespace PersonInstructorStudent
{
    public interface IStudentService : IPersonService
    {
        void EnrollCourse(string course);
        double CalculateGPA();
    }
}