using System;
using System.Collections.Generic;

namespace Subsets_II
{
  class Program
  {
    static void Main(string[] args)
    {
      var nums = new int[] { 2, 2, 1 };
      Program p = new Program();
      p.SubsetsWithDup(nums);
    }
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
      var result = new List<IList<int>>();
      Array.Sort(nums);
      Backtracking(nums, result, new List<int>(), 0);
      return result;
    }

    private void Backtracking(int[] nums, List<IList<int>> result, IList<int> temp, int start)
    {
      result.Add(new List<int>(temp));
      for (int i = start; i < nums.Length; i++)
      {
        if (i > start && nums[i] == nums[i - 1]) continue;
        temp.Add(nums[i]);
        Backtracking(nums, result, temp, i + 1);
        temp.RemoveAt(temp.Count - 1);
      }
    }
  }
}
