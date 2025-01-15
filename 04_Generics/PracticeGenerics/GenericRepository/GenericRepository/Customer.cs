namespace GenericRepositoryApp
{
    public class Customer : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"Customer [Id={Id}, Name={FirstName} {LastName}]";
        }
    }
}