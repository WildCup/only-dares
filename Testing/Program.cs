double start1 = 80;
double start2 = 15;
double start3 = 5;
double start4 = 0;
double start5 = 0;

double lvl1 = 80;
double lvl2 = 15;
double lvl3 = 5;
double lvl4 = 0;
double lvl5 = 0;

/*
for (int done = 1; done < 200; done++)
{
    print(done - 1);

    lvl1 = Math.Clamp(start1 - done, 0, 100);
    if (lvl1 > 0)
    {
        lvl2 = Math.Clamp(start2 + 0.8f * done, 0, 80);
        lvl3 = Math.Clamp(start3 + 0.15f * done, 0, 100);
        lvl4 = Math.Clamp(start4 + 0.04f * done, 0, 100);
        lvl5 = Math.Clamp(start5 + 0.01f * done, 0, 100);
        continue;
    }

    lvl2 = Math.Clamp(start1 * 2 - done, 0, 100);

    if (lvl2 > 0)
    {
        lvl3 = Math.Clamp(start3 + 0.7f * done, 0, 15f);
        lvl4 = Math.Clamp(start4 + 0.25f * done, 0, 35);
        lvl5 = Math.Clamp(start5 + 0.05f * done, 0, 50);
        continue;
    }

    lvl3 = Math.Clamp(start3 + 0.7f * done, 15f, 85f);
    lvl4 = Math.Clamp(start4 + 0.25f * done, 0, 35);
    lvl5 = Math.Clamp(start5 + 0.05f * done, 0, 50);

    // lvl1 = Math.Clamp(start1 - done, 0, 80);
    // lvl2 = Math.Clamp(start2 + (start1 / 100) * done, 0, 80);
    // lvl3 = Math.Clamp(start3 + (lvl2 / 100) * done, 0, 80f);
    // lvl4 = Math.Clamp(start4 + (lvl3 / 100) * done, 0, 80);
    // lvl5 = Math.Clamp(start5 + (lvl4 / 100) * done, 0, 80);
}
*/

print2(0);

for (int done = 0; done < 100; done += 10)
{
    var last5 = lvl5;
    lvl5 += lvl4 / 10;
    lvl4 += lvl3 / 10;
    lvl3 += lvl2 / 10;
    lvl2 += lvl1 / 10;
    lvl1 -= 10 - last5 / 10;

    print2(done + 10);
}


void print(int i)
{
    Console.WriteLine($"{i.ToString("000")}:    {lvl1.ToString("00.00")}%   {lvl2.ToString("00.00")}%   {lvl3.ToString("00.00")}%   {lvl4.ToString("00.00")}%   {lvl5.ToString("00.00")}%                               total: {lvl1 + lvl2 + lvl3 + lvl4 + lvl5}");
}
void print2(int i)
{
    string s = i + "";
    if (i < 10) s += " ";
    if (i < 100) s += " ";
    s += ":\t";
    Console.WriteLine($"{i}:\t\t{lvl1.ToString("0.###")}%\t\t{lvl2.ToString("0.###")}%\t\t{lvl3.ToString("0.###")}%\t\t{lvl4.ToString("0.###")}%\t\t{lvl5.ToString("0.###")}%\t\ttotal: {lvl1 + lvl2 + lvl3 + lvl4 + lvl5}");
}

/*
0   ->    80  15  5    0.0   0.00
10  ->    70  20  9    1.0   0.00
20  ->    60  25  13   2.0   0.10
30  ->    50  30  17   3.0   0.20
40  ->    40  35  21   4.0   0.30
50  ->    30  40  25   5.0   0.40
60  ->    20  45  29   6.0   0.50
70  ->    10  50  23   7.0   0.60
80  ->    0   50  23   8.0   0.70
90  ->    0   50  23   0.0   0.00
100 ->    0   50  23   0.0   0.00
*/