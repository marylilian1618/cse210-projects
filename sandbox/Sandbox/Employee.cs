public class Employee
{
  //variables
  protected string _name;
  protected string _idNumber;
  //constructor
  public Employee(){

  }
  //getters and setters
  public string GetName(){
    return _name;
  }
  // obtiene nombre para ser usado
  // fuera de las clases hijas ya que para eso
  // sirve el protected
  public void SetName(string name){
    _name = name;
  }
  public string GetIdNumber(){
    return _idNumber;
  }
  public void SetIdNumber(string idNumber){
    _idNumber = idNumber;
  }

  
}