/*ATIVIDADE 1
*//*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quantidade de sorvetes comprados: ");
        int quantidade = int.Parse(Console.ReadLine());

        double precoPorUnidade;

        if (quantidade <= 25) {
            precoPorUnidade = 1.50;
        }
        else {
            precoPorUnidade = 1.25;
        }

        double totalAPagar = quantidade * precoPorUnidade;

        Console.WriteLine($"O cliente comprou {quantidade} sorvetes e deverá pagar R${totalAPagar:F2}.");

        Console.ReadKey();
    }
}*/



/*ATIVIDADE 2
*/

/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira um número:");
        int numero = int.Parse(Console.ReadLine());

        int resultado;

        if (numero > 10){
            resultado = numero + 10 * 2;
        }else{
            resultado = numero + 9 * 3 - 8;
        }
        
        Console.WriteLine("O resultado é: " + resultado);

        Console.ReadLine();
    }
}*/



/*ATIVIDADE 3
*/


/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira um número:");
        int numero = int.Parse(Console.ReadLine());

        if (numero >=0) {
            Console.WriteLine($"O número é positivo");
        } else{
            Console.WriteLine($"O número é negativo");
        }
    }
}*/


/*ATIVIDADE 4 */

/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira o primeiro número:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira o segundo número:");
        int numero2 = int.Parse(Console.ReadLine());

        if (numero1 > numero2){
            Console.WriteLine($"{numero1} é maior que {numero2}");
        }
        else if (numero2 > numero1){
            Console.WriteLine($"{numero2} é maior que {numero1}");
        }
        else{
                   Console.WriteLine("Os números são iguais");
        }

        Console.ReadLine();
    }
}*/




/*ATIVIDADE 5
*/

/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira a primeira nota:");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Insira a segunda nota:");
        double nota2 = double.Parse(Console.ReadLine());

        // Calcular a média
        double media = (nota1 + nota2) / 2;

        if (media >= 7)
        {
            Console.WriteLine($"Média: {media:F1}. Aprovado");
        }
        else
        {
            Console.WriteLine($"Média: {media:F1}. Reprovado");
        }

        Console.ReadLine();
    }
}*/





