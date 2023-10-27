using donet_test.Model;
using FluentValidation;

namespace donet_test.Validator
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty()
                .MaximumLength(255);
        }
    }
}
