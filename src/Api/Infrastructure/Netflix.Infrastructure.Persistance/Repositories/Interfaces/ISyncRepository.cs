using Netflix.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Infrastructure.Persistance.Repositories.Interfaces
{
    public interface ISyncRepository<T> where T : BaseEntity
    {
    }
}
