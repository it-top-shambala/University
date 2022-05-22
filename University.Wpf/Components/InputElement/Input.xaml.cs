using System.Windows.Controls;

namespace University.Wpf.Components.InputElement;

public partial class Input : UserControl
{
    public Input(string key, string value)
    {
        InitializeComponent();

        Label.Content = key;
        InputT.Text = value;
    }
}