using Hotel.Models;

namespace Hotel
{
    public partial class App : Application
    {
        public List<Quarto> listaQuartos = new List<Quarto>{

        new Quarto{ id=0, Descricao="Suíte Super Luxo", ValorDiariaAldulto=100.00, ValorDiariaCrianca=50.00 , Imagem="suitesluxo.jpg"},
        new Quarto{ id=1,Descricao="Suíte Luxo", ValorDiariaAldulto=80.00, ValorDiariaCrianca=40.00 ,Imagem="suiteluxo.jpg" },
        new Quarto{ id=2,Descricao="Suíte Single", ValorDiariaAldulto=50.00, ValorDiariaCrianca=25.00 , Imagem="suitesingle.jpg"},
        new Quarto{ id=3, Descricao="Quarto Standard", ValorDiariaAldulto=30.00, ValorDiariaCrianca=15.00 ,Imagem="suitestandard.jpg" }
        };
        public int quartoId;
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Views.Index());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 600;
            return window;
        }
    }
}