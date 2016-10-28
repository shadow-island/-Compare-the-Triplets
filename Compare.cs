using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        List<int> a = new List<int>();
        List<string> s_a = Console.ReadLine().Split(' ').ToList();
        
        for (int i = 0; i < s_a.Count;i++) 
            a.Add(Convert.ToInt32(s_a[i]));
        
        List<int> b = new List<int>();
        List<string> s_b = Console.ReadLine().Split(' ').ToList();
        
        for (int i = 0; i < s_b.Count;i++) 
            b.Add(Convert.ToInt32(s_b[i]));

        int sum_a = 0;
        int sum_b = 0;
        for (int i = 0; i < a.Count;i++) 
        {
            if (a[i] >  b[i])
                sum_a++;
            if (a[i] <  b[i])
                sum_b++;
        }
            
        
        Console.WriteLine("{0} {1}",sum_a, sum_b);
    }
}
