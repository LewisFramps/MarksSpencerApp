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
        Title1.Text = searchTermLower == "towel" ? "Egyptian Towel Luxury" : "Legit Candle But It's LED";
        Title2.Text = capitalized + " 2";
        Title3.Text = capitalized + " 3";
        Title4.Text = capitalized + " 4";
        Image1.Source = (ImageSource)new ImageSourceConverter().ConvertFromString($"../../../assets/{searchTermLower}1.jpg");
        Image2.Source = (ImageSource)new ImageSourceConverter().ConvertFromString($"../../../assets/{searchTermLower}2.jpg");
        Image3.Source = (ImageSource)new ImageSourceConverter().ConvertFromString($"../../../assets/{searchTermLower}3.jpg");
        Image4.Source = (ImageSource)new ImageSourceConverter().ConvertFromString($"../../../assets/{searchTermLower}4.jpg");
        Description1.Text = searchTermLower == "towel" ? "Snuggle into pure luxry with our Egyptian cotton towel. Fluffy and ultra-plush, this design is perfect for daily use. With its super-soft feel and plush texture, this towel feels like luxury against the skin." : "Create a luxurious spa experience at home with the soothing aroma of this richly scented candle. Our Calm candle is crafted with sweet orange and lavender essential oils, given a note of warmth with cedar wood and a dash of tranquillity from clary sage.";
        Description2.Text = searchTermLower == "towel" ? "The lightweight design is absorbent without being heavy, and it dries fast, making it perfect for everyday use.We've added StayNew™ technology to keep your towel looking good as new, wash after wash." : "Create a relaxing ambience on date night with this scented candle set.";
        Description3.Text = searchTermLower == "towel" ? "Welcome the summer with this beach towel. Made from soft and absorbent pure cotton. Our chlorine resistant StayNew™ technology keeps the colours and finish looking fresh, wash after wash. Our new efficient size is easy to pack." : "Part of our exclusive Apothecary range, this Tranquil candle fills the room with soothing notes.";
        Description4.Text = searchTermLower == "towel" ? "Ready to pack your trunk? This green towel features a charming print and is made to our new efficient size, perfect for fitting into a suitcase. Our StayNew™ technology keeps the colours and finish looking fresh." : "Add to the ambience of your room with this light-up candle.";
    }

    private void StackPanel3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        if (searchTermLower == "towel")
        {
            NavigationService.Navigate(new Uri($"Product.xaml?id=3", UriKind.Relative));
        }
    }

    private void StackPanel4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        if (searchTermLower == "candle")
        {
            NavigationService.Navigate(new Uri($"Product.xaml?id=4", UriKind.Relative));
        }
    }


}
