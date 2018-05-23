using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oakes_Johnathan_RandomNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Johnathan Oakes
            //2018 May
            //Project & Portfoilo 1
            /*This program will create a game in which the player must score five point before the npc
             * The player will have a selction of three items.
             * If they guess right they gain 1 point if they guess wrong the npc gains a point if they guess the same nothing happens.
             * The npc guess will be made by a random number generator
             * The game is similar to rock paper scissors
             */

            //Setting some Variables
              int npcPoints = 0;
              int playerPoints = 0;
            string answer = "1";
            while (answer == "1")
            {
                Console.WriteLine("Welcome the goal of this game is score 5 points before the computer does\r\nYou will be able to select form 3 items a shield, arrow, and sword.\r\nYou gain 1 point if your item beats the computers item and the computer gains 1 point if its item beats your item.\r\nA shield beats a arrow, arrow beats sword, and sword beats shield.\r\n");



                while (npcPoints != 5 && playerPoints != 5)

                {


                    //Welcoming the user and telling them about the program.
                    
                    //Asking the user what item they would like to use.
                    Console.WriteLine("What what item would you like to use if shield type 1 if arrow type 2 if sword type 3");
                    //Cataching users response.
                    string playerItem = Console.ReadLine();

                    while (playerItem != "1" && playerItem != "2" && playerItem != "3")

                    {
                        Console.WriteLine("Error item does not exist.\r\n Please type in 1, 2, or 3");
                        playerItem = Console.ReadLine();
                    }

                    //Creating the item that the NPC will use for the round.

                    NPCItems NPC = new NPCItems(0);
                    int NPCItem = 0;
                    NPCItem = NPC.Item();
                


                    //will run if player scores a point
                    if ((playerItem == "1" && NPCItem == 2) || (playerItem == "2" && NPCItem == 3) || (playerItem == "3" && NPCItem == 1))
                    {
                        playerPoints += 1;
                        Console.WriteLine("Player won round! Player score{0} computer score{1}", playerPoints, npcPoints);
                    }
                    //Will run if computer scores a point.
                    if ((playerItem == "2" && NPCItem == 1) || (playerItem == "3" && NPCItem == 2) || (playerItem == "3" && NPCItem == 1))
                    {
                        npcPoints += 1;
                        Console.WriteLine("NPC won Round! Player score{0} computer score{1}", playerPoints, npcPoints);
                    }
                    //Will run if round is a tie.
                    if ((playerItem == "1" && NPCItem == 1) || (playerItem == "2" && NPCItem == 2) ||(playerItem == "3" && NPCItem ==3))
                    {
                        Console.WriteLine("Tie no score added");
                    }
                }
                //Will display if computer won
                if (npcPoints == 5)
                {
                    Console.WriteLine("Computer won");

                }
                //Will display if player won
                if (playerPoints == 5)
                {
                    Console.WriteLine("Player won");

                }
                Console.WriteLine("Would you like to play again?\r\nEnter 1 for yes\r\n Enter 2 for no");
                answer = Console.ReadLine();

                //Creating a valadation loop
                while (answer != "1" && answer != "2")
                {
                    Console.WriteLine("Error please enter 1 to play again or 2 to exit ");
                    answer = Console.ReadLine();
                }
                if (answer == "1")
                {
                    npcPoints = 0;
                    playerPoints = 0;
                }
            }
 
           
        }
        
    }
}
