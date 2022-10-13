using Calculatrice;

namespace calculatriceTest;

[TestClass]
public class CalculatriceTest
{
    [TestMethod]
    [DataRow(10, 20, 30)]
    public void AdditionnerDeuxElements(int a, int b, int res)
    {
        var calculatrice = new Calculatrice();
        Assert.AreEqual(calculatrice.Add(a, b), res);
    }

    [TestMethod]
    [DataRow(30, 20, 10)]
    public void SoustraireDeuxElements(int a, int b, int res)
    {
        var calculatrice = new Calculatrice();
        Assert.AreEqual(calculatrice.Sub(a, b), res);
    }

    [TestMethod]
    [DataRow(6, 2, 3)]
    public void DiviserDeuxElements(int a, int b, int res)
    {
        var calculatrice = new Calculatrice();
        Assert.AreEqual(calculatrice.Div(a, b), res);
    }

    [TestMethod]
    [DataRow(3, 2, 6)]
    public void MultiplierDeuxElements(int a, int b, int res)
    {
        var calculatrice = new Calculatrice();
        Assert.AreEqual(calculatrice.Mul(a, b), res);
    }


    [TestMethod]
    [ExpectedException(typeof(Exception))]
    [DataRow(-3, 2)]
    public void MultiplierDeuxElementsNegatifs(int a, int b)
    {
        var calculatrice = new Calculatrice();
        calculatrice.Mul(a, b);
    }

    [TestMethod]
    [DataRow(6, 0)]
    [ExpectedException(typeof(DivideByZeroException))]
    public void DiviserDeuxElementsAvecZero(int a, int b)
    {
        var calculatrice = new Calculatrice();
        calculatrice.Div(a, b);
        //Assert.ThrowsException < DivideByZeroException>(() => a / b);
    }

}
