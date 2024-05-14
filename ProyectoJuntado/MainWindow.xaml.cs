using System.Windows;

namespace ProyectoJuntado
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoToEvents_Click(object sender, RoutedEventArgs eventArgs)
        {
            Events.Event eventWindow = new Events.Event();
            eventWindow.Show();
            Close();
        }

        private void GoToLogin_Click(object sender, RoutedEventArgs eventArgse)
        {
            Sesion.LoginWindow loginWindow = new Sesion.LoginWindow();
            loginWindow.Show();
            Close();
        }

        private void GoToPlaylist_Click(object sender, RoutedEventArgs eventArgs)
        {
            Playlists.PlaylistListWindow playlistListWindow = new Playlists.PlaylistListWindow();
            playlistListWindow.Show();
            Close();
        }
    }
}