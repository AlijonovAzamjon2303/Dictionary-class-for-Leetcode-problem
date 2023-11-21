public class Solution
{
    public int CountNicePairs(int[] nums)
    {
        long  ans = 0, mod = 1000000007;
        for (int i = 0; i < nums.Length; i++)
            nums[i] -= rev(nums[i]);
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(nums[i]))
                dic[nums[i]]++;
            else dic[nums[i] = 1;
        }
        foreach (var val in dic.Values)
        {
            ans += (val * (val - 1) / 2 % mod);
            ans = ans % mod;
        }
        return (int)ans;
    }
    public int rev(int n)
    {
        int ans = 0;
        while (n > 0)
        {
            ans = ans * 10 + n % 10;
            n /= 10;
        }
        return ans;
    }
}