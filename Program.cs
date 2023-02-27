// Test one

string[] firstNames = new string[5];

firstNames[0] = "Tim";
firstNames[1] = "Sue";
firstNames[2] = "Bob";
firstNames[4] = "Jane";

Console.WriteLine($"The first names are {firstNames[0]}, {firstNames[1]}," +
    $" {firstNames[2]} & {firstNames[4]}.");


// Test two

string data = "Tim,Sue,Bob,Jane,Frank";
string[] secondNames = data.Split(',');

Console.WriteLine($"The second name is {secondNames[1]}.");

// Test Three

Console.WriteLine(secondNames.Length);

string[] lastNames = new string[] { "Corey", "Smith", "Jones" };

int[] ages = new int[] { 21, 32, 45 };