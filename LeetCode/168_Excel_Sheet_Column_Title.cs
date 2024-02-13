public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        string result = "";

        while (columnNumber > 0)
        {
            --columnNumber;
            int remainder = columnNumber % 26;
            result = (char)((int)'A' + remainder) + result;
            columnNumber /= 26;
        }

        return result;
    }
}