using System;
using System.Diagnostics;
public class Timer{
    private static DateTime _targetTime;


    
    public static void setTime(int time
    ){
    _targetTime = DateTime.Now.AddSeconds(time);
    }

    public static bool isExpired(){
    return DateTime.Now >= _targetTime;
    }

    public static void pauseWithAnimation(int seconds){
        for(int  i = 0; i < seconds; i++){
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }

    }

}
