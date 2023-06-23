using MauiApp1.DAO;
using MauiApp1.Enums;
using MauiApp1.Models;
using MauiApp1.ViewModel;
using System.Text;

namespace MauiApp1.Views;

public partial class TransacaoAdd : ContentPage
{
    TransacaoAddViewModel _transacaoAddViewModel;
    public TransacaoAdd()
	{
        Title = "Criar Transação";
        _transacaoAddViewModel = new TransacaoAddViewModel(new TransacaoDAO());
        BindingContext = _transacaoAddViewModel;
        InitializeComponent();
    }

	private void OnLabelTapped(object sender, TappedEventArgs e)
	{
        Navigation.PopAsync();
    }

}