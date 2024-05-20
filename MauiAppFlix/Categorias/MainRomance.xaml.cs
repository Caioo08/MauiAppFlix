namespace MauiAppFlix.Categorias;

public partial class Romance : ContentPage
{
	public Romance()
	{
		InitializeComponent();
	}

    private void btnEnquanto_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.enquanto());

        }
        catch (Exception ex)
        {
            DisplayAlert("Não encontrado", ex.Message, "OK");
        }

    }

    private void btnAntesdevoce_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.antesdevoce());

        }
        catch (Exception ex)
        {
            DisplayAlert("Não encontrado", ex.Message, "OK");
        }
    }

    private void btnRedencao_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.redencao());

        }
        catch (Exception ex)
        {
            DisplayAlert("Não encontrado", ex.Message, "OK");
        }
    }
}