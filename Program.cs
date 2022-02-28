using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_Consonent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to check Given Character is vowel Or consonent");
            Console.WriteLine("Enter a Character to Check Vowel or consonent");
            char input = char.Parse(Console.ReadLine());
            if  (input == 'A'|| input =='E'|| input=='I'|| input == 'O' || input == 'U'|| input == 'a' || input == 
                    'e' || input == 'i' || input == 'o' || input == 'u')
                {
                Console.WriteLine("Given character is Vowel{0}",input);

            }
            else
            {
                Console.WriteLine("Given character is consoent{0} ",input);

            }
            Console.ReadKey();
        }
    }
}
