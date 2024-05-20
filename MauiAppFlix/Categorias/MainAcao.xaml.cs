namespace MauiAppFlix.Categorias;

public partial class acao : ContentPage
{
	public acao()
	{
		InitializeComponent();
	}

    private void btnMiranha_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.miranha());

        }
        catch (Exception ex)
        {
            DisplayAlert("Não encontrado", ex.Message, "OK");
        }
    }

    private void btnValozesdez_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.velozes());

        }
        catch (Exception ex)
        {
            DisplayAlert("Não encontrado", ex.Message, "OK");
        }
    }

    private void btnEsquadraoseis_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.esquadraoseis());

        }
        catch (Exception ex)
        {
            DisplayAlert("Não encontrado", ex.Message, "OK");
        }
    }
}