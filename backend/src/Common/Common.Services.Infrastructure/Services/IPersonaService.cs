using Common.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.Services.Infrastructure
{
    public interface IPersonaService
    {
        Task<PersonaDTO> GetById(int id, bool includeDeleted = false);
        Task<bool> Delete(int id);
        Task<PersonaDTO> Edit(PersonaDTO dto);
        Task<PersonaDTO> Create(PersonaDTO dto);
        Task<IEnumerable<PersonaDTO>> GetList();
    }
}
