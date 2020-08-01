using Common.Entities;
using Common.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DataAccess.EntityFramework.Repositories
{
    public class PersonaRepository: BaseRepository<Persona, DataContext>, IPersonaRepository
    {
    }
}
