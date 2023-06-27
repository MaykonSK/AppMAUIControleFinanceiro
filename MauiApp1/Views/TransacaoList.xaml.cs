using Bumptech.Glide.Load.Engine;
using CommunityToolkit.Mvvm.Messaging;
using MauiApp1.DAO;
using MauiApp1.Models;
using MauiApp1.ViewModel;
using Microsoft.Maui;

namespace MauiApp1.Views;

public partial class TransacaoList : ContentPage
{
    private readonly ITransacaoDAO _transacaoDAO;

    public TransacaoList(ITransacaoDAO transacaoDAO)
	{
        _transacaoDAO = transacaoDAO;
		InitializeComponent();
        LoadData();

        //Subscrito (Ouvinte) - Faz algo quando recebe notificação
        WeakReferenceMessenger.Default.Register<Transacao>(this, (e, msg) =>
        {
            LoadData();
        });
    }

    public void LoadData()
    {
        TransacoesList.ItemsSource = _transacaoDAO.GetAll();
    }

	public void OnButtonClickedAdd(object sender, EventArgs args)
	{
        Navigation.PushAsync(new TransacaoAdd(_transacaoDAO));
    }
    public void OnButtonClickedEdit(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new TransacaoEdit());
    }
}