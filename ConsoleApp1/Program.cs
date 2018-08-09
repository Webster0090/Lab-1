using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
               

                string number1;
                string number2;

                
                bool result = true;

                
                Console.WriteLine("Good morning, programmer.\n");
                
                Console.Write("Please enter a number: ");

                
                number1 = Console.ReadLine();

               
                Console.Write("Please enter a second number: ");
                number2 = Console.ReadLine();

               
                if (number1.Length == number2.Length) 
                {
                    
                    int length = number1.ToString().Length;

                    
                    int[] intarray = new int[length];

                    
                    for (int i = 0; i < length; i++)
                    {
                        

                        int firstNumber = int.Parse(number1.Substring(i, 1));
                        int secondNumber = int.Parse(number2.Substring(i, 1));

                        
                        int total = firstNumber + secondNumber;

                        
                        intarray[i] = total;
                    }

                    

                    for (int i = 0; i < intarray.Length; i++)
                    {
                        for (int j = 0; j < intarray.Length; j++)
                        {
                            if (intarray[i] != intarray[j])
                            {
                                result = false;
                            }
                        }
                    }

                    
                    if (result == true)
                    {
                        Console.WriteLine("IT WORKED! GOOD JOB! Please any key to exit program...");
                        Console.ReadLine();
                       
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This failed... Please any key to exit program...");
                        Console.ReadLine();
                        break;
                    }
                }
                
                else
                {
                    Console.WriteLine("Please enter two numbers that are of the same length. Enter any key to restart program...");
                    Console.ReadLine();
                    Console.Clear();
                }


               
            }
        }
    }
}
