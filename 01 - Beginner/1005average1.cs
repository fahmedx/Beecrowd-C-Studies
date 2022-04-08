using System;

class URI {
    static void Main(string[] args){
        double A = 0, B = 0, media = 0;
        A = Convert.ToDouble(Console.ReadLine());
        B = Convert.ToDouble(Console.ReadLine());
        media = ((A*3.5)+(B*7.5))/11;
        Console.WriteLine("MEDIA = {0}",media.ToString("0.00000"));
    }
}