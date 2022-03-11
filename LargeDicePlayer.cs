namespace ShootingDice
{
    // A Player who brings a large die to the game, inherits from PLayer - constructor sets DiceSize to 20 by default
    public class LargeDicePlayer : Player
    {
        public LargeDicePlayer()
        {
            DiceSize = 20;
        }
    }
}