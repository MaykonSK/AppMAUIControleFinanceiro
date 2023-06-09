using LiteDB;
using MauiApp1.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.DAO
{
    public class TransacaoDAO : ITransacaoDAO
    {

        private readonly LiteDatabase _dataBase;
        private readonly string colletionName = "transacoes";

        public TransacaoDAO(LiteDatabase database)
        {
            _dataBase = database;
        }

        public List<Transacao> GetAll()
        {
            var col = _dataBase.GetCollection<Transacao>(colletionName);
            return col.Query().OrderByDescending(x => x.Data).ToList();
        }
        public void Add(Transacao transacao)
        {
            var col = _dataBase.GetCollection<Transacao>(colletionName);
            col.Insert(transacao);

            //Adicionar index na data da transao apos inserir
            col.EnsureIndex(x => x.Data);
        }
        public void Upgrade(Transacao transacao)
        {
            var col = _dataBase.GetCollection<Transacao>(colletionName);
            col.Update(transacao);
        }
        public void Delete(Transacao transacao)
        {
            var col = _dataBase.GetCollection<Transacao>(colletionName);
            col.Delete(transacao.Id);
        }
    }
}
