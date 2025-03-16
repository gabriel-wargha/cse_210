public class Eternal: Goal {
    public Eternal(int p, string t, string d): base(p, t, d){
    }

    public override string getType()
    {
        return "Eternal";
    }
    public override string Save(){
        return $"{base.Save()}|{_points}";
    }
    public override void Load(string data){
        base.Load(data);
        string[] parts = data.Split("|");

    }
    public override void Display(){
        Console.WriteLine(_title + " " + _description);   
    }
    public override void RecordEvent() {
        Console.WriteLine($"📌 Event recorded for '{_title}'. You earned {_points} points!");
    }   
    public override int CalculatePoints(){
        // calculate points
        return _points;
    }
}