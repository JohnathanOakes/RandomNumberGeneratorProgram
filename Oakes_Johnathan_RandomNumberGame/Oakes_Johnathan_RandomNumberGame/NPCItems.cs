using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oakes_Johnathan_RandomNumberGame
{
    class NPCItems
    {
        //This class will create a random item that the NPC will use.

        //Member Varaiable.
        int memNPCItem;
        
        //Consturctor for the class
        public NPCItems(int _NPCItem)
        {
            //Setting varaiables for the paramater.
            memNPCItem = _NPCItem;
        }

        //Getter for the class.
        public int GetNPCItem()
        {
            //Returing the value for the NPC's item.
            return memNPCItem;
        }

        //Creating the setter for the class.
        public int SetNPCItem(int _height)
        {
            //Allowing the value to be changed.
            Random randomNumber = new Random();
            int NPCItem = randomNumber.Next(1, 3);
            _height = NPCItem;
            this.memNPCItem = _height;
            return _height;
        }
    }
}
