
/// <summary>
/// The reference class will have the ability to get the display text
/// of the reference.
/// </summary>
class Reference{
    // variables and attributes
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int  _endVerse;
    // Constructors
    public Reference(string book, int chapter, int verse)
{
    _book = book;
    _chapter = chapter;
    _startVerse = verse;

}
    public Reference(string book, int chapter, int startVerse, int endVerse){
    _book = book;
    _chapter = chapter;
    _startVerse = startVerse;
    _endVerse = endVerse;
    }
    // get 
    public string GetBook(){
        return _book;
    }
    public int GetChapter(){
        return _chapter;
    }

public int GetStartVerse(){
    return _startVerse;
}
public int GetEndVerse(){
    return _endVerse;
}
    // methods
    public string GetDisplayText(){
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";

    }
}