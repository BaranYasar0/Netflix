using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using Netflix.Api.Application.Exceptions;
using Netflix.Api.Application.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Api.Application.Pipelines
{
    public class AuthorizationPipelineBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>,IClaimRole
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;

        public AuthorizationPipelineBehaviour(string roles, IHttpContextAccessor httpContextAccessor)
        {
            _roles = roles.Split(',');
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            List<string>? roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();

            if (roleClaims == null)
                throw new AuthorizationException("Claims not found.");

            bool isNotMatchedARoleClaimWithRequestRoles = roleClaims
            .FirstOrDefault(roleClaim => request.Roles.Any(role => role == roleClaim))
            .IsNullOrEmpty();
            if (isNotMatchedARoleClaimWithRequestRoles)
                throw new AuthorizationException("You are not authorized.");

            
            
            return await next();
        }
        }
}
