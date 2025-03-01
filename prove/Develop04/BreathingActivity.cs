using System;
public class BreathingActivity : Activity{

    public BreathingActivity() : base("Breathing Activity", "This activity will help you to relax and breathe: "){
    }

    public void InteractBreathing(){
        base.InteractPrologue();


        while(Timer.isExpired() == false){

            Console.WriteLine("Breath in ...");

            Countdown();

        if(Timer.isExpired() == true){
            break;
        }
            Console.WriteLine("Breath out ....");

            Countdown();
        }

         base.InteractEpilogue();


    }

    public void Countdown(){
        for(int i = 4; i > 0; i--){
            if(Timer.isExpired() == true){
                break;
            }
            Console.WriteLine(i);
            Thread.Sleep(1000);
        } 
    }

    
}