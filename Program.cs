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

string cadenaIngresada=Console.ReadLine();

Console.WriteLine("La longitud de la cadena ingresada es de " + cadenaIngresada.Length + " caracteres");

//CALCULADORA V1

bool realizar = true;

do
{   
    Console.WriteLine("Ingrese una operacion a realizar:");

    Console.WriteLine("S: SUMAR");
    Console.WriteLine("R: RESTAR");
    Console.WriteLine("M: MULTIPLICAR");
    Console.WriteLine("D: DIVIDIR");
    Console.WriteLine("MAX: MAXIMO DE LOS DOS");
    Console.WriteLine("MIN: MINIMO DE LOS DOS");

    Console.WriteLine("ABS: VALOR ABSOLUTO");
    Console.WriteLine("CUAD: POTENCIA CUADRADA");
    Console.WriteLine("RAIZ: RAIZ CUADRADA");
    Console.WriteLine("SEN: SENO");
    Console.WriteLine("COS: COSENO");
    Console.WriteLine("INT: PARTE ENTERA DE UN DECIMAL");
    string operacion = Console.ReadLine();
    double num1=0,num2=0;
    bool verifnum1=false;
    bool verifnum2=false;
    string operacionTipo;

    if(operacion == "S" || operacion== "R" || operacion=="M" || operacion == "D" || operacion == "MAX" || operacion == "MIN")
        {     
    
            Console.WriteLine("Ingrese el primer numero");
            string num1string = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero");
            string num2string = Console.ReadLine();
            verifnum1 =double.TryParse(num1string, out num1);
            verifnum2 =double.TryParse(num2string, out num2);
            operacionTipo = "Binaria";
        }
        else
        {
            Console.WriteLine("Ingrese el numero");
            string num1string = Console.ReadLine();
            verifnum1 =double.TryParse(num1string, out num1);
            operacionTipo = "Unaria";
        } 
        
    if((verifnum1 && verifnum2 && operacionTipo=="Binaria") || (verifnum1 && operacionTipo=="Unaria"))
    {
        double resultado=0;
        string operador="";
        switch (operacion)
            {
                case "S":
                    resultado = num1 + num2;
                    operador ="Suma";
                    break;
                case "R":
                    resultado = num1 - num2;
                    operador ="Resta";
                    break;
                case "M":
                    resultado = num1*num2;
                    operador ="Multiplicacion";
                    break;
                case "D":
                    resultado = num1/num2;
                    operador ="Division";
                    break;
                case "MAX":
                    resultado = Math.Max(num1,num2);
                    operador ="Maximo de los dos";
                    break;
                case "MIN":
                    resultado = Math.Min(num1,num2);
                    operador ="Minimo de los dos";
                    break;
                case "ABS":
                    resultado = Math.Abs(num1);
                    operador ="Valor absoluto";
                    break;
                case "CUAD":
                    resultado = Math.Pow(num1,2);
                    operador ="Cuadrado";
                    break;
                case "RAIZ":
                    resultado = Math.Sqrt(num1);
                    operador ="Raiz Cuadrada";
                    break;
                case "SEN":
                    resultado = Math.Sin(num1);
                    operador ="Seno";
                    break;
                case "COS":
                    resultado = Math.Cos(num1);
                    operador ="Coseno";
                    break;
                case "INT":
                    resultado = (int)num1;
                    operador ="Entero";
                    break;    

                default:
                    Console.WriteLine("La operacion que busca no existe en esta calculadora");
                    break;
            }
        if (operacionTipo == "Binaria")
        {
            Console.WriteLine("Resultado de la " + operador + " es : " + resultado);
        }
        else
        {
            Console.WriteLine("Resultado del " + operador + " es : " + resultado);
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





