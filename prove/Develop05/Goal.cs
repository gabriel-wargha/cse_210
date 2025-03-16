public class Goal {
    protected int _points;
     protected string _title;
    protected string _description;
    protected string _type;

    public virtual string getType(){
        return _type;
    }

    public string GetTitle(){
        return _title;
    }



    public Goal(int p, string t, string d){
        _points = p;
        _title = t;
        _description = d;
    }

   virtual public bool IsDone(){
        return false;
    }

    virtual public void RecordEvent(){
        // record event
    }

    virtual public string Save(){
        return $"{getType()}|{ _points}|{ _title}|{ _description}";
    }

    virtual public void Load(string data){
        string[]parts = data.Split("|");
        _points = int.Parse(parts[1]);
        _title = parts[2];
        _description = parts[3];


    }

    virtual public void Display(){
    }

    virtual public int CalculatePoints(){
        return 0;
    }




}