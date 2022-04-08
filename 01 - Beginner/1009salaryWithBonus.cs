using System;

class URI{
    static void Main(string[] args){
       string name;
       double salary, commission, total;
       name = Console.ReadLine();
       salary = Convert.ToDouble(Console.ReadLine());
       commission = Convert.ToDouble(Console.ReadLine());
       total = salary + (commission * 0.15);
       Console.WriteLine("TOTAL = R$ {0}",total.ToString("0.00"));
    }
}