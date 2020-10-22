using System;
namespace Drats
{
    public class Drats
    {   
        public static int NoWays(int target,int noDrats)
        {   
            if(target>noDrats*20||noDrats==0)
            {
                return 0;
            }
            else if(target==noDrats)
            {
                return 1;
            } 
            else if(noDrats==1)
            {
                if(target<=20&&target!=0)
                {
                    return 1;
                }
                return 0;
            } 
            else if(noDrats==2)
            {
                if(target>21)
                {
                    return 41-target;
                }
                return target-1;
            }
            else
            {
                int sum = 0;
                for(int i = 1;i<=20;i++)
                {   
                    if(target-i<noDrats-1)
                    {
                        break;
                    }
                    sum += NoWays(target-i,noDrats-1);
                }
                return sum;
            }
        }
        public static int NoSolutions(int target,int noDrats)
        {
            int sum = 0;
            for(int i = 1;i<=20;i++)
            {
                if(i*2<=target)
                {   
                    if(i*2==target&&noDrats==1)
                    {
                        return 1;
                    }
                    else
                    {
                    int addition = NoWays(target-i*2,noDrats-1);
                    if(addition>0)
                    {
                        sum+=addition;
                    }
                    }
                }
                else
                    break;
            }
            return sum;
        }
        static void Main()
        {
            for(int i = 3;i<100;i++)
            {
                if(NoSolutions(i,3) == 0)
                {
                    Console.WriteLine(i);
                }
                //gives me 61 for 2 drats
                //and 81 for 3 drats
            }
        }
    }
}
