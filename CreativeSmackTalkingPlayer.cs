using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> _TauntList = new List<string>
        {
            "You ain't seen nothin' yet",
            "Is that all you got?",
            "You're going down",
            "It's not even worth insulting you"
        };
        public List<string> TauntList
        {
            get
            {
                return _TauntList;
            }
        }
        public override int Roll()
        {
            Console.WriteLine($"{Name} says \"{TauntList[new Random().Next(TauntList.Count - 1)]}\" as they roll!");
            return base.Roll();
        }
    }
}