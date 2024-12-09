while (true)
{
    Console.Write("I am an anagram tester. \nGive two strings and I'll tell you if it's an anagram! \nMessage 1:");
    string message1 = Console.ReadLine().ToLower();
    Console.Write("Message 2:");
    string message2 = Console.ReadLine().ToLower();
    string string1 = String.Concat(message1.OrderBy(c => c)).TrimStart().TrimEnd();
    string string2 = String.Concat(message2.OrderBy(c => c)).TrimStart().TrimEnd();

    string result = (string1 == string2) ? "Values have the same length and letters, it's an anagram. " : "Not an anagram. ";
    Console.Write(result + "\nDo you want to restart the tester? (Y/N):");

    string response = Console.ReadLine().ToLower();
    if (response != "y")
    {
        Console.WriteLine("Goodbye!");
        break;
    }
}


//Same letters, same length, different arrangement
//Sort the letters alphabetically, if it matches its anagram

//Examples:

//    Listen → Silent
//    Race → Care
//    God → Dog
//    Tea → Eat
//    Cinema → Iceman

//Anagram Phrases:

//    A gentleman → Elegant man
//    Clint Eastwood → Old west action
//    Debit card → Bad credit