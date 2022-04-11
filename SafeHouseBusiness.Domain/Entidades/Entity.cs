using System;

namespace SafeHouseBusiness.Domain.Entidades
{
    public class Entity
    {
        public int Id { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}