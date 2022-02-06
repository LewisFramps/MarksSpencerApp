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
        id = int.Parse(NavigationService.CurrentSource.ToString()[^1..]);
        switch (id)
        {
            case 1:
                TitleBlock.Text = "Casual Leather shoes ";
                BackgroundImage.ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString("../../../assets/prod1.jpg");
                DescriptionBlock.Text = "Combine smart style with ultimate comfort in these shoes. Smartstep technology used to insert cusioning into the sole!\r\nCrafted from our refined faux suede, you rely on our Derby shoes for both casual and smarter occasions. They have a classic lace-up fastening!";
                NextHintBox.Visibility = Visibility.Hidden;
                break;
            case 2:
                TitleBlock.Text = "Derby Shoes ";
                BackgroundImage.ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString("../../../assets/prod2.jpg");
                DescriptionBlock.Text = "Combine smart style with ultimate comfort in these shoes. Smartstep technology used to insert cusioning into the sole!\r\nCrafted from our refined faux suede, you rely on our Derby shoes for both casual and smarter occasions. They have a classic lace-up fastening and our speical Freshfeet finish to help odours at bay.";
                NextHintBox.Visibility = Visibility.Hidden;
                break;
            case 3:
                TitleBlock.Text = "Towel ";
                BackgroundImage.ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString("../../../assets/towel3.jpg");
                DescriptionBlock.Text = "Welcome the summer with this beach towel. Made from soft and absorbent pure cotton. Our chlorine resistant StayNew™ technology keeps the colours and finish looking fresh, wash after wash. Our new efficient size is easy to pack.";
                NextHintBox.Text = "First letter: P. Click here for the next hint... >";
                break;
            case 4:
                TitleBlock.Text = "Candle ";
                BackgroundImage.ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString("../../../assets/candle4.jpg");
                DescriptionBlock.Text = "Add to the ambience of your room with this light-up candle.";
                NextHintBox.Text = "Final letter: T. Redeem your code in the Sparks hub! >";
                break;
            default:
                break;
        }
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (id < 3)
        {
            Popup.Visibility = Visibility.Visible;
        }
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

    private void NextHintBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        if (id == 3)
        {
            NavigationService.Navigate(new Uri("Hint.xaml?hint=6", UriKind.Relative));
        }
        else
        {
            NavigationService.Navigate(new Uri("Sparks.xaml", UriKind.Relative));
        }
    }
}
