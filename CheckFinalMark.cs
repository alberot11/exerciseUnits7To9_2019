using System;
class CheckFinalMark
{
    static void Main ()
    {
        const int NUM = 10;
        int inc = 0, dec = 0, prev = 0;
        int [] grades = new int [NUM];
        for(int i=0 ; i < grades.Length ; i++)
        {
            do
            {
                Console.Write("Enter grade number {0}: ", i+1);
                grades [i] = Convert.ToInt32(Console.ReadLine());
            } while (grades [i] < 0);
            if(grades [i] < prev)
            {
                dec++;
            }
            else if (grades [i] > prev && i!=0)
            {
                inc++;
            }
            prev= grades [i];
        }
        Console.Write("There has been {0} increments and {1} decrements.",
            inc, dec);        
    }
}
