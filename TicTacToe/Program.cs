using System;

namespace TicTacToe
{
    class Program
    {
        //Set of backgroud Matrix
        static string[,] playFields = new string[,]{
                {"1","2","3"}, //Row 0
                {"4","5","6"}, //Row 1
                {"7","8","9"}  //Row 2
            };

        //Counter to understand if nobody wins...
        static int turns = 0;


        static void Main(string[] args)
        {
            //Number of players
            int player = 2;
            int input = 0;
            bool inputCorrect = true;
           
            do
            {
                

                //Check of who is playng...
                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }

                //Set field run every time we do a input decision...
                SetField();

                //CHeck if somebody wins...
                #region
                //When somebody win...
                char[] playngChars = { 'X', 'O' };

                foreach(char playngChar in playngChars)
                {
                   if(
                           (playFields[0, 0] == playngChar.ToString() && playFields[0, 1] == playngChar.ToString() && playFields[0, 2] == playngChar.ToString())     
                        || (playFields[1, 0] == playngChar.ToString() && playFields[1, 1] == playngChar.ToString() && playFields[1, 2] == playngChar.ToString())  
                        || (playFields[2, 0] == playngChar.ToString() && playFields[2, 1] == playngChar.ToString() && playFields[2, 2] == playngChar.ToString())

                        || (playFields[0, 0] == playngChar.ToString() && playFields[1, 0] == playngChar.ToString() && playFields[2, 0] == playngChar.ToString())
                        || (playFields[0, 1] == playngChar.ToString() && playFields[1, 1] == playngChar.ToString() && playFields[2, 1] == playngChar.ToString())
                        || (playFields[0, 2] == playngChar.ToString() && playFields[1, 2] == playngChar.ToString() && playFields[2, 2] == playngChar.ToString())
                        
                        || (playFields[0, 0] == playngChar.ToString() && playFields[1, 1] == playngChar.ToString() && playFields[2, 2] == playngChar.ToString())
                        || (playFields[0, 2] == playngChar.ToString() && playFields[1, 1] == playngChar.ToString() && playFields[2, 0] == playngChar.ToString())
                        )
                        {
                        if(playngChar.ToString()  == "X")
                        {
                            Console.WriteLine("\n Player 2 has won!");
                        }
                        else
                        {
                            Console.WriteLine("\n Player 2 has won!");
                        }
                        Console.WriteLine("\n Press any key to start a new game!");
                        Console.ReadKey();
                        ReSetField();
                        break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("\n DRAW!!! \nNobody has won!! Press any key to start a new game!");
                        Console.ReadLine();
                        ReSetField();
                        Console.WriteLine("{0}", turns.ToString());
                        break;
                    }

                }

               

                #endregion


                //CHeck if a field is alreadz taken
                #region
                do
                {            


                    Console.WriteLine("\n Player {0}: Choose your field!", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());  

                    }
                    catch
                    {
                        Console.WriteLine("\n Player {0}:Please enter a correct number", player);
                    }

                    if ((input == 1) && (playFields[0, 0] == "1"))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 2) && (playFields[0, 1] == "2"))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 3) && (playFields[0, 2] == "3"))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 4) && (playFields[1, 0] == "4"))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 5) && (playFields[1, 1] == "5"))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 6) && (playFields[1, 2] == "6"))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 7) && (playFields[2, 0] == "7"))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 8) && (playFields[2, 1] == "8"))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 9) && (playFields[2, 2] == "9"))
                    {
                        inputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("\n Incorrect input: field already taken, select another value!");
                        inputCorrect = false;
                    }

                }
                while (!inputCorrect);
                #endregion
            }
            while (true);

         }

        public static void ReSetField()
        {
            //I clear the console once a SetField is called again
            //Console.Clear()       
            turns = 0;
            playFields[0, 0] = "1";
            playFields[0, 1] = "2";
            playFields[0, 2] = "3";
            playFields[1, 0] = "4";
            playFields[1, 1] = "5";
            playFields[1, 2] = "6";
            playFields[2, 0] = "7";
            playFields[2, 1] = "8";
            playFields[2, 2] = "9";
            SetField();
        }

        public static void SetField()
        {
            //I clear the console once a SetField is called again
            Console.Clear();
            Console.WriteLine("    |     |     ");
            Console.WriteLine(" {0}  |  {1}  |  {2}", playFields[0, 0], playFields[0, 1], playFields[0, 2]);
            Console.WriteLine("____|_____|____");
            Console.WriteLine("    |     |    ");
            Console.WriteLine("    |     |     ");
            Console.WriteLine(" {0}  |  {1}  |  {2}", playFields[1, 0], playFields[1, 1], playFields[1, 2]);
            Console.WriteLine("____|_____|____");
            Console.WriteLine("    |     |    ");
            Console.WriteLine("    |     |     ");
            Console.WriteLine(" {0}  |  {1}  |  {2}", playFields[2, 0], playFields[2, 1], playFields[2, 2]);
            Console.WriteLine("____|_____|____");
            Console.WriteLine("    |     |    ");
            turns++;
        }


        public static void EnterXorO(int player, int input)
        {
            string playerSign = "";
            if (player == 1)
            {
                playerSign = "X";
            }
            else if (player == 2)
            {
                playerSign = "O";
            }


            switch (input)
            {
                case 1:
                    playFields[0, 0] = playerSign; break;
                case 2:
                    playFields[0, 1] = playerSign; break;
                case 3:
                    playFields[0, 2] = playerSign; break;
                case 4:
                    playFields[1, 0] = playerSign; break;
                case 5:
                    playFields[1, 1] = playerSign; break;
                case 6:
                    playFields[1, 2] = playerSign; break;
                case 7:
                    playFields[2, 0] = playerSign; break;
                case 8:
                    playFields[2, 1] = playerSign; break;
                case 9:
                    playFields[2, 2] = playerSign; break;
            }
        }


    }
}

 
