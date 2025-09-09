using System.Windows;
using System.Windows.Media.Animation;

namespace Locomotiva
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var sb = (Storyboard)FindResource("AnimacaoLocomotiva");
            sb.Begin(this, true);
        }
    }
}
