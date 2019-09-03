using CommandPattern.Implementation.Receivers;

namespace CommandPattern.Implementation.Commands
{
    public class RenderTooltipCommand : ICommand
    {
        private readonly ITooltipRenderer _tooltipRenderer;

        public RenderTooltipCommand(ITooltipRenderer tooltipRenderer)
        {
            _tooltipRenderer = tooltipRenderer;
        }

        public void Execute()
        {
            _tooltipRenderer.RenderTooltip();
        }
    }
}
