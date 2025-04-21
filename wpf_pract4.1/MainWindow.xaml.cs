using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_pract4._1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public static readonly RoutedCommand CustomCommand = new RoutedCommand();

    private void txtEditor_SelectionChanged(object sender, RoutedEventArgs e)
    {
        int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
        int col = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row);

        lblCursorPosition.Text = $"Рядок {row + 1}, Символ {col + 1}";
    }
}