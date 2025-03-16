public class CheckList : Goal {

    private int _currentCount;
    private int _targetCount;
    private int _bonus;
    public CheckList(int p, string t, string d, int c, int target, int b): base(p, t, d){
        _currentCount = c;
        _targetCount = target;
        _bonus = b;
    }

     public override string getType()
    {
        return "Checklist";
    }
    public override string Save(){
        return $"{base.Save()}|{_currentCount}|{_targetCount}|{_points}|When you finish you are going to receive {_bonus}";
    }
    public override void Load(string data){
          base.Load(data);
         string[] parts = data.Split("|");
        _currentCount = int.Parse(parts[4]);
        _targetCount = int.Parse(parts[5]); 
        _bonus = int.Parse(parts[6]);
    }
    public override void Display(){
        Console.WriteLine($"{_title} {_description} {_currentCount}/{_targetCount} {_bonus}");
    }

     public override void RecordEvent() {
        if (_currentCount < _targetCount) {
            _currentCount++;
            Console.WriteLine($"✅ Progress on '{_title}': {_currentCount}/{_targetCount} completed.");

            if (_currentCount == _targetCount) {
                Console.WriteLine($"🎉 Checklist complete! You earned {_points} points + {_bonus} bonus points!");
            }
        } else {
            Console.WriteLine("⚠️ This checklist goal is already completed!");
        }
    }
public override int CalculatePoints(){
    if (_currentCount == _targetCount){
        return _points + _bonus;  
    } else {
        return _points; 
    }
}
}