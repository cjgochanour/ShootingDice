using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            //create two new players

            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            //player 2 plays player 1

            player2.Play(player1);

            Console.WriteLine("-------------------");

            //add another player

            Player player3 = new Player();
            player3.Name = "Wilma";

            //new player plays player 2

            player3.Play(player2);

            Console.WriteLine("-------------------");

            //add a large dice player

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            //player 1 plays against new large dice player 

            player1.Play(large);

            Console.WriteLine("-------------------");

            //add smack talking player and have them play player2

            Player smackTalker = new SmackTalkingPlayer();
            smackTalker.Name = "Jimmy Jameson";

            smackTalker.Play(player2);

            Console.WriteLine("-------------------");

            //add OneHigherPlayer and have them play player3 and large dice player

            Player pumpkinEater = new OneHigherPlayer();
            pumpkinEater.Name = "Chris Cheatsworth";

            pumpkinEater.Play(player3);
            Console.WriteLine("-------------------");
            pumpkinEater.Play(large);
            Console.WriteLine("-------------------");

            //create a new human player - ask user for their name - have them play player 2

            Player human = new HumanPlayer();
            Console.WriteLine("Please enter your name: ");
            human.Name = Console.ReadLine();

            human.Play(player2);
            Console.WriteLine("-------------------");

            //create a new Creative Smack Talker and have them play player 1

            Player bigMouth = new CreativeSmackTalkingPlayer();
            bigMouth.Name = "Tim Talksalot";

            bigMouth.Play(player1);
            Console.WriteLine("-------------------");

            //create a list of players composed of the players we created

            List<Player> players = new List<Player>() {
                player1, player2, player3, large, smackTalker, pumpkinEater, human, bigMouth
            };

            //all players play against each other randomly

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}