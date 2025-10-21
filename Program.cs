// Debug This! 
// Your job: find and fix the bugs and add defensive programming

// Even though we are writing top-level code, we still need two "using" statements; enter them below

Console.WriteLine("Welcome to the Debugging Challenge!");
Console.Write("Enter your name? "); // Check this line
string name = Console.ReadLine() + "";

Console.WriteLine($"Hell {name}! Let's do some math."); // made the {name} work
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine() + ""); // made there be no yellow squiggle

int result = 100 / number; // Check this line
Console.WriteLine($"100 divided by your number is: {result}"); // fixed concatination

int remainder = 100 / number; // Check this line
Console.WriteLine($"The remainder of 100 divided by your number is: {remainder}"); // fix concatination.

if (number == 10) // added =
{
    Console.WriteLine("You entered ten!");
}
else
{
    Console.WriteLine("You didn't enter ten.");
}

int counter = 0;
while (counter <= number)
{
    Console.WriteLine($"Counting up: {counter}"); // fixed concatination
    counter++; // made it ++ instead of --
}
Console.WriteLine("Done counting!");

string again;
do
{
    Console.WriteLine("Do you want to see your number squared? (yes/no)");
    again = Console.ReadLine() + "";

    Console.WriteLine($"Your number squared is: {number * number}"); // fixed concatination
}
while (again == "yes"); // added a =


for (int i = 5; i >= 0; i--) // made it -- instead of ++
{
    Console.WriteLine($"Countdown: {i}");
}

int[] scores = new int[5];
scores[4] = 100; // Changed 5 to 4
Console.WriteLine($"First score: {scores[0]}"); // Check this line and rewrite it
Console.WriteLine($"Last score: {scores[4]}"); // fixed concatination and added score[4]

List<string> fruits = new List<string>() { "Apple", "Banana", "Cherry" };
fruits.Remove("Apple"); // Changed to something in the list
fruits.Add("Pineapple"); // Changed to a fruit

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit.ToUpper()); // Check this line
}

Console.Write("Pick a number between 1 and 3: ");
int choice = int.Parse(Console.ReadLine() + "");

switch (choice)
{
    case 1:
        Console.WriteLine("You picked one!");
        break;
    case 2:
        Console.WriteLine("You picked two!");
        break;
    case 3:
        Console.WriteLine("You picked three!");
        break;
    default:
        Console.WriteLine("That's not between 1 and 3!");
        break;
}












































































Console.WriteLine("Thanks for debugging, " + name + "!");
Console.WriteLine("Press Enter to exit.");
Console.ReadLine();
