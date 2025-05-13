using CarBook.Application.Features.Mediator.Commands.CarReviewCommands;
using CarBook.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Validators.ReviewValidators
{
    public class CreateReviewValidator : AbstractValidator<CreateCarReviewCommand>
    {
        public CreateReviewValidator() 
        {
            RuleFor(x => x.CarReviewName)
                .NotEmpty().WithMessage("Car review name is required.")
                .Length(2, 50).WithMessage("Car review name must be between 2 and 50 characters.");
            RuleFor(x => x.CarReviewDate)
                .NotEmpty().WithMessage("Car review date is required.")
                .LessThan(DateTime.Now).WithMessage("Car review date cannot be in the future.");
            RuleFor(x => x.CarReviewContent)
                .NotEmpty().WithMessage("Car review content is required.")
                .Length(10, 500).WithMessage("Car review content must be between 10 and 500 characters.");
            RuleFor(x => x.CarReviewRating)
                .InclusiveBetween(1, 5).WithMessage("Car review rating must be between 1 and 5.");
            RuleFor(x => x.CarReviewCarId)
                .NotEmpty().WithMessage("Car ID is required.");

            RuleFor(x => x.CarReviewContent).NotEmpty()
                .WithMessage("Car review content is required.")
                .Length(10, 500)
                .WithMessage("Car review content must be between 10 and 500 characters.");

            RuleFor(x => x.CarReviewRating).InclusiveBetween(1, 5).NotEmpty()
                .WithMessage("Car review rating must be between 1 and 5.")
                .WithMessage("Car review rating is required.");
        }
    }
}
