using System;

class Program
{
    static void Main(string[] args)
    {   // en este caso no usamos set al poner get pq utilizamos un constructor para
    // obtener los datos necesairos para el programa
    // esto tambien se puede hacer con set al asigna un variable al atributo del objeto que queeremos
    // cmbiar
    // como poner stuident.SetName("Here wegoagain");
    //student.SetNumber("hola bebe");

        Student student = new Student("Maria", "Inga");
        string name = student.GetName();
        string number = student.GetNumber();
Console.WriteLine(name);
Console.WriteLine(number);
        Console.WriteLine(student.GetStudentInfo());


    }
}