using FluentValidation;
using MyRecipeBook.Communication.Request;
using MyRecipeBook.Exeptions;

namespace MyRecipeBook.Application.UseCases.User.Register;

public class RegisterUserValidator: AbstractValidator<RequestRegisterUserJson>
{
    public RegisterUserValidator()
    {
        RuleFor(user => user.Name).NotEmpty().WithMessage(ResourceMessagesExeptions.NAME_EMPY);
        RuleFor(user => user.Email).NotEmpty().WithMessage(ResourceMessagesExeptions.EMAIL_EMPTY);
        RuleFor(user => user.Email).NotEmpty().EmailAddress().WithMessage(ResourceMessagesExeptions.EMAIL_INVALID);
        RuleFor(user => user.Password).NotEmpty().MinimumLength(6).WithMessage(ResourceMessagesExeptions.PASSWORD_EMPTY);
    }
}

