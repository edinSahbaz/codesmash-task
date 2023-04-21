# TASK: Company Product Promotion

## Solution

``` cs
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
```
## Explanation of algorithm


## Time and Space complexity of our approach
* n - codeList 
* m - shoppingCart 
* k - comma separated string subset of set n

### Time complexity
Time complexity is `O(n•m•k)`.
Time complexity is O(n•m•k) because in the worst case scenario every element of shopping cart (m) will be compared to every element of a subset (k) of code list (n).

### Space complexity
Space complexity is `O(k)`.
Space complexity is O(k), where k represents the biggest comma separated string of values (Never bigger than that because on the end of while loop all the memory will be deallocated).

## Testing
Tests provided in this solution are "split" in two groups. First is examples provided in the task, and the second is our custom tests that cover some "edge" cases.

<img width="694" alt="Screenshot 2023-04-21 at 20 37 37" src="https://user-images.githubusercontent.com/47791892/233710922-ad164795-e449-467c-b4ef-4fbfc0ea4802.png">
