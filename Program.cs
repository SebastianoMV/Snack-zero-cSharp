// See https://aka.ms/new-console-template for more information
Console.WriteLine("Esercizio Snack 0");

//SNACK 1

//Console.WriteLine("");
//Console.WriteLine("Snack 1");

//int firstNumber = 0;
//int secondNumber = 0;

//Console.WriteLine("Inserisci il primo numero");
//firstNumber = Int32.Parse(Console.ReadLine());

//Console.WriteLine("Inserisci il secondo numero");
//secondNumber = Int32.Parse(Console.ReadLine());

//if (firstNumber > secondNumber)
//{
//    Console.WriteLine(firstNumber + " è più grande");
//}
//else if (secondNumber > firstNumber)
//{
//    Console.WriteLine(secondNumber + " é più grande");
//}
//else
//{
//    Console.WriteLine("I due numeri sono uguali");
//}



//SNACK 2

//Console.WriteLine("");
//Console.WriteLine("Snack 2");

//string firstWord;
//string secondWord;

//Console.WriteLine("Inserisci la prima parola");
//firstWord = Console.ReadLine();

//Console.WriteLine("Inserisci la seconda parola");
//secondWord = Console.ReadLine();

//if (firstWord.Length > secondWord.Length)
//{
//    Console.WriteLine(firstWord + " è più lunga");
//}
//else if (secondWord.Length > firstWord.Length)
//{
//    Console.WriteLine(secondWord + " é più lunga");
//}
//else
//{
//    Console.WriteLine("Le due parole sono lunghe uguali");
//}


//SNACK 3

//Console.WriteLine("");
//Console.WriteLine("Snack 3");

//int sum = 0;

//Console.WriteLine("Inserisci 10 numeri");

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Inserisci il " + (i + 1) + "° numero");
//    int n = Int32.Parse(Console.ReadLine());
//    sum += n;
//}

//Console.WriteLine("La somma è " + sum);


//SNACK 4

//Console.WriteLine("");
//Console.WriteLine("Snack 4");

//int sumSnack4 = 0;

//for (int i = 2; i <= 10; i++)
//{
//    sumSnack4 += i;
//}

//Console.WriteLine("La somma dei numeri da 2 a 10 è " + sumSnack4);


//SNACK 5

//Console.WriteLine("");
//Console.WriteLine("Snack 5");

//int numberSnack5 = 0;

//Console.WriteLine("Inserisci un numero");

//numberSnack5 = Int32.Parse(Console.ReadLine());

//if (numberSnack5 % 2 == 0)
//{
//    Console.WriteLine("Il numero " + numberSnack5 + " è pari");
//}
//else
//{
//    Console.WriteLine("Il numero " + numberSnack5 + " non è pari, il numero " + (numberSnack5 + 1) + " è pari.");
//}


//SNACK 6

//Console.WriteLine("");
//Console.WriteLine("Snack 6");

//string[] partyGatsby = { "Myrtle Wilson", "Daisy Buchanan", "Tom Buchanan", "Meyer Wolfsheim", "Jordan Baker", "Jay Gatsby" };

//bool flagInvite = false;

//string personSnack6 = "";

//Console.WriteLine("Inserisci nome e cognome");
//personSnack6 = Console.ReadLine();

//for (int i = 0; i < partyGatsby.Length; i++)
//{
//    if(partyGatsby[i] == personSnack6)
//    {
//        flagInvite = true;
//    }
//}

//if (flagInvite)
//{
//    Console.WriteLine("Benvenuto/a " + personSnack6 + ", lei è in lista, può partecipare al party");
//}
//else
//{
//    Console.WriteLine(personSnack6 + " lei non è invitato/a alla festa");
//}


//SNACK 7

Console.WriteLine("");
Console.WriteLine("Snack 7");

int[] numbersSnack7;
numbersSnack7 = new int[6];

Console.WriteLine("Inserisci 6 numeri");

for (int i = 0; i < numbersSnack7.Length; i++)
{
    int n = 0;


    Console.WriteLine("Inserisci il " + (i + 1) + "° numero");
    n = Int32.Parse(Console.ReadLine());
    if (n % 2 != 0)
    {
        numbersSnack7[i] = n;
    }

    Console.WriteLine(numbersSnack7[i]);
}


//SNACK 8

Console.WriteLine("");
Console.WriteLine("Snack 8");


int[] numbersSnack8 = { 5, 8, 3, 7, 24, 33, 12};

int sumSnack8 = 0;
for (int i = 0; i < numbersSnack8.Length; i++)
{
    if(i % 2 != 0 )
    {
        sumSnack8 += numbersSnack8[i];
    }
}

Console.WriteLine("La somma dei numeri in posizioni dispari è " + sumSnack8);


