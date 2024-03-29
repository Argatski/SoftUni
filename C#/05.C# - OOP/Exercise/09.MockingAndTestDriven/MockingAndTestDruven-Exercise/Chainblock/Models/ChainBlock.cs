﻿using Chainblock.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Chainblock.Models
{
    public class ChainBlock : IChainblock
    {
        private readonly Dictionary<int, ITransaction> _transactions;

        public ChainBlock()
        {
            this._transactions = new Dictionary<int, ITransaction>();
        }
        public int Count => this._transactions.Count;

        public void Add(ITransaction tx)
        {
            if (this._transactions.ContainsKey(tx.Id))
            {
                throw new InvalidOperationException();
            }
            else
            {
                _transactions.Add(tx.Id, tx);
            }
        }

        public void ChangeTransactionStatus(int id, TransactionStatus newStatus)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id cannot be less or queal to 0");
            }
            if (Enum.IsDefined(typeof(TransactionStatus), newStatus) == false)
            {
                throw new InvalidOperationException();
            }
            if (this._transactions.ContainsKey(id) == false)
            {
                throw new ArgumentException();
            }

            var transaction = this._transactions[id];

            if (transaction.Status == newStatus)
            {
                throw new InvalidOperationException();
            }
            transaction.Status = newStatus;
        }

        public bool Contains(ITransaction tx)
        {
            if (this._transactions.ContainsValue(tx))
            {
                return true;
            }
            return false;
        }

        public bool Contains(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException();
            }
            if (this._transactions.ContainsKey(id))
            {
                return true;
            }

            return false;
        }

        public IEnumerable<ITransaction> GetAllInAmountRange(double lo, double hi)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetAllOrderedByAmountDescendingThenById()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllReceiversWithTransactionStatus(TransactionStatus status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllSendersWithTransactionStatus(TransactionStatus status)
        {
            throw new NotImplementedException();
        }

        public ITransaction GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetByReceiverAndAmountRange(string receiver, double lo, double hi)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetByReceiverOrderedByAmountThenById(string receiver)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetBySenderAndMinimumAmountDescending(string sender, double amount)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetBySenderOrderedByAmountDescending(string sender)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetByTransactionStatus(TransactionStatus status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetByTransactionStatusAndMaximumAmount(TransactionStatus status, double amount)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<ITransaction> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void RemoveTransactionById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
