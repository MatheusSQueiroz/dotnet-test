using donet_test.Model;
using FluentValidation;

namespace donet_test.Validator
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty()
                .MaximumLength(255);
        }
    }
}
