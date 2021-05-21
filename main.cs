using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    var result = TwoSum(new int[]{0,1,4,6},5);
    Console.WriteLine(result[0]+","+result[1]);
  }

  private static int[] TwoSum(int[] nums, int target) 
  {
      var length=nums.Length;
      for(var i = 0; i<length; i++)
      {
          for(var j = i+1; j < length;j++)
          {
              if(nums[i]+nums[j]==target)
              {
                  return new int[]{i,j};
              }
          }
      }
      return new int[]{};
  }


}