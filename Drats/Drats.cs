using System;
namespace Drats
{
    public class Drats
    {   
        //Code to check if this branch is possible
        static bool possible(int scoreToMake,int noDrats,bool FirstShot)
        {
            int maxpossibleScore = 20*noDrats;
            int minpossibleScore = noDrats;
            if(FirstShot)
            {
                maxpossibleScore+=20;
                minpossibleScore+=1;
            }
            return maxpossibleScore>=scoreToMake&&scoreToMake>=minpossibleScore;
        }
        public static int noSolutions(int scoreToMake,int noDrats,bool FirstShot)
        {   
            Console.WriteLine("{0},{1},{2}",scoreToMake,noDrats,FirstShot);
            int sum = 0;
            int drawer = scoreToMake/(Convert.ToInt32(FirstShot)+1);
            if(drawer>20)
                drawer = 20;
            while(drawer>0) //Makes sure that this next move will work 
            {   
                //Inside the loop I calculate all the possible combinations following this move that could work and add them to my sum 
                int thisScore = drawer*(Convert.ToInt32(FirstShot)+1);
                if(noDrats==1&&thisScore==scoreToMake)//checks if this drawer will finish the job (if so selects it)
                {    
                    sum++;
                }
                else if((noDrats==scoreToMake&&!FirstShot))
                {
                    sum++;
                    break;
                }
                else if(noDrats!=1)//Otherwise checks for working solutions
                {
                    if(possible(scoreToMake-thisScore,noDrats-1,false))
                        //checks to see if this line could possibly work
                        sum += noSolutions(scoreToMake - thisScore,noDrats-1,false);
                }
                drawer--;
            }
            return sum;
        }
        static void Main()
        {
            Console.WriteLine(noSolutions(83,5,true));
        }
    }
}
