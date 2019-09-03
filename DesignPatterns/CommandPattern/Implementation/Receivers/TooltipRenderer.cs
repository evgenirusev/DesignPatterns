using System;

namespace CommandPattern.Implementation.Receivers
{
    public class TooltipRenderer : ITooltipRenderer
    {
        public void RenderTooltip()
        {
            Console.WriteLine("Rendering Tooltip...");
        }
    }
}
