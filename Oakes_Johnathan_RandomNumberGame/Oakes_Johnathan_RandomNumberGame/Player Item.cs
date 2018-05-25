using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oakes_Johnathan_RandomNumberGame
{
    class Player_Item
    {
        //This class will hold the varable for the players item.
        int PlayerItem(string playeritem)
        {
            //Converting a string varable to a intager varable.
            int item;
            int.TryParse(playeritem, out item);

            while (!(int.TryParse(playeritem, out item)) && playeritem == "1" && playeritem == "2" && playeritem == "3") ;
            {
                Console.WriteLine("Error the item that you selected does not exist.");
            }
            //Telling the player the item they selected
            if(item == 1)
            {
                Console.WriteLine("You have selected the shield");
            }

            if(item == 2)
            {
                Console.WriteLine("You have selected the arrow");
            }

            if(item == 3)
            {
                Console.WriteLine("You have selected the shield.");
            }
            
    }
}
