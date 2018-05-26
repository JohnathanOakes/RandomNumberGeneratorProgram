using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oakes_Johnathan_RandomNumberGame
{
    class Score
    {

        public List<int> Scoring (int playeritem, int npcitem)
        {
            //Creating the list to hold the vaules of the scores
            List<int> Scores = new List<int>() { 0, 0 };
            //Calling the method in the main class
            Console.WriteLine("g");
            Program item = new Program();
            
            Console.WriteLine("z");
         
            //Calling the Class for the NPCS item
            NPCItems NPC = new NPCItems(0);
            npcitem = NPC.Item();

            //Calling the class for the players item
            Player player = new Player();
            Console.WriteLine("x");
            player.PlayerItems(Program.PlayerItem());

            {
                //Will run if player wins the round.
                {
                    if ((playeritem == 1 && npcitem == 2) || (playeritem == 2 && npcitem == 3) || (playeritem == 3 && npcitem == 1))
                    {
                        Scores[0] += 1;
                        Console.WriteLine("Round Won");
                    }

                    if ((playeritem == 2 && npcitem == 1) || (playeritem == 3 && npcitem == 2) || (playeritem == 1 && npcitem == 3))
                    {
                        Scores[1] += 1;
                        Console.WriteLine("Round Lost");
                    }
                    if ((playeritem == 1 && npcitem == 1) || (playeritem == 2 && npcitem == 2) || (playeritem == 3 && npcitem == 3))
                    {
                        Console.WriteLine("Draw");
     
                    }
                }
                return Scores;
            }
            
        }
    }
}
