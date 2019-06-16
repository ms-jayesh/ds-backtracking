/*Given a set of candidate numbers (candidates) (without duplicates) and a target number (target), find all unique combinations in candidates where the candidate numbers sums to target.

The same repeated number may be chosen from candidates unlimited number of times.

Note:

All numbers (including target) will be positive integers.
The solution set must not contain duplicate combinations.
Example 1:

Input: candidates = [2,3,6,7], target = 7,
A solution set is:
[
  [7],
  [2,2,3]
]
 */



public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        
        IList<IList<int>> solutionset = new List<IList<int>>();
        FindPermutation(candidates,target,new List<int>(), solutionset);
        return solutionset;
        
    }
    
    public void FindPermutation(int[] candidate, int target, IList<int> path, IList<IList<int>> solutionset)
    {
        if(target<0)
            return;
        if(target == 0)
        {
            if(!Matched(solutionset,path))
                solutionset.Add(new List<int>(path));
                
        }
        else
        {
            for(int i=0;i<candidate.Length;i++)
            {
                    path.Add(candidate[i]);
                    FindPermutation(candidate, target-candidate[i], path, solutionset);
                    path.Remove(candidate[i]);
            }
        }
    }
    
    public bool Matched(IList<IList<int>> solutionset,IList<int> path )
    {
        var orderpath = path.OrderBy(x => x).ToList();
        
        for(int i= 0;i<solutionset.Count;i++)
        {
            var orderedlist = solutionset[i].OrderBy(x => x).ToList();
            
            if(orderpath.Count() == orderedlist.Count())
            {
                var matched = true;
                for(int j = 0;j<orderedlist.Count();j++)
                {
                    if(orderpath[j] != orderedlist[j])
                    {
                       matched = false;
                       break;
                    }
                }
                if(matched)
                    return true;
            }
        }
        return false;
    }
}