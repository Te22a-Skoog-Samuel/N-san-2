// string [] stringArray = {"bil", "tåg", "boll", "fidgetspinner", "batman"};

// foreach (string leksak in stringArray)
// {
//     Console.WriteLine(leksak);
// }

// string [] namn = {"Alex", "Andreas", "Vincent", "Mande", "Noah"};

// int [] numbers = { 1, 3, 5, 7, 10};


// for (int i = 0; i < stringArray.Length; i++)
// {
//     Console.WriteLine(namn[i] + " ger " + stringArray[i] + " betyget " + numbers[i]);
// }


List<string> cities = [];

string city = "";

Console.WriteLine("Vilken stad vil du välja?");
Console.WriteLine("Skriv exit ifall du vill lämna");

while (city != "exit")
{
    city = Console.ReadLine().ToLower();

    if (city != "exit")
    {
        cities.Add(city);
        Console.WriteLine("Skulle du vilja välja en ny stad?");
    }
}

Console.WriteLine("Dessa är dina städer");

foreach (string stad in cities)
{
    Console.WriteLine(stad);
}




Console.ReadLine();