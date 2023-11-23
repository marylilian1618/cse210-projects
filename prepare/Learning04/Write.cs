class Write : Assignment{
    private string _title;
    //Constructor with the base of the assignment's constructor
    public Write (string studentName, string topic, string title ): base(studentName, topic)
    {
        _title = title;

    }
    //get for the privates strings
    public string GetTitle(){
        return _title;
    }
    
    public string GetWritingInformation(){
        return _title + " " +"by"+ " "+ GetStudentName();

    }

}