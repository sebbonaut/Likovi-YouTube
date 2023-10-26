using Likovi;



/* Lik[] likovi =
{
    new Kvadrat(3),
    new Pravokutnik(2.1,4),
    new Krug(4)
};
IspisPodataka(likovi); */

static void IspisPodataka(params Lik[] likovi)
{
    foreach (Lik lik in likovi)
    {
        string info = String.Format("{0} povrsine {1} cm^2" +
            " i opsega {2} cm",
            lik.Info,
            Math.Round(lik.Povrsina(),2),
            Math.Round(lik.Opseg(),2));
        Console.WriteLine(info);
    }
}

Stog stog = new Stog();
stog.Push(new Kvadrat(3));
stog.Push(new Krug(5));
stog.Push(new Pravokutnik(2, 3));
StogIspis(stog);
Console.WriteLine(stog.JelPrazan);
StogIspis(stog);
Console.WriteLine(stog.ToString());

Stog intovi = new Stog();
intovi.Push("abc"); //moze i nesto drugo osim intova
intovi.Push(12);
double br = (int)intovi.Top;
//double br = (double)(int)intovi.Top;
Console.WriteLine(12);
StogIspis(intovi);

int broj = 20;
object box = broj;
broj++;
Console.WriteLine($"{broj}, {box}");

Lista lista = new Lista(new object[]
{
    new Kvadrat(1),
    new Krug(3.2),
    new Pravokutnik(5,2.6)
});

Console.WriteLine("Ispis elemenata liste:");
for(Lista.Iterator it = lista.Begin; it != lista.End; it++)
{
    IspisPodataka((Lik)it.Element);
}

static void StogIspis(Stog stog)
{
    Console.WriteLine("Ispis podataka o " +
        "elementima na stogu:");
    Stog pomocni = new Stog();
    while(!stog.JelPrazan)
    {
        //IspisPodataka((Lik)stog.Top);
        Console.WriteLine(stog.Top);
        pomocni.Push(stog.Top);
        stog.Pop();
    }
    while (!pomocni.JelPrazan)
    {
        stog.Push(pomocni.Top);
        pomocni.Pop();
    }
}