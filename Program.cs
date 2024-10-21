List<string> szamok = new();
using StreamReader sr = new(
    path: @"../../../src/szamok.txt",
    encoding: System.Text.Encoding.UTF8);
while (!sr.EndOfStream) szamok.Add(sr.ReadLine());
//foreach (var i in szamok) Console.WriteLine((double.Parse(i) % 2 == 0) ? $"{i} oszható kettővel" : $"{i} nem osztható kettővel");
List<int> Osztok = new() {3, 7, 13, 19, 3119 };
bool relativ;
int counter = 0;
foreach (var szam in szamok)
{
    relativ = true;
    for (double i = 1; i <= 5; i++)
    {
        if (double.Parse(szam) % Math.Pow(3, i) == 0) relativ = false;
    }
    if (relativ && double.Parse(szam) % 7 == 0) relativ = false;
    if (relativ && double.Parse(szam) % 13 == 0) relativ = false;
    if (relativ && double.Parse(szam) % 19 == 0) relativ = false;
    if (relativ && double.Parse(szam) % 3119 == 0) relativ = false;
    if(relativ) counter++;
}
Console.WriteLine($"A 1310438493 relatív prímeinek száma: {counter}");
Console.WriteLine("2. feladat");
counter = 0;
List<int> szamjegyDB = new() {3, 2, 2, 2, 1};
int egy;
int ketto;
int harom;
int negy;
int ot;
foreach (var szam in szamok)
{
    egy = 0;
    ketto = 0;
    harom = 0;
    negy = 0;
    ot = 0;
    if (!szam.Equals("2354211341"))
    {
        for (int i = 0; i < szam.Length; i++)
        {
            switch (szam[i])
            {
                case '1':
                    egy++;
                    break;
                case '2':
                    ketto++;
                    break;
                case '3':
                    harom++;
                    break;
                case '4':
                    negy++;
                    break;
                case '5':
                    ot++;
                    break;
                default:
                    break;
            }
        }
        if(egy == szamjegyDB[0] && ketto == szamjegyDB[1] && harom == szamjegyDB[2] && negy == szamjegyDB[3] && ot == szamjegyDB[4]) counter++;
    }
}
Console.WriteLine($"A 2354211341 anagrammáinak száma: {counter}");
Console.WriteLine("3. feladat");
Dictionary<string, int> Ketjegyu = new();
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 5; j++) Ketjegyu.Add(i.ToString()+j.ToString(), 0);
}
foreach (var szam in szamok)
{
    for (int i = 0; i < szam.Length - 1; i++)  Ketjegyu[szam.Substring(i, 2)] = Ketjegyu[szam.Substring(i, 2)] + 1;
}
Console.WriteLine($"A legtöbbet szereplő kétjegyű szám a {Ketjegyu.OrderByDescending(x => x.Value).First().Key}, amiből {Ketjegyu.OrderByDescending(x => x.Value).First().Value} db van");
//foreach (var jegy in Ketjegyu.OrderByDescending(x => x.Value))
//{
//    Console.WriteLine(jegy);
//}