using System.Runtime.InteropServices;
using IntroToClasses;

var clickers = new Clicker[]
{
    new Clicker('A'),
    new Clicker('B'),
    new Clicker('C'),
};

while (true)
{
    Console.Clear();
    foreach (var clicker in clickers)
    {
        clicker.Show();
    }

    Console.Write("Hvilken klikker vil du klikke? ");
    var answer = Console.ReadLine();
    var character = answer[0];
    foreach (var clicker in clickers)
    {
        if (clicker.Character == character)
        {
            clicker.Click();
        }
    }
}



/*
 *
 *
 * 1: Oversette direkte fra JavaScript
 *    Klasse for hver type objekt
 * 2: Metoder i klasser
 * 3: Innkapsling
 * 4: Constructor
 * 5: Properties
 * 6: Objektorientert tenkning
 */

//var p1 = new PersonV2("Terje", 1975);
////p1.BirthYear = 2000;
//if (p1.BirthYear == 1975)
//    //if (p1.GetBirthYear() == 1975)
//{
//    Console.WriteLine("hurra");
//}
//else
//{
//    Console.WriteLine("huff");
//}

////Intro.Run();
//var p1 = new Person("Terje", 1975);
////p1.Init("Terje", 1975);
//p1.Show();

//var p2 = new Person("Tarje", 1976);
////p2.Init("Tarje", 1976 );
//p2.Show();

//var p3 = new Person(2000);

//var age = p2.GetAge();