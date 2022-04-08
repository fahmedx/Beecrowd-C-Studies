using System;

class URI {
    static void Main(string[] args){
        int prod1, prod2, qtd1, qtd2;
        double price1, price2, total;
        prod1 = Convert.ToInt32(Console.ReadLine());
        qtd1 = Convert.ToInt32(Console.ReadLine());
        price1 = Convert.ToDouble(Console.ReadLine());
        prod2 = Convert.ToInt32(Console.ReadLine());
        qtd2 = Convert.ToInt32(Console.ReadLine());
        price2 = Convert.ToDouble(Console.ReadLine());
        total = ((qtd1 * price1)+(qtd2 * price2));
        Console.WriteLine("VALOR A PAGAR: R$ {0}", total.ToString("0.00"));
    }
}