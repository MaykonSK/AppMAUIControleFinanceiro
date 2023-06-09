using MauiApp1.Views;

namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new TransacaoList(); //aqui chama a página de entrada
        MainPage = new NavigationPage(new TransacaoList());
    }
}
