// This is a comment to my code

// Rakendus palub kasutajal sisestada oma nimi.
Console.WriteLine("Enter your name:"); //Output

// String on sõne
string userName = Console.ReadLine(); //Input

// Rakendus tervitab kasutajat nimepidi.
// Pikk variant
Console.WriteLine("Hello, " + userName + "!"); //Output
// Lühike variant - String interpolation
Console.WriteLine($"Hello, {userName}!"); //Output
