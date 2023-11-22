public class Word{
    
    public string Text {get;}
    public bool hidden { get; private set;}
    //Aqui tenemos un constructor el cual pasa texto como string

    public Word(string text)
    {
        Text = text;
        hidden = false;
    } 
    //Aqui tenemos un metodo, el cual nos comunica 
    //cuando las palabras estan escondidas
    public void Hide()
    {
        hidden = true;
    }
}