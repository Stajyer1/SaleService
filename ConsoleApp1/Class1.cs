using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            if (nums==null)
            {
                return null;
            }
            var result = new List<List<int>> { };
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i]+nums[j]+nums[k]==0)
                        {
                            List<int> list = new List<int> { nums[i], nums[j], nums[k] };
                            list.Sort();
                           
                            if (!result.Contains(list))
                            {
                                
                                result.Add(list);
                               
                            }
                            
                        }
                    }
                }
            }
            return result.ToArray();



    }
    }
}
