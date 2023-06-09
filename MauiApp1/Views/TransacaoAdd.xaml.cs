using MauiApp1.DAO;
using MauiApp1.Enums;
using MauiApp1.Models;
using System.Text;

namespace MauiApp1.Views;

public partial class TransacaoAdd : ContentPage
{

    public TransacaoAdd()
	{
		InitializeComponent();
        Title = "Criar Transação";
    }

	private void OnLabelTapped(object sender, TappedEventArgs e)
	{
        Navigation.PopAsync();
    }

    private void Salvar(object sender, EventArgs e)
    {

        if (IsValidData())
        {
            Transacao transacao = new Transacao();
            transacao.Tipo = receita.IsChecked ? TransacaoTipo.Receita : TransacaoTipo.Despesa;
            transacao.Nome = nome.Text;
            transacao.Data = data.Date;
            transacao.Valor = Double.Parse(valor.Text);

            //_transacaoDAO.Add(transacao);

            App.Current.MainPage.DisplayAlert("Sucesso", "Dados salvo com sucesso", "Ok");
        }

        return;

    }

    private bool IsValidData()
    {
        bool valid = true;
        StringBuilder sb = new StringBuilder();

        if (string.IsNullOrEmpty(nome.Text)) {

            sb.AppendLine("O campo Nome deve ser preenchido!");
            valid = false; 
        }
        if (string.IsNullOrEmpty(valor.Text))
        {
            sb.AppendLine("O campo Valor deve ser preenchido!");
            valid = false;
        }

        if (valid == false)
        {
            labelError.Text = sb.ToString();
            labelError.IsVisible = true;
        }

        return valid;
        
    }
}