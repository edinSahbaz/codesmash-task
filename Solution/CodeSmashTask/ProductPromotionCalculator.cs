using System;

namespace CodeSmashTask;

public static class ProductPromotionCalculator
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
        int i = 0, j = 0, m = codeList.Count, n = shoppingCart.Count;

        while (i < m && j < n)
        {
            var group = codeList[i].Split(", ");
            var x = group[0];
            var k = j;
            for (int l = 0; l < group.Length && k < n; l++, k++)
            {
                if (group[l] != "anything" && group[l] != shoppingCart[k])
                {
                    break;
                }
            }

            if (k == j + group.Length)
            {
                j = k;
                i++;
            }
            else
            {
                j++;
            }
        }

        return i == m ? 1 : 0;
    }

    /*
    Time complexity:
    The time complexity of this code is O(nm) where "n" is the length of the codeList and "m" is the length of the shoppingCart.
    This is because the function iterates through both lists sequentially using nested loops. In the worst-case scenario, the
    function would have to iterate through every item in both lists, resulting in nm operations.

    Space complexity:
    The space complexity of this code is O(1). The function uses a constant amount of extra space to store
    variables i, j, m, n, group, x, k, and l. Therefore, the space used by the function does not increase with the size of the
    input lists.
     */
}

