namespace Hotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private void Navegar_sobre(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Sobre());
    }

  
}