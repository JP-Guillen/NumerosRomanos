using System;

public class NumerosRomanos
{

    public static int ValorRomano(char CaracterRomano) 
    {
        switch (CaracterRomano)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;

            default: return 0;
        }
    }


    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa un numero romano: ");
        string numeroRomano = Console.ReadLine().ToUpper();
        int valorDecimal = ConvertirRomano(numeroRomano);
        Console.WriteLine($"El numero Romano {numeroRomano} es {valorDecimal} en decimal. ");
    }
    
    
    
    public static int ConvertirRomano(string romano)
    {
        int total = 0;
        int valorAnterior = 0;

        for (int i = romano.Length - 1; i >= 0; i--)
        {
            char CaracterActual = romano[i];
            int valorActual = ValorRomano(CaracterActual);

            if (valorActual < valorAnterior)
            {  
                total -= valorActual;
            }
            else
            {
                total += valorActual;
            }


            valorAnterior = valorActual;

        }
        return total;
    }
}