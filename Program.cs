using System.Text;
using Varosok;

List<Nagyvaros> nagyvaros = [];

using (StreamReader sr = new StreamReader(@"..\..\..\src\varosok.csv", Encoding.UTF8))
{
    while (!sr.EndOfStream)
    {
        nagyvaros.Add(new Nagyvaros(sr.ReadLine()));
    }
}

//1. Feladat:
Console.WriteLine($"Kína összes lakosa: {nagyvaros.Where(x => x.Orszag == "Kína").Sum(x => x.Nepesseg):F0} fő \n");

//2. Feladat:
Console.WriteLine($"India átlag lélekszáma: {nagyvaros.Where(x => x.Orszag == "India").Average(x => x.Nepesseg):F0}\n");

//3. Feladat:
var legnepesebb = nagyvaros.OrderByDescending(x => x.Nepesseg).First();

Console.WriteLine($"A legnépesebb város: {legnepesebb}\n");

//4. Feladat:
Console.WriteLine("20 Millió feletti lakossággal rendelkező országok, csökkenő sorrendben: ");

foreach (var orszag in nagyvaros.Where(x => x.Nepesseg > 20000000).OrderByDescending(x => x.Nepesseg))
{
    Console.WriteLine(orszag);
}

//5. Feladat:

Console.WriteLine($"Országok több nagyvárossal: {nagyvaros.GroupBy(x => x.Orszag).Where(x => x.Count() > 1).Count()}\n");

//6. Feladat:
var legtobb = nagyvaros.GroupBy(x => x.Varos[0]).OrderByDescending(x => x.Count()).First();

Console.WriteLine($"A legtöbb város egy kezdőbetűvel: {legtobb.Key}");