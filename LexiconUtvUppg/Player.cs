using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconUtvUppg
{    public class Player
    {
        public Player(string name)
        {
            UserName = name;

            Random dice = new Random();
            int slumpTalHealth = dice.Next(1, 100);
            int slumpTalStrength = dice.Next(1, 100);
            int slumpTalLuck = dice.Next(1, 12);

            UserHealth = slumpTalHealth;
            UserStrength = slumpTalStrength;
            LuckyPunk = slumpTalLuck;
        }
        public string UserName { get; }
        public int UserHealth { get; }
        public int UserStrength { get; }
        public int LuckyPunk { get; }
    }
}
