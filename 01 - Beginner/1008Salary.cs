using System;

class URI {
    static void Main(string[] args){
        int employee = 0, workedHours = 0;
        double hourValue = 0, salary = 0;
        employee = Convert.ToInt32(Console.ReadLine());
        workedHours = Convert.ToInt32(Console.ReadLine());
        hourValue = Convert.ToDouble(Console.ReadLine());
        salary = hourValue * workedHours;
        Console.WriteLine("NUMBER = {0}",employee);
        Console.WriteLine("SALARY = U$ {0}",salary.ToString("0.00"));
    }
}