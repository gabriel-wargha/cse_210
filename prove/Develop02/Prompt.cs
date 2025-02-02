using System;
using System.Collections.Generic;

public class Prompt
{
    // Attributes
    private int _random_index;
    private static readonly List<string> _promptList = new List<string>
    {
        
 "How did you sleep last night?", "What was the first thing you did this morning?", "Did you wake up feeling rested?",  
    "What is one thing you are looking forward to today?", "Did you have breakfast? What did you eat?", "What was the weather like this morning?",  
    "Did you check your phone first thing in the morning?", "What was your mood when you woke up?", "Did you exercise or stretch in the morning?",  
    "What is one thing you could improve about your morning routine?", "What was your main goal for today?", "Did you complete everything you planned to do?",  
    "What was the most productive part of your day?", "What distractions did you face today?", "How did you manage your time today?",  
    "What was the most challenging task you worked on?", "Did you learn anything new today?", "How did you stay motivated?",  
    "Did you procrastinate on anything? Why?", "What is one thing you can do better tomorrow?", "Who did you talk to the most today?",  
    "Did you have a meaningful conversation with someone?", "Did you help someone today?", "Did anyone help you with something?",  
    "How did you feel about your interactions today?", "Did you receive or give a compliment today?", "Did you meet someone new?",  
    "Was there any conflict or disagreement today?", "Did you laugh a lot today?", "Did you feel lonely at any point?", "What did you eat for lunch?",  
    "Did you drink enough water today?", "Did you have any unhealthy snacks?", "How many meals did you eat today?", "Did you cook anything today?",  
    "How did you feel after eating your meals?", "Did you take any vitamins or supplements?", "Did you exercise today? What did you do?",  
    "How did your body feel today?", "Were you feeling energetic or tired?", "What was your overall mood today?", "Did anything make you feel frustrated?",  
    "What made you happy today?", "Did you feel stressed? Why?", "Did you feel anxious about anything?", "What was the best moment of your day?",  
    "Did you feel bored at any point?", "What is one thing that could have made your day better?", "Did you take any time to relax?",  
    "How would you rate today from 1 to 10?", "Did you listen to any music today? What kind?", "Did you watch any TV shows or movies?",  
    "Did you play any games today?", "Did you read anything interesting?", "Did you learn something fun or new?", "Did you spend time on social media?",  
    "Did you create anything today (art, writing, coding, etc.)?", "Did you go outside for fresh air?", "Did you take any pictures today?",  
    "What is one fun thing you did today?", "Did you step out of your comfort zone today?", "What is one thing you are proud of today?",  
    "Did you make progress on a personal goal?", "What is something you are grateful for today?", "Did you challenge yourself mentally or physically?",  
    "Did you feel confident in yourself today?", "What is something you wish you had done differently?", "What is something you learned about yourself today?",  
    "Did you practice any positive habits today?", "What inspired you today?", "What was the last thing you did before bed?", "Did you have a nighttime routine?",  
    "Did you feel satisfied with your day?", "Did you set goals for tomorrow?", "What is something you want to dream about tonight?",  
    "Did you spend time reflecting on your day?", "What time are you going to sleep?", "Do you feel relaxed right now?", "Did you do anything to wind down before bed?",  
    "What is one thing you are grateful for as the day ends?", "If today was a movie, what would the title be?", "If you had to describe today in one word, what would it be?",  
    "What color represents today for you?", "If today was a song, what would it sound like?", "If you could relive one moment from today, what would it be?",  
    "What was the funniest thing that happened today?", "Did you have any weird or interesting thoughts today?", "What is one thing you will remember from today a year from now?"

    };

    // Behaviors 
    public Prompt()
    {
        _random_index = new Random().Next(0, _promptList.Count);
    }

    public string GeneratePrompt()
    {
        return _promptList[_random_index];
    }
}
