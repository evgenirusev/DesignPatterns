using System;

namespace TemplateMethodPattern
{
    public abstract class BaseEventListUI
    {
        public void DisplayEventList()
        {
            DisplayMessage();
            ApplyBackgroundColor();
            ApplyTextColor();
            DisplayEvents();
        }

        protected abstract void DisplayMessage();

        protected virtual void ApplyBackgroundColor()
        {
            Console.WriteLine("Applying Default Background Color -> White");
        }

        protected abstract void ApplyTextColor();

        protected abstract void DisplayEvents();
    }
}
