using MauiApp1.ViewModel;

namespace MauiApp1.Views;

public partial class TransacaoList : ContentPage
{
    private readonly TransacaoAddViewModel _viewModel;

    public List<string> items { get; set; }

    public TransacaoList()
	{
		InitializeComponent();

        items = new List<string>
        {
            "Item 1",
            "Item 2",
            "Item 3",
        };

        BindingContext = this;
    }

	public void OnButtonClickedAdd(object sender, EventArgs args)
	{
        Navigation.PushModalAsync(new TransacaoAdd());
    }
    public void OnButtonClickedEdit(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new TransacaoEdit());
    }
}