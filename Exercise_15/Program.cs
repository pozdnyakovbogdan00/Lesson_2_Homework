// Exercise 15
Console.WriteLine("Enter your number: ");
string? MyNumber = Console.ReadLine();

if (MyNumber != "") 
{   
    int[] WeekendDay = { 6, 7 };
    int result = Array.Find(WeekendDay, element => element == Convert.ToInt32(MyNumber)); 
    string OutPutText = result == 0 ? "NO" : "YES";
    Console.WriteLine(OutPutText);    
}
else
{
    Console.WriteLine("You don't enter number!");   
}