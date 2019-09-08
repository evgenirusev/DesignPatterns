using System;

namespace TemplateMethodPattern
{
    public class LightEventListUI : BaseEventListUI
    {
        protected override void DisplayMessage()
        {
            Console.WriteLine("Displaying Light Event List...");
        }

        protected override void ApplyTextColor()
        {
            Console.WriteLine("Applying Text Color -> Black");
        }

        protected override void DisplayEvents()
        {
            Console.WriteLine("Displaying LightEventList Events...");
        }
    }
}
