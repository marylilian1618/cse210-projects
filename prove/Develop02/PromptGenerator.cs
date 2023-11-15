public class PromptGenerator{
    public List<String>_prompts = new List <String>(){
        "How are you feeling today?",
        "Did you do something different today?",
        "Have you met with friends or family today?",
        "How is your work or studies going?",
        "Did you accomplish your goals for today?"
    };

    public string GetRandomPrompt(){
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
        } 
        
    }
   
