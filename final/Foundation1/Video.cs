public class Video{
    //Attributes
    private string _title;
    private string _author;
    private int _length;
    public List<Comment> Comments = new List<Comment>();
    //Creamos una lista para almacenar los objetos comment
    //Constructor
    public Video (string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;
    }
    public string GetTitle(){
        return _title;
    }
    public string GetAuthor(){
        return _author;
    }
    public int GetLength(){
        return _length;
    }

    //Methods
    //Creamos un metodo para añadir comentarios a la lista
    public void AddComment(string _name, string _comment){
        //new comment constructor de comment
        Comment comment = new Comment(_name, _comment);
        //añadimos a la lista comments
        Comments.Add(comment);
    }
    public int GetNumComments(){
        return Comments.Count;
    }

    
}