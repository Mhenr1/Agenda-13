namespace Hotel.Views;
using Hotel.Models;
using System.Diagnostics;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;
   
    public ContratacaoHospedagem()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;
        var quartoSelecionado = PropriedadesApp.listaQuartos.FirstOrDefault(q => q.id == PropriedadesApp.quartoId);
        pkr_quarto.ItemsSource = PropriedadesApp.listaQuartos;
        if (quartoSelecionado != null)
        {
            pkr_quarto.SelectedItem = quartoSelecionado;
        }
        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
      
    }
    
    
  

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemInfo());

        }
        catch (Exception ex)
        {
            DisplayAlert("Erro", ex.Message, "Erro");
        }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;
        DateTime data_selecionada_chekin = elemento.Date;
        dtpck_checkout.MinimumDate = data_selecionada_chekin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_chekin.AddMonths(6);
    }

    private void pkr_quarto_SelectedIndexChanged(object sender, EventArgs e)
    {

        PropriedadesApp = (App)Application.Current;
        var picker = sender as Picker;
        var quartoSelecionado = picker.SelectedItem as Quarto;

        if (quartoSelecionado != null)
        {

           
                image_quarto.Source = quartoSelecionado.Imagem;
            
        }
    }
}