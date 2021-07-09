using Brasileirao.Api.Client.Requests;
using FluentValidation;

namespace WebAPI.Controllers.Users
{
    public class UserValidation : AbstractValidator<CreateUserRequest>
    {
        public UserValidation()
        {
            RuleFor(x => x.Name)
                .MinimumLength(5)
                .MaximumLength(80)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.Password)
                .MinimumLength(5)
                .MaximumLength(30)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .Matches(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
        }
    }
}