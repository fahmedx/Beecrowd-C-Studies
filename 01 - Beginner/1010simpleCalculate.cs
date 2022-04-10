using System;

class URI {
    static void Main(string[] args){
        int prod1, prod2, qtd1, qtd2;
        double price1, price2, total;
        string line1 = Console.ReadLine();
        string line2 = Console.ReadLine();
        String[] values1 = line1.Split(' ');

        prod1 = Int32.Parse(values1[0]);
        qtd1 = Int32.Parse(values1[1]);
        price1 = Convert.ToDouble(values1[2]);

        String[] values2 = line2.Split(' ');
        prod2 = Int32.Parse(values2[0]);
        qtd2 = Int32.Parse(values2[1]);
        price2 = Convert.ToDouble(values2[2]);
        total = ((qtd1 * price1)+(qtd2 * price2));
        Console.WriteLine("VALOR A PAGAR: R$ {0}", total.ToString("0.00"));
    }
}