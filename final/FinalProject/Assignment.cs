public class Assignment {
    private string _title;
    private string _description;

    private DateOnly _dueDate;

    public Assignment(string t, string d, DateOnly date){
        _title = t;

        _description = d;

        _dueDate = date;
    }

    public virtual void Submit(Student student){
        Console.WriteLine($"{student.GetName()} submitted {_title}");
    }

    public string GetTitle(){
        return _title;
    }

    public string GetDescription(){
        return _description;
    }

    public DateOnly GetDueDate(){
        return _dueDate;
    }

}