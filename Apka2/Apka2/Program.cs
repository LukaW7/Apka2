﻿using System.ComponentModel.Design;

var name = "OLA";
var gender = "WOMAN";
var age = 29;

if (gender == "WOMAN" && age < 30)
{
    // Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "OLA" && age == 29)
{
   // Console.WriteLine("Ola, lat 29");
}
else if (gender == "MAN" && age < 18)
{
    // Console.WriteLine("Niepełnoletni mężczyzna");
}

// DZIEŃ 5

int number = 10041990;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        counter0++;
    }
    else if (letter == '1')
    {
        counter1++;
    }
    else if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }
}

Console.WriteLine(0 + "=>" + counter0);
Console.WriteLine(1 + "=>" + counter1);
Console.WriteLine(2 + "=>" + counter2);
Console.WriteLine(3 + "=>" + counter3);
Console.WriteLine(4 + "=>" + counter4);
Console.WriteLine(5 + "=>" + counter5);
Console.WriteLine(6 + "=>" + counter6);
Console.WriteLine(7 + "=>" + counter7);
Console.WriteLine(8 + "=>" + counter8);
Console.WriteLine(9 + "=>" + counter9);
// test