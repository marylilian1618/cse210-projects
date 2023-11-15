public class Resume{
    public string _name;
    public List<Job>_jobs = new List<Job>();
    public void Display(){
        
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");

        foreach (Job job in _jobs){
            job.Display();
            //llamamos al display de entry
            // el cual imprime la fecha, la pregunta
            // y los escritos
        }
        

    }

}