public class ListerActivity : Activity{

   public ListerActivity() : base("Lister Activity"
   , "This activity will help you to list your blessings:  "){
   }
   public void InteractLister(){
      
      base.InteractPrologue();

      string [] prompts = {
         "Who are people that you appreciate? ",
        "What are personal strengths of yours? ",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
      };

   Random random = new Random();
   string chosenPrompt = prompts[random.Next(prompts.Length)];
   Console.WriteLine(chosenPrompt);

   List<string> responses = new List<string>();

   while(Timer.isExpired() == false)
   {
      string userInput = Console.ReadLine();
      if (!string.IsNullOrEmpty(userInput))
            {
                responses.Add(userInput);
            }
      
   }

   base.InteractEpilogue();
}
}