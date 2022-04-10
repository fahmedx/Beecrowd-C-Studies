using System;
class URI{
    static void Main(string[] args){
        double radius, volume;
        radius = Convert.ToDouble(Console.ReadLine());
        volume = (4 * 3.14159 * Math.Pow(radius, 3.0))/3;
        Console.WriteLine("VOLUME = {0}", volume.ToString("0.000"));
    }
}