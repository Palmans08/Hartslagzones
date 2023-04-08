using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace Hartslagzones
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string input;
        public MainWindow()
        {
            InitializeComponent();
            Zone5.Background = new SolidColorBrush(Color.FromRgb(252, 83, 83));
            Zone4.Background = new SolidColorBrush(Color.FromRgb(250, 165, 100));
            Zone3.Background = new SolidColorBrush(Color.FromRgb(100, 169, 250));
            Zone2.Background = new SolidColorBrush(Color.FromRgb(147, 250, 100));
            Zone1.Background = new SolidColorBrush(Color.FromRgb(235, 235, 235));
            Warning.Foreground = new SolidColorBrush(Color.FromRgb(113, 113, 113));
        }

        private void LeeftijdTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            input = LeeftijdTextBox.Text;
            if ((double.TryParse(input, out double leeftijd) && leeftijd > 0 && leeftijd < 130) || input == "")
            {
                Zone5.Text = $"Zone 5: {Math.Round((220 - leeftijd) * 90 / 100, 0)} tot {220 - leeftijd} bpm";
                Zone4.Text = $"Zone 4: {Math.Round((220 - leeftijd) * 80 / 100, 0)} tot {Math.Round((220 - leeftijd) * 90 / 100, 0)} bpm";
                Zone3.Text = $"Zone 3: {Math.Round((220 - leeftijd) * 70 / 100, 0)} tot {Math.Round((220 - leeftijd) * 80 / 100, 0)} bpm";
                Zone2.Text = $"Zone 2: {Math.Round((220 - leeftijd) * 60 / 100, 0)} tot {Math.Round((220 - leeftijd) * 70 / 100, 0)} bpm";
                Zone1.Text = $"Zone 1: {Math.Round((220 - leeftijd) * 50 / 100, 0)} tot {Math.Round((220 - leeftijd) * 60 / 100, 0)} bpm";
            }
            else MessageBox.Show("Incorrect input.");
        }
    }
}
