Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("Valor de a:" + a);
Console.WriteLine("Valor de b:" + b);

string numString = Console.ReadLine();

int num,invertido=0;

if(int.TryParse(numString, out num))
{
    if(num > 10)
    {
        while (num >= 10)
        {
            invertido = num%10;
            num /= 10;
            Console.Write(invertido);
        }
        Console.Write(num);
    }
    else
    {
        Console.Write(num);
    }
    
}

string cadenaIngresada=Console.ReadLine();

Console.WriteLine("La longitud de la cadena ingresada es de " + cadenaIngresada.Length + " caracteres");

