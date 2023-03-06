using FluentValidation;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Api.Application.Pipelines
{
    public class ValidationPipelineBehaviour<TRequest,TResponse>:IPipelineBehavior<TRequest,TResponse> 
        where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationPipelineBehaviour(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            ValidationContext<object> context = new(request);
            List<ValidationFailure> validationFailures = _validators.Select(validator => validator.Validate(context))
                .SelectMany(x => x.Errors)
                .Where(failures => failures is not null)
                .ToList();

            if (validationFailures.Any()) throw new ValidationException(validationFailures);

            return await next();
        }
    }
}
