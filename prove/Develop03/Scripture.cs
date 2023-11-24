using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
/// <summary>
/// The class scripture will hide random words and get
/// the display text as a string it also has a behavior
/// to check is the scripture is completely hidden.
/// </summary>
class Scripture{

    //Variables

    Reference _reference;  //luego de llamar constructor reference llamamos a este
    private List<Word> _words;

    //Constructors
    // Parece que los constructores pueden obtener
    //info si esta aun asi no esta declarada como variable
    //en la clase y usarla en el constructor como text
    public Scripture( Reference reference, string text){
        _reference = reference;
        //guardando en wordArray el texto separado
        string[] wordArray = text.Split(' ');
        //parametro de longitud
        _words = new List<Word>(wordArray.Length);

        foreach(string word in wordArray){
            ///En esta parte por cada word en la lista wordArray
            ///añadimos a la lista words objetos Word 
            _words.Add(new Word(word));
        }

    }

    // methods
    public void HideRandomWords( int numberToHide ){
        //this will create an instance of random class (choose random)
        Random random = new Random();
        // create a foor loop whic will iterate 
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
        

    }
    public string GetDisplayText(){
        List <string> displayTextList = new List<string> ();
        foreach (Word word in _words)
        {
            displayTextList.Add(word.GetDisplayText());
        }
        
        return string.Join(" ", displayTextList);
    }
        
    public bool IsCompletelyHidden(){

        foreach(Word word in _words){
            if (!word.IsHidden()){
                return false;
            }
        }
        return true;

    }
    public override string ToString()
    {
        return $"{_reference.GetDisplayText()} - {GetDisplayText()}";
    }

}