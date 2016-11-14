using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace maxLength
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Operation
    {
        public static int getLength(string str)
        {
            int length = 0;
	        int max = 1;
	        int count = 0;
	        int i=0,j=0;

	        int[] a = new int[26];
            while (i < 26)
                a[i++] = 0;

	        length = str.Length;
            if (length == 0)
                return 0;
            else if (length == 1)
                return 1;
            else if (length > 30000)
                return 0;

	        string str1 = str.ToLower();

            char[] str2 = str1.ToCharArray();
             
	        a[str2[0] -'a'] = 1;

	        i = 0;
	        j = 1;
	        count = 1;
	        while((j < length) && (i < length - max))
	        {
		        if(a[str2[j] - 'a'] == 0)
		        {
			        a[str2[j] - 'a'] = 1;
			        count++;
			        if(max < count)
				        max = count;
			        j++;
		        }
		        else 
		        {
			        a[str2[i] - 'a'] = 0;
			        i++;
			        count--;
		        }
	        }
	        return max;
        }
    }
}
