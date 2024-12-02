using System;
using Xamarin.Forms;

namespace LoginApp.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        // Méthode déclenchée lorsque le bouton "Se connecter" est cliqué
        private void OnLoginClicked(object sender, EventArgs e)
        {
            // Récupère le nom d'utilisateur
            string username = UsernameEntry.Text;
            // Récupère le mot de passe
            string password = PasswordEntry.Text;
            // Validation simple pour s'assurer que les champs ne sont pas vides
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                DisplayAlert("Erreur", "Veuillez entrer un nom d'utilisateur et un mot de passe.", "OK");
            }
            else
            {
                // Logique d'authentification (simulée ici)
                if (username == "admin" && password == "password")
                {
                    DisplayAlert("Succès", "Connexion réussie!", "OK");
                    // Rediriger vers la page principale ou une autre page de l'application
                    Navigation.PushAsync(new MainPage());
                }
                else
                {
                    DisplayAlert("Erreur", "Nom d'utilisateur ou mot de passe incorrect.", "OK");
                }
            }
        }

    }
}
