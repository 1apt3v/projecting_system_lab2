namespace Tyuiu.IstominNM.Lab2.Review.V2.Lib;

public class DataService
{
    public double[][] GetMassFunction(int startStep, int stopStep)
    {
        int size = stopStep - startStep; 
        
        double[][] result = new double[size][]; 
        
        for (int x = startStep; x < stopStep; x++) 
        { 
            int index = x - startStep; 
            Console.WriteLine(index); 
            
            result[index] = new double[2];
            result[index][0] = x;  
            result[index][1] = Math.Pow(2, -x) + ((5 * Math.Pow(x, 2)) / (3 * Math.Pow(x, 3))) - Math.Cos(Math.Pow(x, 2)) + Math.Sin(2 * x); 
        } 

        return result; 
    }
}
