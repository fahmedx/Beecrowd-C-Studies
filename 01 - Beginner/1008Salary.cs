using System;

class URI {
    /*
        Write a program that reads an employee's number,
        his/her worked hours number in a month and the amount he received per hour. 
        Print the employee's number and salary that he/she will receive at end of the month, 
        with two decimal places.

        Don’t forget to print the line's end after the result,
        otherwise you will receive “Presentation Error”.
        Don’t forget the space before and after the equal signal and after the U$.
    Input
        The input file contains 2 integer numbers and 1 value of floating point, 
        representing the number, 
        worked hours amount and the amount the employee receives per worked hour.

    Output
        Print the number and the employee's salary, 
        according to the given example, 
        with a blank space before and after the equal signal.
    */
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