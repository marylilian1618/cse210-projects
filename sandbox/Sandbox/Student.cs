
// a child class called Student
public class Student : Person
{ 
    //recuerda que estamos usando inheretance lo que significa que 
    //aparte de tener codigo student tiene el codigo de person
    private string _number;

    // calling the parent constructor using "base"! 
    // de esta forma llamamos a los dos codigos
    public Student(string name, string number) : base(name)
    {
      _number = number;
    }

    public string GetNumber()
    {
        return _number;
    }
    public string GetStudentInfo()
    {
        // ERROR! This line doesn't work, because _name is private in the base class
        // solucionamos el bug llamando al metodo que tiene el private :D
        // y pq funciona number? si tambien es privado pues pq ya lo obtuvimos con get y 
        // ahora lo usamos con otro método...
        //¿Pero tambien obtuvimos name... no? bueno eso si no entiendo ajajja igual haganlo 
        return GetName() + " " + _number;
        
    }

}