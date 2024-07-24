using System.Text.RegularExpressions;

namespace Web.Domain.User;

public record Password
{
    public string Value { get;}
    public Password(string value){
        if(string.IsNullOrEmpty(value.Trim())){
            throw new ArgumentException("Password can't be null or Empty");
        }
        if(!PasswordRegex().Match(value).Success){
            throw new ArgumentException("Password is not valid");
        }
        Value = value;
    }
    
    [GeneratedRegex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$")]
    private static partial Regex PasswordRegex();
}
