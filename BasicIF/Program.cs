


//bool isComplete = true;

//if (isComplete)
//    Console.WriteLine("The statement was true.");
//else
//{
//    Console.WriteLine("The statement was false.");
//    Console.WriteLine("This should also run");
//}

//Console.WriteLine("End of program!");

Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

if (firstName.ToLower() == "ayoub")
{
    Console.WriteLine("Hello Mr. Chahir");
}
else
{
    Console.WriteLine($"Hello {firstName}");
}

Console.WriteLine("End of program.");