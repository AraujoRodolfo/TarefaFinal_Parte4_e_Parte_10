double value = 0, ret;

Console.Write("Digite um rúmero: ");
value = double.Parse(Console.ReadLine());

Fatorial fat = new Fatorial();
ret = fat.display(value);

Console.WriteLine("O fatorial de {0} é {1}", value, ret);

class Fatorial
{
    public double display(double n)
    {
        double res = 1;
        
        while (n != 1)
        {
            res = res * n;
            n = n - 1;
        }
        
        return res;
    }
}