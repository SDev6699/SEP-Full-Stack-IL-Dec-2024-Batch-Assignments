namespace PersonInstructorStudent
{
    public interface IPersonService
    {
        void CalculateAge();
        decimal CalculateSalary();
        void AddAddress(string address);
        void GetAddresses();
    }
}