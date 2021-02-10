using System;


namespace ConsoleApp_1
{
    public class Classe5
    {

        public static void Main(string[] args)
            {
                int i;
                char[] vowels = new char[5];
                vowels[0] = 'A';
                vowels[1] = 'E';
                vowels[2] = 'I';
                vowels[3] = 'O';
                vowels[4] = 'U';
                for(i=0; i<5 ; i++)
                {
                    Console.WriteLine(vowels[i]);// prints U as the output.
                    
                }
        }

        
    }
}

