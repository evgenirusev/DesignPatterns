using System;

namespace TemplateMethodPattern
{
    public class Client
    {
        public static void Main(string[] args)
        {
            BaseEventListUI darkEventListUI = new DarkEventListUI();
            BaseEventListUI lightEventListUI = new LightEventListUI();

            darkEventListUI.DisplayEventList();
            Console.WriteLine();
            lightEventListUI.DisplayEventList();
        }
    }
}
