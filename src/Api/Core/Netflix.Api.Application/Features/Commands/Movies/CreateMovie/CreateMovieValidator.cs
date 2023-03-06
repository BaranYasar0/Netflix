using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Api.Application.Features.Commands.Movies.CreateMovie
{
    public class CreateMovieValidator:AbstractValidator<CreateMovieCommand>
    {
        public CreateMovieValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("İsim boş kalamaz")
                .MinimumLength(3).WithMessage("Minimum 3 karakter olmalı")
                .MaximumLength(25).WithMessage("Max 25 karakter olmalı");
                
            RuleFor(x=>x.Description)
                .MaximumLength(150).WithMessage("Max 150 karakter olmalı");

            RuleFor(x => x.Duration)
                .NotEmpty().WithMessage("Film Süresi boş kalamaz");

        }
    }
}
