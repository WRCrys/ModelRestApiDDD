namespace ModelRestApiDDD.Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }

        public decimal Value { get; set; }
    }
}