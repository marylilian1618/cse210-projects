/// <summary>
/// The behaviors for the word class are to hide and show 
/// a word and to check if a word is hidden or not. In addition
/// a Word should have a behavior to  get the display text of that
/// world, which woulds be either a the worl itself or underscores _
/// 
/// </summary>
class Word{
    //variables or attributes
    private string _text;
    public bool _isHidden;
    //Constructors
    // Word tiene un costructor que acepta texto
    // q le envianmos de scripture
    public Word (string text){
        _text = text;
        _isHidden = false;

    }
    
    //methods
    public void Hide(){
        _isHidden = true;
    }
    public void Show(){
       
        _isHidden = false;

    }
    public bool IsHidden(){
        return _isHidden;
        
    }
    public string GetDisplayText(){
        return _isHidden ? "_____" : _text;

    }
}