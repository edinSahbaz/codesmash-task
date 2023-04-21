namespace CodeSmashTask.Test;
using CodeSmashTask;

public class SolutionTest
{
    #region Given Examples Tests
    [Fact]
    public void IsBuyerWinner_Example1()
    {
        var codeList = new List<string>();
        codeList.Add("apple, apple");
        codeList.Add("banana, anything, banana");

        var shoppingCart = new List<string>();
        shoppingCart.Add("orange");
        shoppingCart.Add("apple");
        shoppingCart.Add("apple");
        shoppingCart.Add("banana");
        shoppingCart.Add("orange");
        shoppingCart.Add("banana");

        int expected = 1;
        int actual = CodeSmashTask.ProductPromotionCalculator.IsBuyerWinner(codeList, shoppingCart);
         
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void IsBuyerWinner_Example2()
    {
        var codeList = new List<string>();
        codeList.Add("apple, apple");
        codeList.Add("banana, anything, banana");

        var shoppingCart = new List<string>();
        shoppingCart.Add("banana");
        shoppingCart.Add("orange");
        shoppingCart.Add("banana");
        shoppingCart.Add("apple");
        shoppingCart.Add("apple");

        int expected = 0;
        int actual = CodeSmashTask.ProductPromotionCalculator.IsBuyerWinner(codeList, shoppingCart);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void IsBuyerWinner_Example3()
    {
        var codeList = new List<string>();
        codeList.Add("apple, apple");
        codeList.Add("banana, anything, banana");

        var shoppingCart = new List<string>();
        shoppingCart.Add("apple");
        shoppingCart.Add("banana");
        shoppingCart.Add("apple");
        shoppingCart.Add("banana");
        shoppingCart.Add("orange");
        shoppingCart.Add("banana");

        int expected = 0;
        int actual = CodeSmashTask.ProductPromotionCalculator.IsBuyerWinner(codeList, shoppingCart);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void IsBuyerWinner_Example4()
    {
        var codeList = new List<string>();
        codeList.Add("apple, apple");
        codeList.Add("apple, apple, banana");

        var shoppingCart = new List<string>();
        shoppingCart.Add("apple");
        shoppingCart.Add("apple");
        shoppingCart.Add("apple");
        shoppingCart.Add("banana");

        int expected = 0;
        int actual = CodeSmashTask.ProductPromotionCalculator.IsBuyerWinner(codeList, shoppingCart);

        Assert.Equal(expected, actual);
    }
    #endregion

    [Fact]
    public void IsBuyerWinner_Example4Modified()
    {
        var codeList = new List<string>();
        codeList.Add("apple, apple");
        codeList.Add("apple, apple, banana");

        var shoppingCart = new List<string>();
        shoppingCart.Add("apple");
        shoppingCart.Add("apple");
        shoppingCart.Add("apple");
        shoppingCart.Add("apple");
        shoppingCart.Add("banana");

        int expected = 1;
        int actual = CodeSmashTask.ProductPromotionCalculator.IsBuyerWinner(codeList, shoppingCart);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void IsBuyerWinner_WithEmptyCodeList()
    {
        var codeList = new List<string>();

        var shoppingCart = new List<string>();
        shoppingCart.Add("apple");
        shoppingCart.Add("orange");
        shoppingCart.Add("banana");
        shoppingCart.Add("apple");

        int expected = 1;
        int actual = CodeSmashTask.ProductPromotionCalculator.IsBuyerWinner(codeList, shoppingCart);

        Assert.Equal(expected, actual);
    }
}

