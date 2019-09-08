using System;

namespace TemplateMethodPattern
{
    public class DarkEventListUI : BaseEventListUI
    {
        protected override void DisplayMessage()
        {
            Console.WriteLine("Displaying Dark Event List...");
        }

        protected override void ApplyBackgroundColor()
        {
            Console.WriteLine("Applying Background Color -> Black");
        }

        protected override void ApplyTextColor()
        {
            Console.WriteLine("Applying Text Color -> White");
        }

        protected override void DisplayEvents()
        {
            Console.WriteLine("Displaying DarkEventList Events...");
        }
    }
}
