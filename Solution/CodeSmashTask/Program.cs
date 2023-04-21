using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodeSmashTask;

class Program
{
    static void Main(string[] args) { 
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

        int result = ProductPromotionCalculator.IsBuyerWinner(codeList, shoppingCart);

        Console.WriteLine(result);
    }
}
