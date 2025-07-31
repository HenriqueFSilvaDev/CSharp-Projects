using System; 

class URI {
    public int x;
    public double y;
    
    
    
    
    static void Main(string[] args) { 
        URI KMClass = new URI();
        
        KMClass.x  = Convert.ToInt32(Console.ReadLine());   
        KMClass.y  = Convert.ToDouble(Console.ReadLine());
        KM_Gastos(KMClass.x ,KMClass.y);
        
    }
    
    public static void KM_Gastos(int xx, double yy){
        double result = xx / yy;
        string resultstr = (Convert.ToString(result.ToString("N3")) + " km/l");
        Console.WriteLine(resultstr);
    }

}