using Microsoft.Maui.Controls;

namespace Habitus;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string email = EmailEntry.Text?.Trim();
        string password = PasswordEntry.Text;

        if (email == "litterinijuanc@gmail.com" && password == "1234")
        {
            await DisplayAlert("�xito", "Inicio de sesi�n exitoso", "OK");
           
            await Navigation.PushAsync(new MenuPage());
        }
        else
        {
            await DisplayAlert("Error", "Email o contrase�a incorrectos", "OK");
        }
    }
}
