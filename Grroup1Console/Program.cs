// See https://aka.ms/new-console-template for more information
Console.WriteLine("AAB College");

string Emri;
Emri="Leron";
Console.WriteLine("Leron");
Console.WriteLine(Emri);

int Numri;
Numri=100;

bool rezultati=false;

Console.WriteLine("1111------------------");
KalkuloLiberalizimin(rezultati);
Console.WriteLine("1111------------------");

//if (rezultati==true)
//{
//    Console.WriteLine("Urime liberalizimi!");
//}
//else
//{
//    Console.WriteLine("Na falni po ska liberalizim!");
//}

bool rezultati2 = false;


void KalkuloLiberalizimin(bool rezult)
{
    if (rezult == true)
    {
        Console.WriteLine("Urime liberalizimi!");
    }
    else
    {
        Console.WriteLine("Na falni po ska liberalizim!");
    }
}
Console.WriteLine("------------------");
KalkuloLiberalizimin(true);
Console.WriteLine("------------------");

Console.WriteLine("Metoda fillon ketu");

void ThuajTungjatjeta()
{
    Console.WriteLine("Tungjatjeta");
}

ThuajTungjatjeta();

Console.WriteLine("Metoda perfundon ketu");

int numri = 5;

int[] numrat = new[] { 1, 2, 3 };

foreach (int elementi in numrat)
{
    Console.WriteLine(elementi);
}

Console.ReadKey();
