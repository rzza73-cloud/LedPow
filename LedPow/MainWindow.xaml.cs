using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LedPow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<LedStrip> ledStrips = new List<LedStrip>();
        public MainWindow()
        {
            InitializeComponent();
            for(int i = 0; i < 8; i++)
            {
                LedStrip strip = new LedStrip(10, 20, 10, 10 + i * 30);
                ledStrips.Add(strip);
                strip.AddLeds(LedCanvas, 40);
            }
        }
    }
}
