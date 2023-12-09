public class SalaryEmployee : Employee
{
    private float _salary = 0; //empezara en 0 por defecto
    public float GetSalary(){
        return _salary;
    }
    public void SetSalary(float salary){
        _salary= salary;
    }
}