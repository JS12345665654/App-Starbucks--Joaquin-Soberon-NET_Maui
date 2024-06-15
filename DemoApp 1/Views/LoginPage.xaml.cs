namespace DemoApp_1.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void btnIngresar_Clicked (object sender, EventArgs e)
    {
        if (entLoginEmail.Text == "alumno" && entLoginPassword.Text == "1234")
        {
            entLoginPassword.Text = string.Empty;
            entLoginEmail.Text = string.Empty;
            Navigation.PushAsync(new MainPage());
        }
        else
        {
            entLoginPassword.Text = string.Empty;
            entLoginEmail.Text = string.Empty;
            DisplayAlert("Atención", "las credenciales ingresadas no son válidas", "OK");
        }

    }
}