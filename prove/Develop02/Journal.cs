public class Journal
{
    public List<Entry>_entries = new List<Entry>();
    public void AddEntry (Entry newEntry){
        _entries.Add(newEntry);
        //the Entry is the type of data we are using
        //Como en una funcion cuando pones si es int o string
        // the new entry 
        //es el parametro de la funcion es decir 
        //el dato que pasaremos para que se ejecute la funcion

    }
    public void DisplayAll(){
        foreach (var entry in _entries){
            entry.Display();
        }
        // esto iterara entre cada elemente de _entries
        // y luego ejecutara display

    }
    public void SavetoFile (string file){
        using (StreamWriter writer = new StreamWriter(file)){
            foreach (var entry in _entries){
                writer.WriteLine($"{entry._date}, {entry._promptText}, {entry._entryText}");
            }
        }
    }
    public void LoadFromFile (string file){
        _entries.Clear();
        using (StreamReader reader = new StreamReader(file)){
            while (!reader.EndOfStream){
                var line = reader.ReadLine().Split(',');
                Entry loadedEntry = new Entry{
                    _date = line [0],
                    _promptText = line[1],
                    _entryText = line[2]

                };
                _entries.Add(loadedEntry);
            }
        }
    }
}