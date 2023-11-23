// a parent class called Person
public class Person
{
    private string _name;

    public Person(string name)
    {
        _name = name;
    }
    // regresa el name modificado por el constructor
    // recuerda que es simepre importante poner el codigo en orden
    public string GetName()
    {
        return _name;
    }
}