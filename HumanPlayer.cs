using System;

namespace ShootingDice
{
    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("Please enter your roll: ");
            return int.Parse(Console.ReadLine());
        }
    }
}