namespace Web.Domain.User;
public class User
{
    public Guid Id { get; private set; }
    public Name Name { get; private set; }
    public Email Email { get; private set; }
    public Password Password { get; private set; }

    public User(Name name, Email email, Password password) 
    {
        Name = name;
        Email = email;
        Password = password;
    }
}
