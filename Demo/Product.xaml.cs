using System;
using System.Collections.Generic;
using System.Diagnostics;
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
/// Interaction logic for Product.xaml
/// </summary>
public partial class Product : Page
{
    int id;

    public Product()
    {
        InitializeComponent();
        Loaded += Page_Loaded;
    }

    private void Page_Loaded(object sender, RoutedEventArgs e)
    {
        id = NavigationService.CurrentSource.ToString()[^1] == '1' ? 1 : 2;
        if (id == 1)
        {
            TitleBlock.Text = "Product Name 1";
            BackgroundImage.ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString("../../../assets/prod1.jpg");
        }
        else
        {
            TitleBlock.Text = "Product Name 2";
            BackgroundImage.ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString("../../../assets/prod2.jpg");
        }
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Popup.Visibility = Visibility.Visible;
    }

    private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });
        e.Handled = true;
    }

    private void Popup_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        NavigationService.Navigate(new Uri("Hint.xaml?hint=1", UriKind.Relative));
    }
}
