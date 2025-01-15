namespace PersonInstructorStudent
{
    public interface IInstructorService : IPersonService
    {
        void AssignDepartment(string department);
        void CalculateBonus();
    }
}