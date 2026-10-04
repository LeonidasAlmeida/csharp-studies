using System; //Import the System namespace

Console.WriteLine(FeetToInches(30)); //360
Console.WriteLine(FeetToInches(100)); //1200
Console.ReadKey(); // wait for user input berfore closing the program


int FeetToInches(int feet)
{
    int inches = feet * 12;
    return inches;
}