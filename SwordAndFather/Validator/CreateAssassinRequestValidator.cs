using SwordAndFather.Controllers.Modals;

namespace SwordAndFather.Controllers
{
    //everything on a interface is always public
    public interface IValidator<TToValidate>
    {
        bool Validate(TToValidate objectToValidate);
    }

    public class CreateAssassinRequestValidator : IValidator<CreateAssassinRequest>
    {
        public bool Validate(CreateAssassinRequest request)
        {
            return string.IsNullOrEmpty(request.Catchphrase) 
                || string.IsNullOrEmpty(request.CodeName) 
                || string.IsNullOrEmpty(request.PrefferedWeapon);
        }
        
    }
}