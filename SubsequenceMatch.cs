public class Solution {
    public bool IsSubsequence(string s, string t) {
        int m = s.Length;
        int n = t.Length;
        int j =0;
        if(m>n)
            return false;
        else
        {
            for(int i =0;i<n && j<m;i++)
            {
                if(s[j] == t[i])
                    j++;
            }
            if(j==m)
                return true;
            
            return false;
        }
    }
}