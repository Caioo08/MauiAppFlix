namespace MauiAppFlix.Categorias;

public partial class aventura : ContentPage
{
	public aventura()
	{
		InitializeComponent();
	}

    private void btnTomb_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.lara());

        }
        catch (Exception ex)
        {
            DisplayAlert("Não encontrado", ex.Message, "OK");
        }
    }

    private void Uncharted_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.uncharted());

        }
        catch (Exception ex)
        {
            DisplayAlert("Não encontrado", ex.Message, "OK");
        }
    }

    private void btnIndiana_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.indiana());

        }
        catch (Exception ex)
        {
            DisplayAlert("Não encontrado", ex.Message, "OK");
        }
    }
}