using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Question6
{
    public class Team: IEnumerable
    {
        public Player[] players;

        public Team(Player[] playerArray)
        {
            for(int i=0; i<playerArray.Length; i++)
            {
                players[i] = playerArray[i];
            }
        }

    }
}
