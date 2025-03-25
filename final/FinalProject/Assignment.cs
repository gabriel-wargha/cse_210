public class Assignment {
    private string _title;
    private string _description;

    private DateTime _dueDate;

    public Assignment(string t, string d, DateTime date){
        _title = t;

        _description = d;

        _dueDate = date;
    }

    public void Submit(Student student){
        Console.WriteLine($"{student.GetName()} submitted {_title}");
    }

    public string GetTitle(){
        return _title;
    }

    public string GetDescription(){
        return _description;
    }

    public DateTime GetDueDate(){
        return _dueDate;
    }

}