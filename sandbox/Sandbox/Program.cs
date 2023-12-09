using System;

class Program
{
    static void Main(string[] args)
    {
        HourlyEmployee hEmployee = new HourlyEmployee();
        hEmployee.SetName("John");
        hEmployee.SetIdNumber("123");
        hEmployee.SetPayRate(129);
        hEmployee.SetHoursWorked(12);

        SalaryEmployee sEmployee = new SalaryEmployee();
        sEmployee.SetName("EMELWAI");
        sEmployee.SetIdNumber("123");
        sEmployee.SetSalary(123);

        //we call a function 
        DisplayEmployeeInformation(hEmployee);
        DisplayEmployeeInformation(sEmployee);


    }
    //CREAMOS UNA FUNCION
     public static void DisplayEmployeeInformation(Employee employee){ //tipo de funcion employee y parametro employee
        Console.WriteLine($"{employee.GetName()}");
     }
}