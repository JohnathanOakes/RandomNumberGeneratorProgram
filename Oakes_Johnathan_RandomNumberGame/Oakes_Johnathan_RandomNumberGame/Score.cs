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

        NPCItems npc = new NPCItems(0);
    }
}
