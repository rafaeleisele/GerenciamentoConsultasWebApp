﻿namespace SafeHouseBusiness.Domain.Entidades
{
    public class Contato : Entity
    {
        public string Telefone { get; set; }
        public string Email { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual LocalConsulta LocalConsulta { get; set; }
    }
}

