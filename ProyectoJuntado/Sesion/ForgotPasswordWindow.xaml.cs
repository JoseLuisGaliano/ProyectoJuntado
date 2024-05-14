using System.Windows;

namespace ProyectoJuntado.Sesion
{
    public partial class ForgotPasswordWindow : Window
    {
        public ForgotPasswordWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            Close();
        }

        private void SendResetLinkButton_Click(object sender, RoutedEventArgs e)
        {
            string email = emailTextBox.Text;

            if (SesionLogic.IsValidEmail(email))
            {
                // Send email with restore link here (to do)
                MessageBox.Show("Se ha enviado un correo con el enlace para restablecer la contraseña.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Por favor, introduce una dirección de correo electrónico válida.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
