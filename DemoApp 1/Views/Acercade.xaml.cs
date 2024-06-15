namespace DemoApp_1.Views;

public partial class Acercade : ContentPage
{
	public Acercade()
	{
		InitializeComponent();
	}

    private void btn_volver_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }

    private void btn_salir_al_login_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LoginPage());
    }
}