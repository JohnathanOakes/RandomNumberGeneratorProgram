using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oakes_Johnathan_RandomNumberGame
{
    class PlayersItem
    {
        

        //This class will hold the value for the players item.
        public int PlayerItems(string playeritem)
        {
            Program Player = new Program();
            
            int item;
            //Converting a string varable to a intager varable.

            int.TryParse(playeritem, out item);

            //Telling the player the item they selected
            if (item == 1)
            {
                Console.WriteLine("You have selected the shield");
            }

            if (item == 2)
            {
                Console.WriteLine("You have selected the arrow");
            }

            if (item == 3)
            {
                Console.WriteLine("You have selected the shield.");
            }
            return item;
        }
        
    }
}
