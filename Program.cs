using System.Linq.Expressions;

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


//CALCULADORA V1

bool realizar = true;

do
{   
    Console.WriteLine("Ingrese una operacion a realizar:");
    Console.WriteLine("S: SUMAR");
    Console.WriteLine("R: RESTAR");
    Console.WriteLine("M: MULTIPLICAR");
    Console.WriteLine("D: DIVIDIR");

    string op = Console.ReadLine();
    char operacion;

    if(char.TryParse(op, out operacion))
    {   
        Console.WriteLine("Ingrese el primer numero");
        string num1string = Console.ReadLine();
        Console.WriteLine("Ingrese el segundo numero");
        string num2string = Console.ReadLine();
        double num1,num2;
        
        bool verifnum1 =double.TryParse(num1string, out num1);
        bool verifnum2 =double.TryParse(num2string, out num2);
        
        if(verifnum1 && verifnum2)
        {
            double resultado=0;
            string operador="";
            switch (operacion)
                {
                    case 'S':
                        resultado = num1 + num2;
                        operador ="Suma";
                        break;
                    case 'R':
                        resultado = num1 - num2;
                        operador ="Resta";
                        break;
                    case 'M':
                        resultado = num1*num2;
                        operador ="Multiplicacion";
                        break;
                    case 'D':
                        resultado = num1/num2;
                        operador ="Division";
                        break;
                    default:
                        Console.WriteLine("La operacion que busca no existe en esta calculadora");
                        break;
                }
            
            Console.WriteLine("Resultado de la " + operador + " es : " + resultado);
        }
        
    }
    Console.WriteLine("Desea realizar otra operacion? S:SI , N:NO");  
    string confirmacion = Console.ReadLine();
    if(confirmacion == "S" || confirmacion == "s")
    {
        realizar = true;
    }
    else if(confirmacion == "N" || confirmacion == "n")
    {
        realizar = false;
    }
}while(realizar);





