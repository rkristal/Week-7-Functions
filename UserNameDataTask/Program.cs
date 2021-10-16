using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada eesnime;
            //programm kusib kasutajal sisestad numbri 1-3
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja valib '2', siis kuvatakse kasutaja eesnime esimest tahte
            //kui kasutaja valib '3', siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Siesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Vali number 1-3");
            int userAnswer = Convert.ToInt32(Console.ReadLine());

            if (userAnswer ==1)
            {
                GetUserFirstData(userName);
            }
            else if (userAnswer == 2)
            {
                GetUserSecondData(userName);
            }
           
            else if (userAnswer == 3)
            {
                 GetUserThirdData(userName);
            }
           
        }

       private static void GetUserFirstData(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void GetUserSecondData (string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene taht on {userInput[0]}");
        }

        public static void GetUserThirdData (string userInput)
        {
             Console.WriteLine($"Sinu nimi on {userInput.Length} sumbolit pikk.");
        }









}
}

