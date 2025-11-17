namespace MyRecipeBook.Exeptions.ExceptionBase;

public class ErroOnValidadeException: MyRecipeBookException
{
    public IList<string> ErrorMessages { get; set; }
    public ErroOnValidadeException(IList<string> errorMessages)
    {
        ErrorMessages = errorMessages;
    }
}

