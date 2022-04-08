using System;

class URI{
    static void Main(string[] args){
        double A = 0,B = 0,C = 0, media = 0;
        A = Convert.ToDouble(Console.ReadLine());
        B = Convert.ToDouble(Console.ReadLine());
        C = Convert.ToDouble(Console.ReadLine());
        media = (((A*2)+(B*3)+(C*5))/10);
        Console.WriteLine("MEDIA = {0}",media.ToString("0.0"));
    }
}