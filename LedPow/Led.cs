using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace LedPow
{
    internal class Led 
    {
        bool _state;
        Rectangle ledShape;
        public Led(Canvas canvas, double x, double y)
        {
            _state = false;
            ledShape = new Rectangle
            {
                Width = 4,
                Height = 20,
                Fill = Brushes.DarkGreen
            };
            Canvas.SetLeft(ledShape, x);
            Canvas.SetTop(ledShape, y);
            canvas.Children.Add(ledShape);
        }

        public bool State {
            get => _state;
            set
            {
                _state = value;
                ledShape.Fill = value ? Brushes.Lime : Brushes.DarkGreen;
            }
            }

    }
}
