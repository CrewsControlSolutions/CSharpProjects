using System;
namespace BlackJackCardGame
{
    public class BlackJackGame : Game, IWalkAway //inherits all of the properties from Game, the super-class
                                                 //and also from IWalkAway, an interface
    {
        //BlackJackGame game = new BlackJackGame();

        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("BlackJack Players: ");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
