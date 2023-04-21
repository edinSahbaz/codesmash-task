namespace CodeSmashTask.Test;
using CodeSmashTask;

public class SolutionTest
{
    #region Given Examples Tests
    [Fact]
    public void IsBuyerWinner_Example1()
    {
        var codeList = new List<string> { "apple, apple", "banana, anything, banana" };
        var shoppingCart = new List<string>{ "orange", "apple", "apple", "banana", "orange", "banana" };

        int actual = CodeSmashTask.ProductPromotionCalculator.IsBuyerWinner(codeList, shoppingCart);
         
        Assert.Equal(1, actual);
    }

    [Fact]
    public void IsBuyerWinner_Example2()
    {
        var codeList = new List<string> { "apple, apple", "banana, anything, banana" };
        var shoppingCart = new List<string> { "banana", "orange", "banana", "apple", "apple" };

        int actual = CodeSmashTask.ProductPromotionCalculator.IsBuyerWinner(codeList, shoppingCart);

        Assert.Equal(0, actual);
    }

    [Fact]
    public void IsBuyerWinner_Example3()
    {
        var codeList = new List<string> { "apple, apple", "banana, anything, banana" };
        var shoppingCart = new List<string> { "apple", "banana", "apple", "banana", "orange", "banana" };

        int actual = CodeSmashTask.ProductPromotionCalculator.IsBuyerWinner(codeList, shoppingCart);

        Assert.Equal(0, actual);
    }

    [Fact]
    public void IsBuyerWinner_Example4()
    {
        var codeList = new List<string> { "apple, apple", "apple, apple, banana" };
        var shoppingCart = new List<string> { "apple", "apple", "apple", "banana" };

        int actual = CodeSmashTask.ProductPromotionCalculator.IsBuyerWinner(codeList, shoppingCart);

        Assert.Equal(0, actual);
    }
    #endregion

    [Fact]
    public void IsBuyerWinner_Example4Modified()
    {
        var codeList = new List<string> { "apple, apple", "apple, apple, banana" };
        var shoppingCart = new List<string> { "apple", "apple" , "apple", "apple", "banana" };

        int actual = CodeSmashTask.ProductPromotionCalculator.IsBuyerWinner(codeList, shoppingCart);

        Assert.Equal(1, actual);
    }

    [Fact]
    public void IsBuyerWinner_WithEmptyCodeList()
    {
        var codeList = new List<string>();
        var shoppingCart = new List<string> { "apple", "orange", "banana", "apple" };

        int actual = CodeSmashTask.ProductPromotionCalculator.IsBuyerWinner(codeList, shoppingCart);

        Assert.Equal(1, actual);
    }

    [Fact]
    public void IsBuyerWinner_WithEmptyShoppingCart()
    {
        var codeList = new List<string> { "apple, apple", "apple, apple, banana" };
        var shoppingCart = new List<string> ();

        int actual = CodeSmashTask.ProductPromotionCalculator.IsBuyerWinner(codeList, shoppingCart);

        Assert.Equal(0, actual);
    }
}

