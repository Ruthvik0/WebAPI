using System.Text.RegularExpressions;

namespace Web.Domain.User;

public partial record Email
{
    public string Value { get;}
    public Email(string value){
        if(string.IsNullOrEmpty(value.Trim())){
            throw new ArgumentException("Email can't be null or Empty");
        }
        if(!EmailRegex().Match(value).Success){
            throw new ArgumentException("Email is not valid");
        }
        Value = value;
    }

    [GeneratedRegex(@"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$")]
    private static partial Regex EmailRegex();
}
