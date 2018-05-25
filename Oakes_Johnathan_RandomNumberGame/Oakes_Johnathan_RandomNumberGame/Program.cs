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
                //Welcomeing the user and telling them about the program;
                Console.WriteLine("Welcome the goal of this game is score 5 points before the computer does\r\nYou will be able to select form 3 items a shield, arrow, and sword.\r\nYou gain 1 point if your item beats the computers item and the computer gains 1 point if its item beats your item.\r\nA shield beats a arrow, arrow beats sword, and sword beats shield.\r\n");
                //This part of the code will run until the game is won or lost
                while (npcPoints != 5 && playerPoints != 5)
                {
                    //Varabile to hold the vaule of playes item
                    string playeritem;
                    //Asking the user what item they would like to use.
                    playeritem = PlayerItem();
                    //Telling them what item they selected
                    PlayersItem player = new PlayersItem();
                    player.PlayerItems(playeritem);
                    //Telling the player what the NPC has selected;
                    NPCItems NPC = new NPCItems(0);
                    NPC.Item();
                    
 

                    
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
        //This method will be used to hold the variable for the players item.
        public static string PlayerItem()
        {
            Console.WriteLine("Please select a item that you wish to use for this round");
            string playeritem = Console.ReadLine();
            return playeritem;
        }


    }
    
}
