using LiteDB;
using MauiApp1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class Transacao
    {
        [BsonId]
        public int Id { get; set; }
        public TransacaoTipo Tipo { get; set; }
        public string Nome { get; set; }
        public DateTimeOffset Data { get; set; }
        public double Valor { get; set; }
    }
}
