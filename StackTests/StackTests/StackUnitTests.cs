namespace StackTests;

[TestClass]
public class StackUnitTests
{
    private Stack _stack;

    public StackUnitTests()
    {
        _stack = new Stack();
    }

    [TestMethod]
    public void CreateStackIsEmpty()
    {
        Assert.IsTrue(_stack.IsEmpty());
    }

    [TestMethod]
    public void AfterOnePushStackIsNotEmpty()
    {
        _stack.Push(0);
        Assert.IsFalse(_stack.IsEmpty());
    }

    [TestMethod]
    public void AfterPopOnEmptyStack_WillThrowUnderflowException()
    {
        Assert.IsTrue(_stack.IsEmpty());
        Assert.ThrowsException<Stack.UnderflowException>(() => _stack.Pop());
    }

    [TestMethod]
    public void AfterOnePushAndOnePopWillBeEmpty()
    {
        _stack.Push(0);
        _stack.Pop();
        Assert.IsTrue(_stack.IsEmpty());
    }

    [TestMethod]
    public void AfterTwoPushesAndOnePop_WillNotBeEmpty()
    {
        _stack.Push(1);
        _stack.Push(2);
        _stack.Pop();
        Assert.IsFalse(_stack.IsEmpty());
    }

    [TestMethod]
    [DataRow(12)]
    [DataRow(10)]
    public void AfterPushingX_FirstElementIsX(int number)
    {
        _stack.Push(number);
        Assert.AreEqual(_stack.valeurs.FirstOrDefault(), number);
    }

    [TestMethod]
    [DataRow(5)]
    [DataRow(9)]
    public void AfterPushingX_WillPopX(int number)
    {
        _stack.Push(number);
        _stack.Pop();
        Assert.AreEqual(0, _stack.valeurs.Count);
    }
}
