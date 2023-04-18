using System;
using System.Collections.Generic;

namespace CodeSmashTask;

class Program
{
    static void Main(string[] args)
    {
        int codeListCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> codeList = new List<string>();

        for (int i = 0; i < codeListCount; i++)
        {
            string codeListItem = Console.ReadLine();
            codeList.Add(codeListItem);
        }

        int shoppingCartCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> shoppingCart = new List<string>();

        for (int i = 0; i < shoppingCartCount; i++)
        {
            string shoppingCartItem = Console.ReadLine();
            shoppingCart.Add(shoppingCartItem);
        }

        int foo = Foo.IsBuyerWinner(codeList, shoppingCart);

        Console.WriteLine(foo);
    }
}

public class Foo
{
    /*
     * Complete the 'IsBuyerWinner' function below.
     *
     * The function is expected to return an Integer.
     * The function accepts following parameters:
     *  1. List (STRING_ARRAY) - codeList
     *  2. List (STRING_ARRAY) - shoppingCart
     */

    public static int IsBuyerWinner(List<string> codeList, List<string> shoppingCart)
    {
        return 0;
    }
}
