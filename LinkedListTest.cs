using Xunit;

namespace Project2.Test
{
  public class LinkedListTest
  {
    [Fact]
    public void TestMysteryLength0()
    {
      var list = new LinkedList();
      list.MysteryOperation();
      Assert.Equal(new int[0], list.ToArray());
    }

    [Fact]
    public void TestMysteryLength1()
    {
      var list = new LinkedList();
      list.AddFront(1);
      list.MysteryOperation();
      Assert.Equal(new int[] { 1 }, list.ToArray());
    }

    [Fact]
    public void TestMysteryLength2()
    {
      var list = new LinkedList();
      list.AddFront(2);
      list.AddFront(1);
      list.MysteryOperation();
      Assert.Equal(new int[] { 2, 1 }, list.ToArray());
    }

    [Fact]
    public void TestMysteryLength3()
    {
      var list = new LinkedList();
      list.AddFront(3);
      list.AddFront(2);
      list.AddFront(1);
      list.MysteryOperation();
      Assert.Equal(new int[] { 3, 2, 1 }, list.ToArray());
    }

    [Fact]
    public void TestLengthEmpty()
    {
      var list = new LinkedList();
      Assert.Equal(0, list.Length);
    }

    [Fact]
    public void TestLength1()
    {
      var list = new LinkedList();
      list.AddFront(42);
      Assert.Equal(1, list.Length);
    }

    [Fact]
    public void TestLength2()
    {
      var list = new LinkedList();
      list.AddFront(42);
      list.AddFront(56);
      Assert.Equal(2, list.Length);
    }

    [Fact]
    public void TestAddFrontEmptyList()
    {
      var list = new LinkedList();
      list.AddFront(45);
      Assert.Equal(45, list.GetElementAt(0));
    }

    [Fact]
    public void TestAddFrontWithElement()
    {
      var list = new LinkedList();
      list.AddFront(45);
      list.AddFront(56);
      Assert.Equal(56, list.GetElementAt(0));
      Assert.Equal(45, list.GetElementAt(1));
    }

    [Fact]
    public void TestAddBackEmptyList()
    {
      var list = new LinkedList();
      list.AddBack(45);
      Assert.Equal(45, list.GetElementAt(0));
    }

    [Fact]
    public void TestAddBackWithElement()
    {
      var list = new LinkedList();
      list.AddBack(45);
      list.AddBack(56);
      Assert.Equal(45, list.GetElementAt(0));
      Assert.Equal(56, list.GetElementAt(1));
    }

    [Fact]
    public void TestAddBackWithMultipleElements()
    {
      var list = new LinkedList();
      list.AddBack(45);
      list.AddBack(56);
      list.AddBack(64);
      Assert.Equal(45, list.GetElementAt(0));
      Assert.Equal(56, list.GetElementAt(1));
      Assert.Equal(64, list.GetElementAt(2));
    }

    [Fact]
    public void TestGetElementAtNegativeIndexEmptyList()
    {
      var list = new LinkedList();
      Assert.Throws<NoSuchElementException>(() => list.GetElementAt(-1));
    }

    [Fact]
    public void TestGetElementAtNegativeIndexSingleItem()
    {
      var list = new LinkedList();
      list.AddFront(42);
      Assert.Throws<NoSuchElementException>(() => list.GetElementAt(-1));
    }

    [Fact]
    public void TestGetElementAt0IndexEmpty()
    {
      var list = new LinkedList();
      Assert.Throws<NoSuchElementException>(() => list.GetElementAt(0));
    }
    [Fact]
    public void TestGetElementAt1IndexEmpty()
    {
      var list = new LinkedList();
      Assert.Throws<NoSuchElementException>(() => list.GetElementAt(1));
    }

    [Fact]
    public void TestGetElementAt1IndexOneItem()
    {
      var list = new LinkedList();
      list.AddFront(42);
      Assert.Throws<NoSuchElementException>(() => list.GetElementAt(1));
    }
  }
}
