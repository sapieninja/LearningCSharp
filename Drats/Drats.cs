using System;
namespace Drats
{
    public class Drats
    {   
        public static int noWays(int target,int noDrats)
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
                    sum += noWays(target-i,noDrats-1);
                }
                return sum;
            }
        }
        public static int noSolutions(int target,int noDrats)
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
                    int addition = noWays(target-i*2,noDrats-1);
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
            Console.WriteLine(noSolutions(83,5));
        }
    }
}
