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
/// Interaction logic for Sparks.xaml
/// </summary>
public partial class Sparks : Page
{
    public Sparks()
    {
        InitializeComponent();
    }

    private void CodeBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (CodeBox.Text.ToLower() == "profit")
        {
            Popup.Visibility = Visibility.Visible;
        }
    }

    private void ApplyButton_Click(object sender, RoutedEventArgs e)
    {
        ApplyButton.Content = "Voucher added!";
        ApplyButton.IsEnabled = false;
    }
}
