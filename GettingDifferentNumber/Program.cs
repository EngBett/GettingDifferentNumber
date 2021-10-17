using System;

namespace GettingDifferentNumber
{

    class Solution
    {
        
        public static int GetDifferentNumber(int[] arr)
        {
            // sort(arr) O(n log(n)+n) x>n
            // 0>0, 1>1, 2>2, 3>5

            for(var i=0;i<=arr.Length;i++){
                bool found = false;
                foreach (var t in arr)
                {
                    if(i==t){
                        found = true;
                        break;
                    }
                }
         
                if(!found) return i;
            }
      
            return arr.Length;
        }

        static void Main(string[] args)
        {
            int[] arr = {1,5,2,4};
      
            Console.WriteLine(GetDifferentNumber(arr));
      
        }
    }
    
}