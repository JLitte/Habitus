namespace Habitus;

public partial class MenuPage : ContentPage
{
    public MenuPage()
    {
        InitializeComponent();
    }

    private async void OnMisDatosClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MisDatosPage());
    }

    private async void OnMisHabitosClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MisHabitosPage());
    }

    private async void OnHabitusClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HabitusPage());
    }

    private async void OnCerrarSesionClicked(object sender, EventArgs e)
    {
        // Aquí podrías agregar lógica de cierre de sesión
        Application.Current.MainPage = new NavigationPage(new LoginPage()); // O redirigir a la página de login
    }
}
