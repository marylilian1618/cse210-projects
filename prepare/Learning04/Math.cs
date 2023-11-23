class Math : Assignment{
    private string _textbookSection;
    private string _problem;
    //Constructor with the base of the assignment's constructor
    public Math (string studentName, string topic, string textbookSection, string problem ): base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problem = problem;

    }
    //get for the privates strings
    public string GetTextBook(){
        return _textbookSection;
    }
    public string GetProblem(){
        return _problem;
    }
    public string GetHomeworkList(){
        return "Section" + " " +_textbookSection + " " + "Problems"+ " " +  _problem ;

    }

}