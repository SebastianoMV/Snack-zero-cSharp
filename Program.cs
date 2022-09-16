// See https://aka.ms/new-console-template for more information
Console.WriteLine("Esercizio Snack 0");

int firstNumber = 0;
int secondNumber = 0;

Console.WriteLine("Inserisci il primo numero");
firstNumber = Int32.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il secondo numero");
secondNumber = Int32.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber + " è più grande");
}
else if (secondNumber > firstNumber)
{
    Console.WriteLine(secondNumber + " é più grande");
}
else
{
    Console.WriteLine("I due numeri sono uguali");
}