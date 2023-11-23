class Assignment{
    //Variables
    private string _studentName;
    private string _topic;
    
    //Constructor
    public Assignment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;

    }
    //Get which will obtain the data form private
    public string GetStudentName(){
        return _studentName;
    }
    public string GetTopic(){
        return _topic;
    }
    public string GetSummary(){
        return _studentName +" "+"-"+ " "+ _topic;

    }
}