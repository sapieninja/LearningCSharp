using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace ListExercises
{
    public class Program
    {
        public static int Sum(List<int> toSum)
        {
            int total = 0;
            foreach(int element in toSum)
            {
                total+=element;
            }
            return total;
        }
        public static int Max(List<int> toMax)
        {
            int max = toMax[0];
            foreach(int element in toMax)
            {
                if(element>max)
                    max = element;
            }
            return max;

        }
        public static int Min(List<int> toMin)
        {
            int min = toMin[0];
            foreach(int element in toMin)
            {
                if(element<min)
                    min = element;
            }
            return min;
        }
        public static List<int> negative(List<int> toNegative)
        {
            List<int> listNegative = new List<int>();
            foreach(int element in toNegative)
            {
                if(element<0)
                    listNegative.Add(element);
            }
            return listNegative;
        }
        public static bool same(List<int> a,List<int> b)
        {
            foreach(int element in a)
            {
                if(b.Contains(element)==false)
                    return false;
            }
            foreach(int element in b)
            {
                if(a.Contains(element)==false)
                    return false;
            }
            return true;
        }
        public static bool linearSearch(int a,List<int> b)
        {
            foreach(int element in b)
            {
                if(element==a)
                    return true;
            }
            return false;
        }
        public static bool binarySearch(int a,List<int> b)
        {
            int left = 0;
            int right = b.Count;
            while(left<=right)
            {
                int middle = (left+right)/2;
                if(b[middle] < a)
                    left = middle + 1;
                else if(b[middle] > a)
                    right = middle -1;
                else
                    return true;
                
            }
            return false;
        }
        public static List<int> duplications(List<int> a)
        {
            List<int> duplicates = new List<int>();
            foreach(int element in a)
            {
                var amount = 
                    from num in a
                    where (num==element)
                    select num;
                if(amount.Count()>1&&duplicates.Contains(element)==false)
                    duplicates.Add(element);                   
            }
            return duplicates;
        }
        public static bool isSubset(List<int> a,List<int> b)
        {
            var inboth = 
                from num in a
                where (b.Contains(num))
                select num;
            if(a.Count==inboth.Count())
                return true;
            return false;           
        }
        public static List<int> reverse(List<int> toReverse)
        {
            for(int i = 0;i<(toReverse.Count/2);i++)
            {
                int temp = toReverse[i];
                toReverse[i] = toReverse[toReverse.Count-i-1];
                toReverse[toReverse.Count-i-1] = temp;
            }
            return toReverse;
        }
        public static List<int> sort(List<int> toSort)
        {
            return(quicksort(toSort,0,toSort.Count-1));
        }
        static List<int> quicksort(List<int> toSort,int low, int high)
        {   
            if(high==low)
            {
                return toSort;
            }
            int p = 0;
            int pivot = toSort[(low+high)/2];
            int i = low -1;
            int j = high + 1;
            while (true)
            {
                do
                {
                    i++;
                } while (toSort[i]<pivot);
                do{
                    j--;
                } while (toSort[j]>pivot);
                if(i>=j)
                {
                    p = j;
                    break;
                }
                int temp = toSort[i];
                toSort[i] = toSort[j];
                toSort[j] = temp;
            }
            toSort = quicksort(toSort,low,p);
            toSort = quicksort(toSort,p+1,high);
            return toSort;
        }
        static void Main(string[] args)
        {
           Console.WriteLine(Fractions.fraction("0.125"));
        }
    }
}
