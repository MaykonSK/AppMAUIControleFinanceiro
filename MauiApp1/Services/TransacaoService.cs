using MauiApp1.DAO;
using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    public class TransacaoService : ITransacaoDAO
    {
        public void Add(Transacao transacao)
        {
            
        }

        public void Delete(Transacao transacao)
        {
            throw new NotImplementedException();
        }

        public List<Transacao> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Upgrade(Transacao transacao)
        {
            throw new NotImplementedException();
        }
    }
}
