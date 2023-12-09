public class HourlyEmployee : Employee
{
    private float _payRate = 0;
    private int _hoursWorked = 0;
    public float GetPayRate(){
        return _payRate;
    }
    public void SetPayRate(float payRate){
        _payRate = payRate;
    }
    public float GetHoursWorked(){
        return _hoursWorked;
    }
    public void SetHoursWorked(int hoursWorked){
        _hoursWorked = hoursWorked;
    }
}