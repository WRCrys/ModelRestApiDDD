using System;

namespace ModelRestApiDDD.Domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public DateTime DateCreate { get; set; }

        public bool Active { get; set; }
    }
}