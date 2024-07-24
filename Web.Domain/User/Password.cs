using System.Text.RegularExpressions;

namespace Web.Domain.User;

public partial record Password
{
    public string Value { get;}
    public Password(string value){
        Value = value;
    }
    
    [GeneratedRegex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$")]
    private static partial Regex PasswordRegex();

    public static Result<Password> CreatePassword(string value){
        if(string.IsNullOrEmpty(value.Trim())){
            return Result<Password>.Failure("Password can't be null or Empty");
        }
        if(!PasswordRegex().Match(value).Success){
            return Result<Password>.Failure("Password is not valid");
        }
        return Result<Password>.Success(new Password(value));
    }
}
