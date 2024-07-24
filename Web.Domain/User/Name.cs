namespace Web.Domain.User;

public record Name
{
    public string Value { get;}
    private Name(string value){
        Value = value;
    }

    public static Result<Name> CreateName(string value){
        if(string.IsNullOrEmpty(value.Trim())){
            return Result<Name>.Failure("Name can't be null or Empty");
        }
        if(value?.Length < 4){
            return Result<Name>.Failure("Name can't be less than 4 characters");
        }
        return Result<Name>.Success(new Name(value));
    }
}
