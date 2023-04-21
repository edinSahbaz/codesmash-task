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
This code is a C# implementation of a function named "IsBuyerWinner" that takes two parameters: a List of strings named "codeList" and another List of strings named "shoppingCart". The purpose of this function is to determine if the items in the shopping cart match the items in the code list in the order they appear, and if so, return 1; otherwise, return 0.

The function first initializes four variables: codeListRef, shoppingCartRef, codeListLen, and shoppingCartLen. The variables "codeListRef" and "shoppingCartRef" are used as references to keep track of the position in the two lists as the function iterates through them, and "codeListLen" and "shoppingCartLen" are used to store the length of the two lists respectively.

The function then enters a while loop that runs until either the end of the "codeList" or the end of the "shoppingCart" is reached.

Within the while loop, the function uses a for loop to iterate over the items in each "codeList" entry. The "codeListArray" variable is used to split the "codeList" entry into individual items, and the "startingIndex" variable is used to keep track of the starting position in the "shoppingCart" for the current "codeList" entry.

The for loop compares each item in the "codeList" entry to the corresponding item in the "shoppingCart" starting at the "startingIndex" position. If any item does not match or if the end of the "shoppingCart" is reached before all items in the "codeList" entry have been checked, the for loop breaks.

If all items in the current "codeList" entry have been successfully matched in the "shoppingCart", the "shoppingCartRef" is updated to the position just after the last matched item, and the "codeListRef" is incremented to the next "codeList" entry. Otherwise, only the "shoppingCartRef" is incremented to try to find the next possible match.

After the while loop has completed, the function checks if the "codeListRef" has reached the end of the "codeList". If so, it returns 1, indicating a successful match. Otherwise, it returns 0, indicating no match was found.

### IMPORTANT NOTICE
Since the input format is not defined for codeList elements, we expect the input to be in the following format: a, b, c, d where a, b, c, d are the elements.
If the assumption about the format is wrong, the solution could easily be adjusted to the required format using String extension methods, etc.

## Time and Space complexity of our approach
* n - codeList 
* m - shoppingCart 
* k - comma separated string subset of set n

### Time complexity
Time complexity is `O(n•m•k)`.
Time complexity is O(n•m•k) because, in the worst-case scenario, every element of the shopping cart (m) will be compared to every element of a subset (k) of the code list (n).

### Space complexity
Space complexity is `O(k)`.
Space complexity is O(k), where k represents the biggest comma-separated string of values (Never bigger than that because at the end of the while loop all the memory will be deallocated).

## Testing
Tests provided in this solution are "split" into two groups. The first are examples provided in the task, and the second is our custom tests that cover some "edge" cases.
<img width="694" alt="Screenshot 2023-04-21 at 20 37 37" src="https://user-images.githubusercontent.com/47791892/233710922-ad164795-e449-467c-b4ef-4fbfc0ea4802.png">
