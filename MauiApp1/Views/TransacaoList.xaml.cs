namespace MauiApp1.Views;

public partial class TransacaoList : ContentPage
{
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
        //Navigation.PushModalAsync(new TransacaoAdd());
        Navigation.PushAsync(new TransacaoAdd());
    }
    public void OnButtonClickedEdit(object sender, TappedEventArgs e)
    {
        //Navigation.PushModalAsync(new TransacaoAdd());
        Navigation.PushAsync(new TransacaoEdit());
    }
}