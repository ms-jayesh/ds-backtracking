/*Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent.

A mapping of digit to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters. */
/*Input: "23"
Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
Time Complexity = 3^n;
 */

 public class Solution {
    public IList<string> LetterCombinations(string digits) {
     
         List<string> lst = new List<string>();
         Dictionary<char,string> map = new Dictionary<char,string>();
         map.Add('2',"abc");
         map.Add('3',"def");
         map.Add('4',"ghi");
         map.Add('5',"jkl");
         map.Add('6',"mno");
         map.Add('7',"pqrs");
         map.Add('8',"tuv");
         map.Add('9',"wxyz");
         if(digits == "")
             return lst;
         BacktrackFunc(null,digits,lst,map);
         return lst;
    }
    public void BacktrackFunc(string digitstring, string number, List<string> lst,Dictionary<char,string> map)
    {
        if(number.Length == 0)
        {
            lst.Add(digitstring);
        }
        else
        {
                var strval = map[number[0]];
                for(int j = 0;j<strval.Length;j++)
                {
                    BacktrackFunc(digitstring+strval[j].ToString(),number.Substring(1),lst,map);
                }
            
        }
    }
}