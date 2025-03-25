using System.Diagnostics.Tracing;

public class ProgrammingAssignment : Assignment {
    private string _language;
    private int _programmingLevel;

    public ProgrammingAssignment(string t, string d, DateOnly date, string language, int level) : base(t, d, date) {
        _language = language;
        _programmingLevel = level;
    }

    public override void Submit(Student student)
    {
        Console.WriteLine($"Congratulations you just did an amazing level {_programmingLevel }project in the language {_language}");
    }
}