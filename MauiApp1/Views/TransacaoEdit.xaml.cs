namespace MauiApp1.Views;

public partial class TransacaoEdit : ContentPage
{
	public TransacaoEdit()
	{
		InitializeComponent();
        Title = "Editar Transa��o";
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PopAsync();
    }
}