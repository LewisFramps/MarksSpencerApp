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
/// Interaction logic for Hint.xaml
/// </summary>
public partial class Hint : Page
{
    int hintNumber;

    public Hint()
    {
        InitializeComponent();
        Loaded += Page_Loaded;
    }

    private void Page_Loaded(object sender, RoutedEventArgs e)
    {
        hintNumber = NavigationService.CurrentSource.ToString()[^1] == '1' ? 1 : 6;
        TitleBlock.Text = $"Hint {hintNumber}/6";
        HintText.Text = hintNumber == 1 ? "What gets wetter the more it dries? " : "I’m tall when I’m young, and I’m short when I’m old. What am I? ";
    }

    private void TextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Return)
        {
            NavigationService.Navigate(new Uri($"Search.xaml?q={SearchBox.Text}", UriKind.Relative));
        }
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        NavigationService.Navigate(new Uri($"Search.xaml?q={SearchBox.Text}", UriKind.Relative));
    }
}
