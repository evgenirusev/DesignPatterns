using CommandPattern.Implementation.Commands;
using CommandPattern.Implementation.Invokers;
using CommandPattern.Implementation.Receivers;

namespace Implementation
{
    public class Client
    {
        static void Main(string[] args)
        {
            IBetPlacer betPlacementUtil = new BetPlacementUtil();
            ITooltipRenderer tooltipRenderer = new TooltipRenderer();

            ICommand placeBetsCommand = new PlaceBetsCommand(betPlacementUtil);
            ICommand renderTooltipCommand = new RenderTooltipCommand(tooltipRenderer);

            BetslipUI betslipUI = new BetslipUI(placeBetsCommand, renderTooltipCommand);

            betslipUI.OnClick();
            betslipUI.OnMouseHover();
        }
    }
}
