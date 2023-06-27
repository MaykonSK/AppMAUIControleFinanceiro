using MauiApp1.DAO;
using MauiApp1.Views;

namespace MauiApp1;

public partial class App : Application
{
    private readonly ITransacaoDAO _transacaoDAO;

    public App(ITransacaoDAO transacaoDAO)
    {
        _transacaoDAO = transacaoDAO;
        InitializeComponent();

        MainPage = new NavigationPage(new TransacaoList(_transacaoDAO));
    }

}
