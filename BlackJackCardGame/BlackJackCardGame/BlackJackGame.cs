using System;
namespace BlackJackCardGame
{
    public class BlackJackGame : Game //inherits all of the properties from Game, the super-class
    {
        //BlackJackGame game = new BlackJackGame();

        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("BlackJack players: ");
            base.ListPlayers();
        }
    }
}
