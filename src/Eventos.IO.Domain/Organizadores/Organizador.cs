using System;
using Eventos.IO.Domain.Core.Models;

namespace Eventos.IO.Domain.Organzadores
{
    public class Organizador :Entity<Organizador>
    {
        public Organizador(Guid id)
        {
            Id = id;
        }
        public override bool EhValido()
        {
            throw new System.NotImplementedException();
        }
    }
}