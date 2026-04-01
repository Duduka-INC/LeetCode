namespace LeetCode.SlidingWindows;

public class LongestSubstringWithoutRepeatingCharacters
{
    public int Solve(string s)
    {
        var left = 0;

        var uniqueChars = new Dictionary<char, int>();

        var result = 0; 
        
        for (int right = 0; right < s.Length; right++)
        {
            var c = s[right];
            if (uniqueChars.ContainsKey(c) && uniqueChars[c] <= right && uniqueChars[c] >= left)
            {
                var lastIndex = uniqueChars[c];

                uniqueChars[c] = right;
                left = lastIndex + 1;
            }
            else
            {
                uniqueChars[c] = right;
            }
            
            result = int.Max(result, right - left + 1);
        }
        
        return result;
    }
}