using System.Windows;
using ScriptsClassLibrary;

namespace Bacteria
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void ButtonGenerater_Click(object sender, RoutedEventArgs e) => VariableMover.MethodForMovingVariables(CenterScrin_GridNull, TextBoxGenerator, TextBlockGenerator);

        private void ButtonColorBlock_Click(object sender, RoutedEventArgs e) => Marker.MethodMarker();
    }
}