using DemoApp_1.Views;

namespace DemoApp_1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        
        private void btn_acercade_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Acercade());
        }

        private void btn_llamar_Clicked(object sender, EventArgs e)
        {
            string telefono = "+542954518184";
            PhoneDialer.Default.Open(telefono);
        }

        private async void btn_enviar_correo_Clicked(object sender, EventArgs e)
        {
            var menssage = new EmailMessage
            {
                Subject = "Asunto del correo",
                Body = "Pongamonos en contacto",
                To = new List<string> { "joaquinsobeperez@gmail.com" }
            };

            await Email.ComposeAsync(menssage);
        }
        private void btn_salir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    } 

}
