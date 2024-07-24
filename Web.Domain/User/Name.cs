namespace Web.Domain.User;

public record Name
{
    public string Value { get;}
    public Name(string value){
        if(string.IsNullOrEmpty(value.Trim())){
            throw new ArgumentException("Name can't be null or Empty");
        }
        if(Value?.Length < 4){
            throw new ArgumentException("Name can't be less than 4 characters");
        }
        Value = value;
    }
}
