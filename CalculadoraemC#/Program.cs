//O código da calculadora não funciona por motivos que desconheço.

char operador = 'y';
decimal resultado = 0;
decimal valor1 = 0;
decimal valor2 = 0;

Console.WriteLine("Digite seu primeiro valor: ");
Console.ReadLine(valor1);
Console.WriteLine("Digite seu segundo valor: ");
Console.ReadLine(valor2);

Console.WriteLine("Agora escolha uma das operações: ( soma + > subtração - > multiplicação * > divisão / )");
Console.ReadLine(operador);
//Tá com um erro que não sei nem qual é nessa parte, socorro.

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
