using CommunityToolkit.Mvvm.Messaging;
using MauiApp1.DAO;
using MauiApp1.Enums;
using MauiApp1.Models;
using System.Text;

namespace MauiApp1.ViewModel
{
    public class TransacaoAddViewModel : BaseViewModel
    {
        readonly ITransacaoDAO _transacaoDAO;

        public Command Salvar { get; set; }

        private string _nome;
        public string nome
        {
            get { return _nome; }
            set { _nome = value; OnPropertyChanged(); }
        }

        private DateTime _data;
        public DateTime data
        {
            get { return _data; }
            set { _data = value; OnPropertyChanged(); }
        }

        private bool _receita;
        public bool receita
        {
            get { return _receita; }
            set { _receita = value; OnPropertyChanged(); }
        }

        private string _valor;
        public string valor
        {
            get { return _valor; }
            set { _valor = value; OnPropertyChanged(); }
        }

        public TransacaoAddViewModel(ITransacaoDAO transacaoDAO)
        {
            _transacaoDAO = transacaoDAO;
            data = DateTime.Now;
            Salvar = new Command(SalvarAction);
        }

        private void SalvarAction()
        {
            if (IsValidData())
            {
                Transacao transacao = new Transacao();
                transacao.Tipo = receita ? TransacaoTipo.Receita : TransacaoTipo.Despesa;
                transacao.Nome = nome;
                transacao.Data = data;
                transacao.Valor = Double.Parse(valor);

                _transacaoDAO.Add(transacao);

                App.Current.MainPage.DisplayAlert("Sucesso", "Dados salvo com sucesso", "Ok");

                //Publicador - Manda notificação para todos os ouvintes
                WeakReferenceMessenger.Default.Send<Transacao>(transacao);
            }

            return;
        }

        private bool IsValidData()
        {
            bool valid = true;
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(nome))
            {

                sb.AppendLine("O campo nome deve ser preenchido!");
                valid = false;
            }
            if (string.IsNullOrEmpty(valor))
            {
                sb.AppendLine("O campo valor deve ser preenchido!");
                valid = false;
            }

            if (valid == false)
            {
                App.Current.MainPage.DisplayAlert("Falha", sb.ToString(), "Ok");
            }

            return valid;

        }

    }
}
