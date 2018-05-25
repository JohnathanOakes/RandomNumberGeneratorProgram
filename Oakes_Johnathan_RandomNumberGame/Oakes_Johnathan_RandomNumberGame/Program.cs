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

              //List for the scores;
              List<int> points = new List<int>() { 0, 0 };
            string answer = "1";
            //Varaiables for the points;
            int npcPoints = 0;
            int playerPoints = 0;
            {
                //Welcomeing the user and telling them about the program;
                Console.WriteLine("Welcome the goal of this game is score 5 points before the computer does\r\nYou will be able to select form 3 items a shield, arrow, and sword.\r\nYou gain 1 point if your item beats the computers item and the computer gains 1 point if its item beats your item.\r\nA shield beats a arrow, arrow beats sword, and sword beats shield.\r\n");
                //This part of the code will run until the game is won or lost
                while (points [0] != 5 && points[1] != 5)
                {
                    //Varabile to hold the vaule of playes item
                    string playeritem;
                    //Asking the user what item they would like to use.
                    playeritem = PlayerItem();
                    int item;
                    //Telling them what item they selected
                   PlayerItem player = new PlayerItem();
                   item = player.PlayerItems(playeritem);
                    //Telling the player what the NPC has selected;
                    NPCItems NPC = new NPCItems(0);
                    int NPCItem;
                    NPCItem = NPC.Item();
                    
                    Score scores = new Score();
                    points = scores.Scoring(item, NPCItem);
                    playerPoints += points[0];
                    npcPoints += points[1];
                   Console.WriteLine("Player {0} NPC {1}", playerPoints, npcPoints);
                       
                    
 

                    
                }
                //Will display if computer won
                if (points[1] == 5)
                {
                    Console.WriteLine("Computer won");

                }
                //Will display if player won
                if (points[0] == 5)
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
                    points[1] = 0;
                    points[0] = 0;
                }
            }
 
           
        }
        //This method will be used to hold the variable for the players item.
        public static string PlayerItem()
        {
            Console.WriteLine("Please select a item that you wish to use for this round");
            string playeritem = Console.ReadLine();
            
            //Error Loop
            while (playeritem != "1" && playeritem != "2" && playeritem != "3")
            {
                Console.WriteLine("Error the item you selected does not exist please enter a item that exist");
                playeritem = Console.ReadLine();
            }
            return playeritem;

        }


    }
    
}
