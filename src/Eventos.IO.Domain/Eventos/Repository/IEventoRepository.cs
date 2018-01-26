using System;
using System.Collections.Generic;
using Eventos.IO.Domain.Interfaces;

namespace Eventos.IO.Domain.Eventos.Repository
{
    public interface IEventoRepository : IRepository<Evento>
    {
        IEnumerable<Evento> ObterEventoPorOrganizador(Guid organizadorId);
        Endereco OBterEnderecoPorId(Guid Id);

        void AdicionarEnderecos(Endereco endereco);
        void AtualizarEndereco(Endereco enderco);
    }
}
