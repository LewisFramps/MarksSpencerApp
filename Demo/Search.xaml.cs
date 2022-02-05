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
/// Interaction logic for Search.xaml
/// </summary>
public partial class Search : Page
{
    string searchTermRaw, searchTermLower;

    public Search()
    {
        InitializeComponent();
        Loaded += Page_Loaded;
    }

    private void Page_Loaded(object sender, RoutedEventArgs e)
    {
        searchTermRaw = NavigationService.CurrentSource.ToString().Split("=")[1];
        searchTermLower = searchTermRaw.ToLower();
        TitleBlock.Text = $"Search results: {searchTermRaw}";
        QuantityBlock.Text = $"{(searchTermLower == "towel" ? "1,919" : "114,514")} items found";

        string capitalized = $"{char.ToUpper(searchTermRaw[0])}{searchTermLower[1..]}";
        Title1.Text = capitalized + '1';
        Title2.Text = capitalized + '2';
        Title3.Text = capitalized + '3';
        Title4.Text = capitalized + '4';
        Image1.Source = (ImageSource)new ImageSourceConverter().ConvertFromString($"../../../assets/{searchTermLower}1.jpg");
        Image2.Source = (ImageSource)new ImageSourceConverter().ConvertFromString($"../../../assets/{searchTermLower}2.jpg");
        Image3.Source = (ImageSource)new ImageSourceConverter().ConvertFromString($"../../../assets/{searchTermLower}3.jpg");
        Image4.Source = (ImageSource)new ImageSourceConverter().ConvertFromString($"../../../assets/{searchTermLower}4.jpg");
    }

    private void StackPanel3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        if (searchTermLower == "towel")
        {
            NavigationService.Navigate(new Uri($"Product.xaml?id=3", UriKind.Relative));
        }
    }

    private void StackPane2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        if (searchTermLower == "candle")
        {
            NavigationService.Navigate(new Uri($"Product.xaml?id=4", UriKind.Relative));
        }
    }


}
