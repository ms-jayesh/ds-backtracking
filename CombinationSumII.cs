public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        IList<IList<int>> solutionset = new List<IList<int>>();
        //Array.Sort(candidates);
        FindPermutation(candidates,target,new List<int>(), solutionset,0,candidates.Length);
        return solutionset;
    }
     public void FindPermutation(int[] candidate, int target, IList<int> path, IList<IList<int>> solutionset, int start, int end)
    {
         if(target == 0)
        {
            if(!Matched(solutionset,path))
                solutionset.Add(new List<int>(path));
             return;
                
        }
        
        for(int i=start;i<end;i++)
        {
                
             // option 1 consider the element
                if(target>=candidate[i])
                {
                    path.Add(candidate[i]);
                    FindPermutation(candidate, target-candidate[i], path, solutionset, i+1,end);
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