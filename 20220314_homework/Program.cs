// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// init
int min = 1; int max = 5;
int inputNumber = 0;
string[] title = { "姓名", "成績一", "成績二", "成績三" };
string[,] studentData = new string[4, 4] {
    // name, grade1, grade2, geade3
    {"NameA1","","",""},
    {"NameB2","","",""},
    {"NameC3","","",""},
    {"NameD4","","",""}
    };

Random random = new();
for (int i = 0; i < 4; i++)
{
    for (int j = 1; j < 4; j++)
    {
        studentData[i, j] = random.Next(1, 99).ToString();
    }
}

// main
Main:
Console.WriteLine("Please enter the seat number:");
while (true)
{
    string? inputLine = Console.ReadLine();
    if (Int32.TryParse(inputLine, out int result))
    {
        if (min <= result & result <= max)
        {
            inputNumber = result - 1;
            break;
        }
        else
        {
            Console.WriteLine("查無此人");
        }
    }
    else
    {
        Console.WriteLine("it's not a number, please enter a number");
    }
}

// "However, with multidimensional arrays, using a nested for loop gives you more control over the order in which to process the array elements." ---- Microsoft
for (int i = 0; i < 4; i++)
{
    Console.Write(title[i] + " : ");
    Console.WriteLine(studentData[inputNumber,i]);
}

Console.WriteLine("Press Enter to exit, or press any other key and enter to query again");
if(Console.ReadLine() != "")
{
    goto Main;
}



