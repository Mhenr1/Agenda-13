
namespace Hotel.Views
{
    public partial class Index : ContentPage
    {
        App PropriedadesApp;
        public Index()
        {
            InitializeComponent();
            PropriedadesApp = (App)Application.Current;

        }


        private void onTaped(object sender, EventArgs e)
        {
            var gesture = (TappedEventArgs)e;
            var stack = (StackLayout)sender;
            var id = stack.GestureRecognizers[0] is TapGestureRecognizer tap ? tap.CommandParameter : -1;
            PropriedadesApp.quartoId = int.Parse((string)id);

            Navigation.PushAsync(new ContratacaoHospedagem());
        }
        private void Navegar_sobre(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sobre());
        }


    }
}