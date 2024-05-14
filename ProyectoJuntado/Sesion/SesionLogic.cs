namespace ProyectoJuntado.Sesion
{
    internal class SesionLogic
    {
        internal static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            try
            {
                // The MailAddress class can be used to validate the email format
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        internal static bool IsValidPassword(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }
    }
}
