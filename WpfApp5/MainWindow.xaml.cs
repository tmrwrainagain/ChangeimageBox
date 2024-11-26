using System.Windows;
using System.Windows.Media.Imaging;

namespace ImageChangeApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void checkBox_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (checkBox.IsChecked == true)
            {
                // Изменение картинки при отметке флажка
                image.Source = new BitmapImage(new Uri("Images/image1.jpeg"));
            }
            else
            {
                // Возврат к начальной картинке при снятии флажка
                image.Source = new BitmapImage(new Uri("Images/image2.jpeg"));
            }
        }
    }
}
