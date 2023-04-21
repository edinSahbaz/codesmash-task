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
        int codeListRef = 0;
        int shoppingCartRef = 0;
        int codeListLen = codeList.Count;
        int shoppingCartLen = shoppingCart.Count;

        while (codeListRef < codeListLen && shoppingCartRef < shoppingCartLen)
        {
            // Since input format is not defined we expect the input to be in the following format:
            // a, b, c, d 
            var codeListArray = codeList[codeListRef].Split(", ");
            var startingIndex = shoppingCartRef;

            for (int i = 0; i < codeListArray.Length && startingIndex < shoppingCartLen; i++, startingIndex++)
            {
                if (codeListArray[i] != "anything" && codeListArray[i] != shoppingCart[startingIndex])
                    break;
            }

            if (startingIndex == shoppingCartRef + codeListArray.Length)
            {
                shoppingCartRef = startingIndex;
                codeListRef++;
            }
            else
            {
                shoppingCartRef++;
            }
        }

        return codeListRef == codeListLen ? 1 : 0;
    }
}

