using CommandPattern.Implementation.Commands;

namespace CommandPattern.Implementation.Invokers
{
    public class BetslipUI
    {
        private readonly ICommand _onClickCommand;
        private readonly ICommand _onHoverCommand;

        public BetslipUI(ICommand onClickCommand, ICommand onHoverCommand)
        {
            _onClickCommand = onClickCommand;
            _onHoverCommand = onHoverCommand;
        }

        public void OnClick()
        {
            _onClickCommand.Execute();
        }

        public void OnMouseHover()
        {
            _onHoverCommand.Execute();
        }
    }
}
