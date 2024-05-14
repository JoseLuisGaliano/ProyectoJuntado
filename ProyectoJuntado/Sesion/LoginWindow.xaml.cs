using System.Windows;

namespace ProyectoJuntado.Sesion
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Get login values
            string email = emailTextBox.Text;
            string password = passwordBox.Password;

            // Verify user existence in the database
            bool userExists = Database.DatabaseManager.VerifyUserLogin(email, password);
            if (userExists)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                // Go to playlists window
                Playlists.PlaylistListWindow playlistList = new Playlists.PlaylistListWindow();
                playlistList.Show();

                // Close login window
                Close();
             }
             else
             {
                    MessageBox.Show("Login failed. Please check your email and password.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
             }
        }

        private void ForgotPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            ForgotPasswordWindow forgotPasswordWindow = new ForgotPasswordWindow();
            forgotPasswordWindow.Show();
            Close();
        }

        private void SignUpHyperlink_Click(object sender, RoutedEventArgs e)
        {
            SignUpWindow signUpWindow = new SignUpWindow();
            signUpWindow.ShowDialog();
            Close();
        }
    }
}

