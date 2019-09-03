using CommandPattern.Implementation.Receivers;

namespace CommandPattern.Implementation.Commands
{
    public class PlaceBetsCommand : ICommand
    {
        private readonly IBetPlacer _betPlacer;

        public PlaceBetsCommand(IBetPlacer betPlacer)
        {
            _betPlacer = betPlacer;
        }

        public void Execute()
        {
            _betPlacer.PlaceBet();
        }
    }
}
