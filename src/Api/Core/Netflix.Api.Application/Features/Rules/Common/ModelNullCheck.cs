using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Api.Application.Features.Rules.Common
{
    public class ModelNullCheck
    {
    public static async Task<bool> IsModelNullOrNot(params object[] models)
        {
            foreach (var model in models)
            {
                if (model==null)
                    throw new ArgumentNullException(nameof(model));
            }
             return true;
        }
    }
}
