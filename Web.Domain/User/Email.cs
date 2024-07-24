using System.Text.RegularExpressions;

namespace Web.Domain.User;

public partial record Email
{
    public string Value { get;}
    public Email(string value){
        Value = value;
    }

    [GeneratedRegex(@"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$")]
    private static partial Regex EmailRegex();

    public static Result<Email> CreateEmail(string value){
        if(string.IsNullOrEmpty(value.Trim())){
            return Result<Email>.Failure("Email can't be null or Empty");
        }
        if(!EmailRegex().Match(value).Success){
            return Result<Email>.Failure("Email is not valid");
        }
        return Result<Email>.Success(new Email(value));
    }
}
