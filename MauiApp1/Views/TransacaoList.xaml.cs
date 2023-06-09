namespace MauiApp1.Views;

public partial class TransacaoList : ContentPage
{
	public TransacaoList()
	{
		InitializeComponent();
    }

	public void OnButtonClickedAdd(object sender, EventArgs args)
	{
		App.Current.MainPage = new TransacaoAdd();
        App.Current.MainPage = new NavigationPage(new TransacaoAdd());
    }
}