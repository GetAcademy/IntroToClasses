namespace IntroToClasses
{
    internal class Intro
    {
        public static void Run()
        {
            /*
    JavaScript: 
    let terje = {
        name: 'Terje',
        birthYear: 1975,
    };

    let terje = {};
    terje.name = 'Terje';
    terje.birthYear = 1975;
 */


            //var terje1 = new Person
            //{
            //    Name = "Terje",
            //    BirthYear = 1975,
            //};

            //var terje2 = new Person();
            //terje2.Name = "Terje";
            //terje2.BirthYear = 1975;

            /*
                JavaScript: 
                let people = [
                    {
                        name: 'Terje',
                        birthYear: 1975,
                    },
                    {
                        name: 'Per',
                        birthYear: 1976,
                    },
                ];
             */

            //var people1 = new Person[]
            //{
            //    new Person
            //    {
            //        Name = "Terje",
            //        BirthYear = 1975,
            //    },
            //    new Person
            //    {
            //        Name = "Per",
            //        BirthYear = 1976,
            //    },
            //};

            //var people2 = new Person[2];
            //people1[0] = new Person
            //{
            //    Name = "Terje",
            //    BirthYear = 1975,
            //};
            //people1[1] = new Person
            //{
            //    Name = "Per",
            //    BirthYear = 1976,
            //};

            /*
                JavaScript: 
                let model = {
                    currentUser: 'terje',
                    someNumber: 17,
                    people: [
                        {
                            name: 'Terje',
                            birthYear: 1975,
                        },
                        {
                            name: 'Per',
                            birthYear: 1976,
                        },
                    ]
                };
             */

            var m2 = new Model();
            Console.WriteLine(m2.People);

            m2.People = new Person[10];
            //m2.People[0] = ...

            //var model = new Model
            //{
            //    CurrentUser = "Terje",
            //    SomeNumber = 17,
            //    People = new Person[]
            //    {
            //        new Person
            //        {
            //            Name = "Terje",
            //            BirthYear = 1975,
            //        },
            //        new Person
            //        {
            //            Name = "Per",
            //            BirthYear = 1976,
            //        },
            //    },
            //};


        }
    }
}
