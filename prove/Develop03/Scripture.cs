
class Scripture
{ 
    //this is a get vamos a obtener reference
    public string Reference { 
        get; 
        }
    //LIST
    //se declara una lista llamada words
    // esta lista es una lista de objetos Word.cs
    private List<Word> words;

    //CONSTRUCTOR
    //creamos un constructor el cual pasara reference como string y texto 
    //de esta manera pasamos de frente reference y text. 
    //Reference sera el nombre de la escritura y text la escritura
    public Scripture(string reference, string text)
    {
        Reference = reference;
        InitializeWords(text);
    }
    //METODOS:

    //creamos un metodo (funcion) q acepta como parametro text (TEXTO DE LA ESCRITURA)
    private void InitializeWords(string text)
    {   //vamos a dividir cada palabra de texto y lo almacenaremos en una lista llamada wordArray
        string[] wordArray = text.Split(' ');
        //se incicializa words, con la capacidad de la cantidad de palabras del texto.
        words = new List<Word>(wordArray.Length);
        
        //para cada palabra en wordArray añadir una nueva instancia de word en la lista words 
        foreach (string word in wordArray)
        {   // le añadimos a la lista words cada objeto que se cree por palabra

            words.Add(new Word(word));
        }
    }


    //creamos otro metodo que no tiene ningun parametro pero se encarga
    //de reemplazar words por underscore
    public string GetVisibleText()
    {   //string.Join para concatenar el texto de cada objeto Word
        // 
        return string.Join(" ", words.Select(w => w.hidden ? "_____" : w.Text));
    }

    public bool AllWordsHidden => words.All(w => w.hidden);
     
    //Al llamar a esta lista tendremos acceso a words 
    public List<Word> Words {
        get { 
          return words;
        }

}
}