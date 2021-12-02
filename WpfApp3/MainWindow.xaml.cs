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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox!=null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
            
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string fontSize = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            double newfontSize = Convert.ToDouble(fontSize);
            if (textBox != null)
            {
                textBox.FontSize = newfontSize;
            }
            
        }


       

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.FontWeight == FontWeights.Normal)
                {
                    textBox.FontWeight = FontWeights.Bold;
                }
                else
                {
                    textBox.FontWeight = FontWeights.Normal;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.FontStyle == FontStyles.Normal)
                {
                    textBox.FontStyle = FontStyles.Italic;
                }
                else
                {
                    textBox.FontStyle = FontStyles.Normal;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.TextDecorations == TextDecorations.Baseline)
                {
                    textBox.TextDecorations = TextDecorations.Underline;
                }
                else
                {
                    textBox.TextDecorations = TextDecorations.Baseline;
                }
            }
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            int red = 0; int black = 0; int blue = 0;
            textBox.Foreground = new SolidColorBrush(Color.FromRgb((byte)red, (byte)black, (byte)blue));
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            int green = 0; int red = 255; int blue = 0;
            textBox.Foreground = new SolidColorBrush(Color.FromRgb((byte)red, (byte)green, (byte)blue));
        }
    }

    
}
