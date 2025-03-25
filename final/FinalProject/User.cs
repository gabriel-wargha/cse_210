public class User {

    protected string _name;
    protected string _email;

    public User(string n, string e ){
        _name = n;
        _email = e;
    }

    public void DisplayInfo(){
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Email: " + _email);
    }

    public string GetName(){
        return _name;
    }

}