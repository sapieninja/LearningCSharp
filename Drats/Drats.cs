using System;
namespace Drats
{
    public class Drats
    {   
        public static int noSolutions(int scoreToMake,int noDrats,bool FirstShot)
        {
            int sum = 0;
            int drawer = 1;
            while(drawer<=20&&(drawer*(Convert.ToInt32(FirstShot)+1))<=scoreToMake) //Makes sure that this next move will work 
            {
                //Inside the loop I calculate all the possible combinations following this move that could work and add them to my sum 
                if(noDrats==1&&drawer*(Convert.ToInt32(FirstShot)+1)==scoreToMake)
                    sum+=1;
                else if(noDrats!=1)
                    sum += noSolutions(scoreToMake - drawer*(Convert.ToInt32(FirstShot)+1),noDrats-1,false);
                drawer += 1;
            }
            return sum;
        }
        static void Main()
        {
            Console.WriteLine(noSolutions(6,3,true));
        }
    }
}
