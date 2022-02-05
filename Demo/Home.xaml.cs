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

namespace MnSDemo;
/// <summary>
/// Interaction logic for Home.xaml
/// </summary>
public partial class Home : Page
{
    public Home()
    {
        InitializeComponent();
    }

    private void StackPanel1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        NavigationService.Navigate(new Uri("Product.xaml?id=1", UriKind.Relative));
    }

    private void StackPanel2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        NavigationService.Navigate(new Uri("Product.xaml?id=2", UriKind.Relative));
    }
}
