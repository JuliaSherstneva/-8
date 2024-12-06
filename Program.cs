// Найти 100 первых простых чисел.


int C = 0;
for (int a = 2; C <= 100; a++)
{
    bool CH = true;
    for (int b = 2; b <= Math.Sqrt(a); b++)
    {
        if (a % b == 0) CH = false;
    }
    if (CH)
    {
        Console.Write(a + " ");
        C++;
    }
}
Console.ReadKey();