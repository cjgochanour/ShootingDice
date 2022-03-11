using System;

namespace ShootingDice
{
    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            int finalRoll = 0;
            while (finalRoll < 4)
            {
                finalRoll = new Random().Next(DiceSize) + 1;
            }
            return finalRoll;
        }
    }
}