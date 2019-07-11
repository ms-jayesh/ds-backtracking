/* A message containing letters from A-Z is being encoded to numbers using the following mapping:

'A' -> 1
'B' -> 2
...
'Z' -> 26
Given an encoded message containing digits, determine the total number of ways to decode it.

Example :

Given encoded message "12", it could be decoded as "AB" (1 2) or "L" (12).

The number of ways decoding "12" is 2.*/

class Solution {
    public List<List<char>> PrintDecodedWays(string A, int startIndex, List<char> path,List<List<char>> solution) {
       
       if(startIndex > A.Length)
       {
            solution.Add(new List<char>(path));
            return solution;
       }
       if(A[startIndex]! ='0')
       {
            path.Add(int.Parse(A[startIndex]))
            PrintDecodedWays(A,startIndex+1,path, solution);
            path.remove(int.Parse(A[startIndex]))
       }

       if(startIndex >0 && A[startIndex-1]= '0'
        {   
            var num = int.Parse(A.Substring(startIndex-1,2));
            if(num > 0 && num <=- 26)
            {
                path.Add(num)
                PrintDecodedWays(A,startIndex+2,path,solution);
                path.remove(num);
            }
        }   
    }
}
