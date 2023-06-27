using MauiApp1.DAO;
using MauiApp1.Enums;
using MauiApp1.Models;
using MauiApp1.ViewModel;
using System.Text;

namespace MauiApp1.Views;

public partial class TransacaoAdd : ContentPage
{
    TransacaoAddViewModel _transacaoAddViewModel;
    ITransacaoDAO _transacaoDAO;

    public TransacaoAdd(ITransacaoDAO transacaoDAO)
	{
        Title = "Criar Transação";
        _transacaoDAO = transacaoDAO;
        _transacaoAddViewModel = new TransacaoAddViewModel(transacaoDAO);
        BindingContext = _transacaoAddViewModel;
        InitializeComponent();
    }

	private void OnLabelTapped(object sender, TappedEventArgs e)
	{
        Navigation.PopAsync();
    }

}