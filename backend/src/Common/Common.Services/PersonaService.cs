using Common.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Common.Entities;
using Common.Services.Infrastructure;
using Common.Utils;

namespace Common.Services
{
    public class PersonaService : BaseService, IPersonaService
    {
        protected readonly IPersonaRepository PersonaRepository;

        public PersonaService(ICurrentContextProvider contextProvider, IPersonaRepository PersonaRepository) : base(contextProvider)
        {
            this.PersonaRepository = PersonaRepository;
        }

        public async Task<PersonaDTO> Create(PersonaDTO dto)
        {
            var Persona = dto.MapTo<Persona>();
            await PersonaRepository.Create(Persona, Session);
            return Persona.MapTo<PersonaDTO>();
        }

        public async Task<bool> Delete(int id)
        {
            await PersonaRepository.Delete(id, Session);
            return true;
        }

        public async Task<PersonaDTO> Edit(PersonaDTO dto)
        {
            var Persona = dto.MapTo<Persona>();
            await PersonaRepository.Edit(Persona, Session);
            return Persona.MapTo<PersonaDTO>();
        }


        public async Task<PersonaDTO> GetById(int id, bool includeDeleted = false)
        {
            var Persona = await PersonaRepository.Get(id, Session);
            return Persona.MapTo<PersonaDTO>();
        }

        public async Task<IEnumerable<PersonaDTO>> GetList()
        {
            var Personas = await PersonaRepository.GetList(Session);
            return Personas.MapTo<IEnumerable<PersonaDTO>>();
        }
    }
}
