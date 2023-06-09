using MauiApp1.Models;

namespace MauiApp1.DAO
{
    public interface ITransacaoDAO
    {
        void Add(Transacao transacao);
        void Delete(Transacao transacao);
        List<Transacao> GetAll();
        void Upgrade(Transacao transacao);
    }
}