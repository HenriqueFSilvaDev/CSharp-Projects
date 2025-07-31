using System; 

class URI {
    int dist_between = 0;
    
    static void Main(string[] args) { 
        
        URI CD = new URI();

        CD.dist_between = Convert.ToInt32(Console.ReadLine());

        Calculate_dist(CD.dist_between);
    }

    public static void Calculate_dist(int dist_between){
        string dist = Convert.ToString(dist_between * 2);
        Console.WriteLine(dist + " minutos");
    }

}