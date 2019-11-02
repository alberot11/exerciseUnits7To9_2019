using System;

/*Program that asks the user to enter 10 integer, positive numbers and, at the 
  end of the process, the program must tell how many increments and decrements 
  have taken place.*/

class CheckFinalMark
{
    static void Main ()
    {
        const int AMOUNT = 10;
        int increment = 0, decrement = 0;
        int [] grades = new int [AMOUNT];
        
        for(int i=0 ; i < grades.Length ; i++)
        {
            do
            {
                Console.Write("Enter grade number {0}: ", i+1);
                grades [i] = Convert.ToInt32(Console.ReadLine());
            } while (grades [i] < 0);
            if(i > 0 && grades [i] < grades [i-1])
                decrement++;
            else if (i > 0 && grades [i] > grades [i-1] && i!=0)
                increment++;
        }
        
        Console.Write("There has been {0} increments and {1} decrements.",
            increment, decrement);        
    }
} 

