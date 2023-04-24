int number = 56234623;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
Console.WriteLine("+++");
Console.WriteLine("wynik dla " + number);
for (int i = 0; i < 10; i++)
{
    int count = 0;
    foreach (char letter in letters)
    {
        if ((int)Char.GetNumericValue(letter) == i)
        {
            count++;
        }
    }
    Console.WriteLine(i + ": " + count);
}
int numberb = 123456789;
string numberbInString = numberb.ToString();
char[] lettersb = numberbInString.ToCharArray();
Console.WriteLine("...");
Console.WriteLine(" wynik dla cyfry " + numberb);
int counterb0 = 0;
int counterb1 = 0;
int counterb2 = 0;
int counterb3 = 0;
int counterb4 = 0;
int counterb5 = 0;
int counterb6 = 0;
int counterb7 = 0;
int counterb8 = 0;
int counterb9 = 0;

foreach (char letter in lettersb)
{
    if (letter == '0')
    {
        counterb0++;
    }
    else if (letter == '1')
    {
        counterb1++;
    }
    else if (letter == '2')
    {
        counterb2++;
    }
    else if (letter == '3')
    {
        counterb3++;
    }
    else if (letter == '4')
    {
        counterb4++;
    }
    else if (letter == '5')
    {
        counterb5++;
    }
    else if (letter == '6')
    {
        counterb6++;
    }
    else if (letter == '7')
    {
        counterb7++;
    }
    else if (letter == '8')
    {
        counterb8++;
    }
    else if (letter == '9')
    {
        counterb9++;
    }

}
Console.WriteLine("0=>" + counterb0);
Console.WriteLine("1=>" + counterb1);
Console.WriteLine("2=>" + counterb2);
Console.WriteLine("3=>" + counterb3);
Console.WriteLine("4=>" + counterb4);
Console.WriteLine("5=>" + counterb5);
Console.WriteLine("6=>" + counterb6);
Console.WriteLine("7=>" + counterb7);
Console.WriteLine("8=>" + counterb8);
Console.WriteLine("9=>" + counterb9);
