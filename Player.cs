using System;

namespace ShootingDice
{
    //this is the main parent class for a player
    public class Player
    {
        //Players have a name (must be assigned manually once player created) and dice size (default 6)
        public string Name { get; set; }
        public int DiceSize { get; set; } = 6;

        public virtual int Roll()
        {
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }

        public virtual void Play(Player other)
        {
            // Call roll for "this" Player and for the "other" Player (represents opponent)
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}