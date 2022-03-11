using System;

namespace ShootingDice
{
    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        private string _Taunt = "You're going down!";
        public string Taunt
        {
            get
            {
                return _Taunt;
            }
        }
        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            Console.WriteLine($"{Name} says \"{Taunt}\" as they roll!");
            return new Random().Next(DiceSize) + 1;
        }
    }
}