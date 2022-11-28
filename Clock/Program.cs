using System;


rec();
static void rec() {
    int hour;
    int minute;

    Console.WriteLine("enter hours");
    hour = int.Parse(Console.ReadLine());

    if(hour > 12) {
        hour = hour -12;   
    }
    Console.WriteLine("enter minute");
    minute = int.Parse(Console.ReadLine());
    if (hour < 0 || minute < 0 || hour > 12 || minute > 60)
        Console.Write("Wrong input");

    int diff = Math.Abs(hour * 5 - minute);
    int ans = diff * 90 / 15;
    if (ans <= 180)
    {
        Console.WriteLine("{0}", ans);
    }
    else
    {
        Console.WriteLine("{0}", 360-ans);
    }
    rec();
    
}



