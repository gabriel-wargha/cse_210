class Assignment {
    private string _studentName;
    private string _topic;


    // Methods 

    public Assignment (string studentName, string topic) {
        _studentName = studentName;
        _topic = topic;
    }

    public string getSummary() {
       
        return $"{_studentName} ${_topic}";
    }

     public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }




}