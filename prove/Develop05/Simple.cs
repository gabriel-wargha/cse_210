using System.Security.Cryptography.X509Certificates;

public class Simple: Goal {

    private bool _done;
    public Simple(int p, string t, string d): base(p, t, d){
        _done = false;
    }

     public override string getType()
    {
        return "Simple";
    }
    public override string Save(){
        return $"{base.Save()}|{_done}|{_points}";
    }
    public override void Load(string data){
        base.Load(data);
        string[] parts = data.Split("|");
        _done = bool.Parse(parts[4]);
    }

    public override void Display(){
        String Status = _done ? "Done! [X]" : "Incomplete [ ]";
        Console.WriteLine(Status + " " + _title + " " + _description);
    }
    public override bool IsDone(){
        return _done;
    }
    public override void RecordEvent(){
         if (!_done) {
        _done = true;  // Mark the goal as done
        Console.WriteLine("Goal completed!");
        int pointsAwarded = CalculatePoints();  // Calculate points based on completion
        Console.WriteLine($"You earned {pointsAwarded} points!");
    }
    else {
        Console.WriteLine("Goal already done!");
    }
        
    }
    public override int CalculatePoints(){
        Console.WriteLine($"{_points}");
        return _done ? _points : 0;
        // calculate points
    }
}