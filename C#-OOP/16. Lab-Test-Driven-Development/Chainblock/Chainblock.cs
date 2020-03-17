using Chainblock.Contracts;

namespace Chainblock
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Chainblock : IChainblock
    {
        private readonly Dictionary<int, ITransaction> transactionsById;

        public Chainblock()
        {
            this.transactionsById = new Dictionary<int, ITransaction>();
        }

        public int Count => this.transactionsById.Count;

        public void Add(ITransaction tx)
        {
            if (this.Contains(tx.Id))
            {
                throw new InvalidOperationException($"Transaction with {tx.Id} already exists.");
            }

            this.transactionsById.Add(tx.Id, tx);
        }

        public void ChangeTransactionStatus(int id, TransactionStatus newStatus)
        {
            if (!this.Contains(id))
            {
                throw new ArgumentException();
            }

            ITransaction transaction = this.GetById(id);
            transaction.Status = newStatus;
        }

        public bool Contains(ITransaction tx) => this.Contains(tx.Id);

        public bool Contains(int id) => this.transactionsById.ContainsKey(id);

        public IEnumerable<ITransaction> GetAllInAmountRange(double lo, double hi)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ITransaction> GetAllOrderedByAmountDescendingThenById()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<string> GetAllReceiversWithTransactionStatus(TransactionStatus status)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<string> GetAllSendersWithTransactionStatus(TransactionStatus status)
        {
            var filtered = this.transactionsById
                .Values
                .Where(t => t.Status == status)
                .OrderByDescending(t => t.Amount)
                .Select(t => t.From)
                .ToArray();

            if (filtered.Length == 0)
            {
                throw new InvalidOperationException();
            }

            return filtered;
        }

        public ITransaction GetById(int id)
        {
            if (!this.Contains(id))
            {
                throw new InvalidOperationException($"Transaction with {id} doesn't exist.");
            }

            return this.transactionsById[id];
        }

        public IEnumerable<ITransaction> GetByReceiverAndAmountRange(string receiver, double lo, double hi)
        {
            var filtered = this.transactionsById
                .Values
                .Where(t => t.To == receiver && t.Amount >= lo && t.Amount < hi)
                .OrderByDescending(t => t.Amount)
                .ThenBy(t => t.Id)
                .ToArray();

            if (filtered.Length == 0)
            {
                throw new InvalidOperationException();
            }

            return filtered;
        }

        public IEnumerable<ITransaction> GetByReceiverOrderedByAmountThenById(string receiver)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ITransaction> GetBySenderAndMinimumAmountDescending(string sender, double amount)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ITransaction> GetBySenderOrderedByAmountDescending(string sender)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ITransaction> GetByTransactionStatus(TransactionStatus status)
        {
            var filteredTransactions = this.transactionsById.Values
                .Where(v => v.Status == status)
                .OrderByDescending(tx => tx.Amount)
                .ToArray();

            if(filteredTransactions.Length == 0)
            {
                throw new InvalidOperationException();
            }

            return filteredTransactions;
        }

        public IEnumerable<ITransaction> GetByTransactionStatusAndMaximumAmount(TransactionStatus status, double amount)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator<ITransaction> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveTransactionById(int id)
        {
            if (!this.Contains(id))
            {
                throw new InvalidOperationException();
            }

            this.transactionsById.Remove(id);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
