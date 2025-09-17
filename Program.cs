using System.Collections;
using System.Xml.Serialization;

using Calculadora;

Calculadora.Calculadora calculadora = new Calculadora.Calculadora();

double valor1 = 0;
double valor2 = 0;

Console.WriteLine("Digite a operação que deseja realizar de acordo com as opções abaixo:");

ArrayList operacoes = new ArrayList();
operacoes.Add("Somar");
operacoes.Add("Subtrair");
operacoes.Add("Multiplicar");
operacoes.Add("Dividir");
operacoes.Add("Potencia");
operacoes.Add("Raiz");

for (int i = 0; i < operacoes.Count; i++)
{
    Console.WriteLine(operacoes[i]);
   
}
Console.WriteLine("\n");

string operacaoEscolhida = Console.ReadLine();

if (operacaoEscolhida.Equals("Raiz")) {
    
    Console.WriteLine("Agora digite o primeiro valor da operação");
    valor1 = Convert.ToDouble(Console.ReadLine());
    
} else {
    
    Console.WriteLine("Agora digite o primeiro valor da operação");
    valor1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Agora digite o segundo valor da operação");
    valor2 = Convert.ToDouble(Console.ReadLine());
        
}

switch (operacaoEscolhida)
{
    case "Somar":
        calculadora.Somar(valor1,valor2);
        break;
    case "Multiplicar":
        calculadora.Mutiplicar(valor1,valor2);
        break;
    case "Dividir":
        calculadora.Dividir(valor1,valor2);
        break;
    case "Subtrair":
        calculadora.Subtrair(valor1,valor2);
        break;
    case "Potencia":
        calculadora.Potencia(valor1,valor2);
        break;
    case "Raiz":
        calculadora.RaizQuadrada(valor1);
        break;
    
    default:
        Console.WriteLine("Operação não encontrada");
        break;
}


 



