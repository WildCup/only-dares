
namespace DaresGacha;

public class Calculator
{
    public static double[] GetProbability(int done)
    {
        //chance for difficulty level jump, tie, slap, kiss, sex
        //every 10 dares increase difficulty
        var list = new double[,]
        {
                {80,    15,      2,      0,      0},     //start
                {70,    23.2,    3.5,    0.3,    0},     //-10   +8.2 +1.5  +0.3
                {57,    30,      8,      1,      0.0},   //-13   +7.8 +4.5  +0.7
                {29.7,  45,      18,     3,      0.3},   //-27.3 +15  +10   +2   +0.3
                {0,     52,      40.5,   10,     1.5},   //-29.7 +7   +22.5 +7   +1.2
                {0,     6,       50,     38,     6},     //-0    -46  +9.5  +28  +4.5
                {0,     0,       20,     60,     20},    //-0    -6  -30   +22  +14
                {0,     0,       0,      20,     80},    //-0    -0  -20   -40  +60
        };

        int i = Math.Min(list.Length, (int)(done / 10));
        return Enumerable.Range(0, list.GetLength(1))
            .Select(x => list[i, x])
            .ToArray();
    }

    public static int GetLvl(double[] probability)
    {
        //sum probabilities 
        var chance = new double[probability.Length];
        probability.CopyTo(chance, 0);
        for (int i = 1; i < chance.Length; i++)
            chance[i] += chance[i - 1];

        int random = new Random().Next(0, 100);

        for (int j = 0; j < chance.Length; j++)
            if (random <= chance[j]) return j;

        return chance.Length - 1;
    }
}
