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
using System.Windows.Shapes;

namespace audiopleer
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private List<string> playHistory;

        public Window1(List<string> historyItems)
        {
            InitializeComponent();
            playHistory = historyItems;
            historyListBox.ItemsSource = playHistory;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedSong = historyListBox.SelectedItem as string;
            int index = playHistory.IndexOf(selectedSong);
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (mainWindow != null)
            {
                mainWindow.PlayAudio(index);
                DialogResult = true;
            }
        }

    }
}
