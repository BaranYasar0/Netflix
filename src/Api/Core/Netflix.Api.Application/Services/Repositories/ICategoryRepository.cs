using Netflix.Api.Application.Services.Repositories.Interfaces;
using Netflix.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Api.Application.Services.Repositories
{
    public interface ICategoryRepository:IRepository<Category>
    {
    }
}
