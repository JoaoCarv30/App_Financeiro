namespace Finance_app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string email = EntryEmail.Text;
            string Password = EntryPassword.Text;

            //Teste

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(Password))
            {
                ErrorMsg.Text = "Preencha todos os campos";
                ErrorMsg.IsVisible = true;
                return;

            }

            if (email == "juan@maui.com" && Password == "1234")
            {
                ErrorMsg.IsVisible = false;
                await Navigation.PushAsync(new MainPage());

            }

            else
            {
                ErrorMsg.Text = "Suas credenciais são inválidas.";
                ErrorMsg.IsVisible = true;

            }
        }
    }

}
