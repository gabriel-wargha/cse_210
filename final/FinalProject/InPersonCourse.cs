public class InPersonCourse : Course {
    private string _roomNumber;

    private string _buildingName;
    public InPersonCourse(string name, string code, Professor p, string roomNumber, string buildingName) : base(name, code, p){
        _roomNumber = roomNumber;
        _buildingName = buildingName;
    }

    public override void DisplayInfo(Course c){
        Console.WriteLine($"Course {c.GetCourseName()}");
        Console.WriteLine($"Your class is in {_buildingName} room number {_roomNumber}");
    }

}