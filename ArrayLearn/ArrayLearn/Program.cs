namespace ArrayLearn
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[5] {1, 2, 6, 7, 9};
            Console.WriteLine(array[0]);
            string[] array2 = new String[3] {"dhaka", "rangpur", "kurigram"};

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }

            string[] array3 = new string[5];

            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine("Write some things..");
                string data  = Console.ReadLine();
                array3[i] = data;
            }

            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i]);
            }

            foreach (string i in array3)
            {
                  Console.WriteLine(i);
            } 
//two dimation array

            string[,] towDynarray = new string[3, 2];

            for (int s = 0; s < 3; s++)
            {
               
                      Console.Write("Write your First Name..    "); 
                      string firstName = Console.ReadLine();
                      towDynarray[s, 0] = firstName;
                      
                      Console.Write("Write your Last Name..   "); 
                      string LastName = Console.ReadLine();
                      towDynarray[s, 1] = LastName;
                
                

            }
//PRINT Data
            Console.WriteLine("------PERSON INFO------");
            Console.Write("First Name"+"   "); 
            Console.Write("Last Name");
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            for (int i = 0; i < towDynarray.GetLength(0); i++)
            {
                for (int j = 0; j < towDynarray.GetLength(1); j++)
                {
                   
                    Console.Write(towDynarray[i, j]+"         ");
                }

                Console.WriteLine();
                Console.WriteLine("-----------------------");
            }
            
            
        }
    }
}

