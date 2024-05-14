using System.Windows;

namespace ProyectoJuntado.Sesion
{
    public partial class SignUpWindow : Window
    {
        public SignUpWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            Close();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordBox.Password;
            string confirmPassword = confirmPasswordBox.Password;

            if (SesionLogic.IsValidEmail(email) && SesionLogic.IsValidPassword(password, confirmPassword))
            {
                Database.DatabaseManager.SaveUser(username, email, password);
                MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Por favor, introduce información válida.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

