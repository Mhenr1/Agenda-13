namespace Hotel.Views;

public partial class HospedagemInfo : ContentPage
{
	public HospedagemInfo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try {
			Navigation.PushAsync(new ContratacaoHospedagem());
		}
		catch(Exception ex)
		{
            DisplayAlert("Erro", ex.Message, "Erro");
        }

	}
}