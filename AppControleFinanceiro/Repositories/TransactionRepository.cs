using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AppControleFinanceiro.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly LiteDatabase _database;
        private readonly string collectioName = "transaction";
        public TransactionRepository()
        {
           _database = new LiteDatabase("Filename=C:/users/AppData/database.db;Connection=Shared");
        }
        public List<Transaction> GetAll()
        {
            _database.GetCollection<Transaction>(collectioName);
        }

        public void Add(Transaction transaction)
        {

        }

        public void Update(Transaction transaction)
        {

        }
        public void Delete(Transaction transaction)
        {

        }

    }
}
