using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModel
{
    public partial class TransacaoEditViewModel : ObservableObject
    {
        readonly ITransacaoDAO _transacaoDAO;

        [ObservableProperty]
        private string _nome;

        [ObservableProperty]
        private DateTime _data;

        [ObservableProperty]
        private bool _receita;

        [ObservableProperty]
        private string _valor;

        public TransacaoEditViewModel(ITransacaoDAO transacaoDAO)
        {
            _transacaoDAO = transacaoDAO;
        }

        [RelayCommand]
        public void Editar()
        {

        }
    }
}
