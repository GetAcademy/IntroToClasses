using IntroToClasses;

/*
 *
 * Pause til 13:35
 *
 * 1: Oversette direkte fra JavaScript
 *    Klasse for hver type objekt
 * 2: Metoder i klasser
 * 3: Innkapsling
 * 4: Constructor
 *
 * : Properties
 */


//Intro.Run();
var p1 = new Person("Terje", 1975);
//p1.Init("Terje", 1975);
p1.Show();

var p2 = new Person("Tarje", 1976);
//p2.Init("Tarje", 1976 );
p2.Show();

var p3 = new Person(2000);

var age = p2.GetAge();