// Exercise 10 
Console.WriteLine("Enter your number: ");
string? MyNumber = Console.ReadLine();
if (MyNumber == null ? false : MyNumber.Length == 3) 
{    
    char[] chars = MyNumber.ToCharArray();
    Console.WriteLine(chars[1]);    
}
else
{
    Console.WriteLine("The number must be three digits");   
}