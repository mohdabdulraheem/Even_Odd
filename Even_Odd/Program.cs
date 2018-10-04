using System;

namespace Even_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            try
            {
                int a = int.Parse(Console.ReadLine());
            
            
                if (a % 2 == 1)
                {
                    Console.WriteLine(a + "is odd number");
                }
                else
                    Console.WriteLine(a + " is Even Number ");
            }
            catch (Exception ) {
                Console.WriteLine("Please Enter a valid input\n");
            }
            }
        
            }
        }
          
