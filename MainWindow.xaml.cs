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

namespace Obrazki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Class1> ryby = new List<Class1>();
        int iterator = 0;
        public MainWindow()
        {
            
            
            ryby.Add(new Class1("karp.jpg"));
            ryby.Add(new Class1("sum.jpg"));
            ryby.Add(new Class1("okon.jpg"));
            InitializeComponent();
            zmien();
            
        }

        private void Button_click(object sender, RoutedEventArgs e)
        {
            if(iterator <= 0)
            {
                iterator = ryby.Count()-1;
            }
            else
            {
                iterator--;
            }
            zmien();

        }

        private void prawo_Click(object sender, RoutedEventArgs e)
        {
            if(iterator >= ryby.Count()-1)
            {

                iterator = 0;
            }
            else
            {
                iterator++;
            }
            zmien();

        }

        private void polubienia_Click(object sender, RoutedEventArgs e)
        {
            
            zmien();



        }
        private void zmien()
        {
            obr_ryby.Source = new BitmapImage(new Uri(ryby[iterator].zmiana, UriKind.Relative));
            blok.Text = ryby[iterator].polubienie().ToString();
            
        }
    }
}
