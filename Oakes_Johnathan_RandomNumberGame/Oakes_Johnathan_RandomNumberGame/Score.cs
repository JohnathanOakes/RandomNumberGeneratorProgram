using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oakes_Johnathan_RandomNumberGame
{
    class Score
    {
        //This class will keep the score of the games.

        //Memember variables
        int memPlayerScore;
        int memNPCScore;
        
        //Consturctor of the class
        public Score(int _playerScore, int _NPCScore)
        {
            memPlayerScore = _playerScore;
            memNPCScore = _NPCScore;
        }

        //Creating the Getters of the class.
        public int GetPlayerScore()
        {
            //returing player's score.
            return memPlayerScore;
        }
        public int GetNPCSCore()
        {
            //Return the NPC's score.
            return memNPCScore;
        }

        //Creating the Setters of the class
        public void SetPlayerScore(int _playerScore)
        {
            this.memPlayerScore = _playerScore;
        }

        public void SetNPCScore(int _NPCScore)
        {
            this.memNPCScore = _NPCScore;
        }

        public List<int> Scoring (int playeritem, int npcitem)
        {
            //Creating the list to hold the vaules of the scores
            List<int> Scores = new List <int>();

            Scores.Add(0);
            Scores.Add(0);

            //Calling the Class for the NPCS item
            NPCItems NPC = new NPCItems(0);
            npcitem = NPC.Item();

            //Calling the class for the players item
            Player_Item player = new Player_Item();
            playeritem = player.playeritem;

            //Will run if player wins the round.
            if ((playeritem == 1 && npcitem == 2) || (playeritem == 2 && npcitem == 3) || (playeritem == 3 && npcitem == 1))
            {
                Scores[0]++;
                Console.WriteLine("Round Won");
            }

            if ((playeritem == 2 && npcitem == 1) || (playeritem == 3 && npcitem == 2) || (playeritem == 1 && npcitem == 3))
            {
                Scores[1]++;
                Console.WriteLine("Draw");
            }
            return Scores;
            
        }
    }
}
