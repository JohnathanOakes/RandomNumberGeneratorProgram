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

        //Creating the Setter for the class.
         public void SetNPCItem(int _height)
        {
            //Allowing the value to be changed.
            
            this.memNPCItem = _height;
        }
        public int Item ()
        {
            Random randomNumber = new Random();
            int item = randomNumber.Next(1, 3);
            if (item == 1)
            {
                Console.WriteLine("NPC has selected the shield");
            }
            if (item == 2)
            {
                Console.WriteLine("NPC has selected the arrow");
            }
            if (item == 3)
                Console.WriteLine("NPC has selected the sword");
            return item;
        }
    }
}
