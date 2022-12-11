int n1, n2, x;
        
Console.WriteLine("Digite dois números:");
n1 = int.Parse(Console.ReadLine());
n2 = int.Parse(Console.ReadLine());

if(n2>n1){
    x = n1;
    n1 = n2;
    n2 = x;
}

Console.Write("Números ímpares entre {0} e {1}: ", n1, n2);

while(n1 >= n2){
    n1--;
    if(n1 % 2 != 0){
        Console.Write(n1 + ", ");
    }
}