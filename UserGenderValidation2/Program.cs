// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Markus!");

//rakendus küsib kasutajalt valida tema sugu (m/f)
//rakendus küsib kasutajalt sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//welcome, Mr. (kasutaja perekonnanimi) / Welcome, ms. (kasutaja perekonnanimi)

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //Loeb konsoolist maha andmeid string (sõne) formaadis

Console.WriteLine("Please enter your last name:") ;
string userLastName = Console.ReadLine();

if(userGender == 'm') 
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if(userGender == 'f') 
{
    Console.WriteLine($"Welcome Ms. {userLastName}!");
}
else 
{
    Console.WriteLine($"Welcome, {userLastName}!");
}

