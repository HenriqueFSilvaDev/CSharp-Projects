using System;

class URI
{
    double x, xx, y, yy;
    string xy, xxyy;

    static void Main(string[] args)
    {
        URI CDist = new URI();

        CDist.xy = Console.ReadLine();
        CDist.xxyy = Console.ReadLine();

        string[] input1 = CDist.xy.Split(' ');
        string[] input2 = CDist.xxyy.Split(' ');

        CDist.x = Convert.ToDouble(input1[0]);
        CDist.y = Convert.ToDouble(input1[1]);
        CDist.xx = Convert.ToDouble(input2[0]);
        CDist.yy = Convert.ToDouble(input2[1]);

        CalcDist(CDist.x, CDist.y, CDist.xx, CDist.yy);
    }

    public static void CalcDist(double x, double y, double xx, double yy)
    {
        double result =  Math.Sqrt(Math.Pow( (xx - x) , 2) + Math.Pow( (yy - y), 2));
        Console.WriteLine(Math.Round(result, 4));
    }
}