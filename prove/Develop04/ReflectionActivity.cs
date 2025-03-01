using System;
public class ReflectionActivity : Activity{

   public ReflectionActivity() : base ("Reflection Activity", "This activity will help you to reflect on your day: "){
   }

   public void interactReflection(){
    base.InteractPrologue();

    string[] reflectionPrompts = {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
    };

    string[] reflectionsQuestions = {
         "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
    };

    Random r = new Random();
    string ChosenPrompt = reflectionPrompts[r.Next(reflectionPrompts.Length)];

    Console.WriteLine(ChosenPrompt);

     while(Timer.isExpired() == false)
   {
    foreach (string question in reflectionsQuestions)
    {
        if (Timer.isExpired() == true)
        {
            break;
        }
        Console.WriteLine(question);
        Console.ReadLine(); 
    }
      
   }

    base.InteractEpilogue();
   }


}

