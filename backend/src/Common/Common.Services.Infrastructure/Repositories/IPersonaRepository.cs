using Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.Services.Infrastructure
{
    public interface IPersonaRepository
    {
        Task Delete(int id, ContextSession session);
        Task<IEnumerable<Persona>> GetList(ContextSession session);
        Task<Persona> Get(int id, ContextSession session);
        Task<Persona> Edit(Persona user, ContextSession session);
        Task<Persona> Create(Persona obj, ContextSession session);
    }
}
