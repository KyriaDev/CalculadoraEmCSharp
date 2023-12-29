//Ainda falta várias coisas pra por no repositório, mas como estou fazendo pelo celular não vai dar.


char operador;
decimal resultado, valor1, valor2;

Console.WriteLine("Digite seu primeiro valor: ");
Console.ReadLine(valor1);
Console.WriteLine("Digite seu segundo valor: ");
Console.ReadLine(valor2);

Console.WriteLine("Agora escolha uma das operações: ( soma + > subtração - > multiplicação * > divisão / )");
Console.ReadLine(operador);
//Tive preguiça de escrever a conversão, porque tive que codar pelo celular. Depois eu corrijo :).

if (operador == '+')
{
  resultado = valor1 + valor2;
}
else if (operador == '-')
{
  resultado = valor1 - valor2;
}
else if (operador == '*')
{
  resultado = valor1 * valor2;
}
else if (operador == '/')
{
  resultado = valor1 / valor2;
}

Console.WriteLine("Resultado final: ");
Console.WriteLine($"{valor1} {operador} {valor2} = {resultado}");
//Clean Code, confia.
