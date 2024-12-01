namespace Tyuiu.IstominNM.Lab2.Review.V2.Test;
using Tyuiu.IstominNM.Lab2.Review.V2.Lib;

public class DataServiceTest
{
    [Fact]
    public void CheckGetMassFunction()
    {
        DataService ds = new DataService();

        int startStep = 1;
        int stopStep = 5;

        double[][] result = ds.GetMassFunction(startStep, stopStep);

        double[][] true_value = [[1, 2.5356617876242087],[2, 0.980174458889017], [3, 1.3122703192413065], [4, 2.426184393613433]];

        Assert.Equal(true_value, result);

    }
}