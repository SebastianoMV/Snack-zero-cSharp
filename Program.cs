// See https://aka.ms/new-console-template for more information
Console.WriteLine("Esercizio Snack 0");

//SNACK 1
Console.WriteLine("");
Console.WriteLine("Snack 1");

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



//SNACK 2

Console.WriteLine("");
Console.WriteLine("Snack 2");

string firstWord;
string secondWord;

Console.WriteLine("Inserisci la prima parola");
firstWord = Console.ReadLine();

Console.WriteLine("Inserisci la seconda parola");
secondWord = Console.ReadLine();

if (firstWord.Length > secondWord.Length)
{
    Console.WriteLine(firstWord + " è più lunga");
}
else if (secondWord.Length > firstWord.Length)
{
    Console.WriteLine(secondWord + " é più lunga");
}
else
{
    Console.WriteLine("Le due parole sono lunghe uguali");
}