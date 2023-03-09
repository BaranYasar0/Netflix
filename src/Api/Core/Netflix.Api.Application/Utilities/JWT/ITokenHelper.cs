using Netflix.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Api.Application.Utilities.JWT
{
    public interface ITokenHelper
    {
       AccessToken CreateToken(User user,List<OperationClaim> operationClaims);
    }
}
