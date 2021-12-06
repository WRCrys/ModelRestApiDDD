namespace ModelRestApiDDD.Domain.Entities
{
    public class Client : Entity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
    }
}