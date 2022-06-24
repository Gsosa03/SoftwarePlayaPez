using System.Windows;

namespace PlayaPez
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEstadistica(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page.Estadistica();
        }

        private void BtnOxigeno(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page.SensorOxigeno();
        }

        private void Mostrar(object sender, RoutedEventArgs e)
        {

        }

        private void Ocultar(object sender, RoutedEventArgs e)
        {

        }
    }
}
