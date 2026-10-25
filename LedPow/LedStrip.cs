using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LedPow
{
    internal class LedStrip
    {
        List<Led> leds;
        int spacing;
        int height;
        int left;
        int top;

        public LedStrip(int spacing, int height, int left, int top)
        {
            this.spacing = spacing;
            this.height = height;
            this.left = left;
            this.top = top;
            leds = new List<Led>();
        }

        public void AddLeds(Canvas canvas, int numberOfLeds)
        {
            if (leds.Count == 0)
            {
                for (int i = 0; i < numberOfLeds; i++)
                {
                    leds.Add(new Led(canvas, left + i * spacing, top + height));
                }
            }
        }
    }
}
