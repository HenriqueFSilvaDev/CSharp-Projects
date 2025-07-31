using System; 

class URI {

    int a,b,c;
    string[] input1;

    static void Main(string[] args) { 

        URI CalcDist = new URI();
        CalcDist.input1 = Console.ReadLine().Split(' ');

        DoTheCalc(CalcDist.input1, CalcDist);


    }

    public static void DoTheCalc(string[] input, URI CD){
        
        List<int> Lista = new List<int>{input[]};

        //CD.a = Convert.ToInt32(input[0]);
        //CD.b = Convert.ToInt32(input[2]);
        //CD.c = Convert.ToInt32(input[1]);

        //int result1 = ( (CD.a + CD.b+ CD.c + Math.Abs(CD.a - CD.b- CD.c)) / 2 );
        int result1 = Lista.Max();
        Console.WriteLine(result1);
    } 

}