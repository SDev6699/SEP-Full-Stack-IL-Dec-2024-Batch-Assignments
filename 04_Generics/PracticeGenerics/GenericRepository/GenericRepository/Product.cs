namespace GenericRepositoryApp
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Product [Id={Id}, Name={Name}, Price={Price:C}]";
        }
    }
}