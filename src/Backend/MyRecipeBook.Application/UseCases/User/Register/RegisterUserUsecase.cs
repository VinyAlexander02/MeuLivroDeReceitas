using MyRecipeBook.Communication.Request;
using MyRecipeBook.Communication.Response;
using MyRecipeBook.Exeptions.ExceptionBase;
namespace MyRecipeBook.Application.UseCases.User.Register;


public class RegisterUserUsecase
{
    public ResponseRegisterUserJson Execute(RequestRegisterUserJson request)
    {
        // Validar a Request 
        Validate(request);

        // Mapear a request em um entidade

        // Cripitografia da senha

        //Salvar no banco de dados
        return new ResponseRegisterUserJson
        {
            Name = request.Name
        };
    }

    private void Validate(RequestRegisterUserJson request)
    {
        var validator = new RegisterUserValidator();

        var result = validator.Validate(request);

        if (result.IsValid == false)
        {
            var errorMessages = result.Errors.Select(e => e.ErrorMessage).ToList();
            throw new MyRecipeBookException(errorMessages);
        }
    }
}

