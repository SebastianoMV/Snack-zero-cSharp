﻿// See https://aka.ms/new-console-template for more information
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


//SNACK 3

Console.WriteLine("");
Console.WriteLine("Snack 3");

int sum = 0;

Console.WriteLine("Inserisci 10 numeri");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Inserisci il " + (i + 1) + "° numero");
    int n = Int32.Parse(Console.ReadLine());
    sum += n;
}

Console.WriteLine("La somma è " + sum);


//SNACK 4

Console.WriteLine("");
Console.WriteLine("Snack 4");

int sumSnack4 = 0;

for (int i = 2; i <= 10; i++)
{
    sumSnack4 += i;
}

Console.WriteLine("La somma dei numeri da 2 a 10 è " + sumSnack4);


//SNACK 5

int numberSnack5 = 0;

Console.WriteLine("Inserisci un numero");

numberSnack5 = Int32.Parse(Console.ReadLine()); 

if (numberSnack5 % 2 == 0)
{
    Console.WriteLine("Il numero " + numberSnack5 + " è pari");
}
else
{
    Console.WriteLine("Il numero " + numberSnack5 + " non è pari, il numero " + (numberSnack5 + 1) + " è pari.");
}
