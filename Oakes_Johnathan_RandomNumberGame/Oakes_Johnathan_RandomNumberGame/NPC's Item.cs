using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oakes_Johnathan_RandomNumberGame
{
    class NPC_sItem
    {
        //This class will create the item the NPC will use.
        private int npcItem; // The NPC's item.
        
        public void setNPCItem( int setNPC)
        {
            npcItem = setNPC;
        }

        public int getNPCItem()
        {    
            return npcItem;
        }
        public void Main (int[] args)
        {
           
            Random randomNumber = new Random();
            int npcItems = randomNumber.Next(1, 3);
            NPC_sItem npc = new NPC_sItem();

            //Setting the item NPC will use.
            npc.setNPCItem(npcItems);

        }
        
    }
    
}
