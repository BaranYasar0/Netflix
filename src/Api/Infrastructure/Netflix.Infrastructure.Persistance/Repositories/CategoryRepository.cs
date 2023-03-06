using Netflix.Api.Application.Services.Repositories;
using Netflix.Api.Domain.Entities;
using Netflix.Infrastructure.Persistance.Contexts;
using Netflix.Infrastructure.Persistance.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Infrastructure.Persistance.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
