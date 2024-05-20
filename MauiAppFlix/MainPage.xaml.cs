namespace MauiAppFlix
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.acao());

            }
            catch (Exception ex)
            {
                DisplayAlert("Não encontrado", ex.Message, "OK");
            }
        }

        private void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.aventura());

            }
            catch (Exception ex)
            {
                DisplayAlert("Não encontrado", ex.Message, "OK");
            }
        }

        private void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Romance());

            }
            catch (Exception ex)
            {
                DisplayAlert("Não encontrado", ex.Message, "OK");
            }
        }

        private void Button_Clicked_3(System.Object sender, System.EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Terror());

            }
            catch (Exception ex)
            {
                DisplayAlert("Não encontrado", ex.Message, "OK");
            }
        }
    }

}
