// Exercise 13 
Console.WriteLine("Enter your number: ");
string? MyNumber = Console.ReadLine();
if (MyNumber == null ? false : MyNumber.Length >= 3)
{
    char[] chars = MyNumber.ToCharArray();
    Console.WriteLine(chars[2]);
}
else
{
    Console.WriteLine("The number doesn't have third digit");
}