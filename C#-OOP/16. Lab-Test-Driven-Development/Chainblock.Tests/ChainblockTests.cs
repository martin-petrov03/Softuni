using Chainblock.Contracts;

namespace Chainblock.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ChainblockTests
    {
        private IChainblock chainblock;

        [SetUp]
        public void Initialize()
        {
            this.chainblock = new Chainblock();
        }

        [Test]
        public void AddingTransactionWithNonExistingTransactionIdShouldIncreaseCount()
        {
            ITransaction dummyTransation = new Transaction(1, TransactionStatus.Aborted, "me", "my friend", 1234.0);

            IChainblock chainblock = new Chainblock();

            chainblock.Add(dummyTransation);

            Assert.That(
                chainblock.Count,
                Is.EqualTo(1),
                "Count should be increased and equal to 1."
            );
        }

        [Test]
        public void AddingTransactionWithExistingIdShouldThrowException()
        {
            ITransaction dummyTransation = new Transaction(1, TransactionStatus.Aborted, "me", "my friend", 1234.0);

            this.chainblock.Add(dummyTransation);
            Assert.Throws<InvalidOperationException>(
                () => this.chainblock.Add(dummyTransation),
                "This transaction id already exists.");

            Assert.That(
                chainblock.Count,
                Is.EqualTo(1),
                "The count shouldn't increase with invalid Add operation");
        }

        [Test]
        public void ContainsByIdShouldReturnTrueWithExistingTransaction()
        {
            int txId = 1;
            ITransaction dummyTransation = new Transaction(txId, TransactionStatus.Aborted, "me", "my friend", 1234.0);

            this.chainblock.Add(dummyTransation);

            Assert.That(
                this.chainblock.Contains(txId),
                Is.EqualTo(true),
                "Contains should return true with existing transaction.");
        }

        [Test]
        public void ContainsByIdShouldReturnFalseWithNonExistingTransaction()
        {
            ITransaction dummyTransation = new Transaction(1, TransactionStatus.Aborted, "me", "my friend", 1234.0);

            this.chainblock.Add(dummyTransation);

            Assert.That(
                this.chainblock.Contains(2),
                Is.EqualTo(false),
                "Contains should return false with non existing transaction.");
        }

        [Test]
        public void ContainsByTxShouldReturnTrueWithExistingTransaction()
        {
            ITransaction dummyTransation = new Transaction(1, TransactionStatus.Aborted, "me", "my friend", 1234.0);

            this.chainblock.Add(dummyTransation);

            Assert.That(
                this.chainblock.Contains(dummyTransation),
                Is.EqualTo(true),
                "Contains should return true with existing transaction.");
        }

        [Test]
        public void ContainsByTxShouldReturnFalseWithNonExistingTransaction()
        {
            ITransaction dummyTransation1 = new Transaction(1, TransactionStatus.Aborted, "me", "my friend", 1234.0);

            ITransaction dummyTransation2 = new Transaction(2, TransactionStatus.Aborted, "me", "my friend", 1234.0);

            this.chainblock.Add(dummyTransation1);

            Assert.That(
                this.chainblock.Contains(dummyTransation2),
                Is.EqualTo(false),
                "Contains should return false with non existing transaction.");
        }

        [Test]
        public void GetByIdShouldReturnExpectedTx()
        {
            int dummyTxId = 1;
            ITransaction dummyTransation1 = new Transaction(dummyTxId, TransactionStatus.Aborted, "me", "my friend", 1234.0);

            ITransaction dummyTransation2 = new Transaction(2, TransactionStatus.Aborted, "me", "my friend", 1234.0);

            this.chainblock.Add(dummyTransation1);
            this.chainblock.Add(dummyTransation2);

            ITransaction tx = this.chainblock.GetById(dummyTxId);

            Assert.That(
                tx,
                Is.EqualTo(dummyTransation1),
                "Transactions are not unique.");
        }

        [Test]
        public void GetByIdShouldThrowExceptionWithNonExistingTx()
        {
            ITransaction dummyTransation1 = new Transaction(1, TransactionStatus.Aborted, "me", "my friend", 1234.0);

            ITransaction dummyTransation2 = new Transaction(2, TransactionStatus.Aborted, "me", "my friend", 1234.0);

            this.chainblock.Add(dummyTransation1);
            this.chainblock.Add(dummyTransation2);
            Assert.Throws<InvalidOperationException>(
                () => this.chainblock.GetById(3),
                "Get by Id with non existing transaction should throw an exception.");
        }

        [Test]
        public void ChangeTxStatusWithExistingTxShouldChangeTxStatus()
        {
            var dummyTxStatus = TransactionStatus.Unauthorized;

            ITransaction dummyTransation = new Transaction(1, dummyTxStatus, "me", "my friend", 1234.0);

            this.chainblock.Add(dummyTransation);
            var newTxStatus = TransactionStatus.Successfull;
            this.chainblock.ChangeTransactionStatus(dummyTransation.Id, newTxStatus);

            var receivedTx = this.chainblock.GetById(dummyTransation.Id);

            Assert.That(
                receivedTx.Status,
                Is.EqualTo(newTxStatus),
                "Change transaction status should update transaction status.");
        }

        [Test]
        public void ChangeTxStatusWithExistingTxShouldThrowArgumentException()
        {
            for (int i = 0; i < 5; i++)
            {
                Transaction dummyTransaction = new Transaction(i, TransactionStatus.Aborted, "", "", i);
                this.chainblock.Add(dummyTransaction);
            }

            Assert.Throws<ArgumentException>(
                () => this.chainblock.ChangeTransactionStatus(23, TransactionStatus.Unauthorized),
                "Change status with non-exising id should throw ArgumentException.");
        }

        [Test]
        public void RemoveByIdShouldBeValid()
        {
            for (int i = 0; i < 100; i++)
            {
                ITransaction dummyTransation = new Transaction(i, TransactionStatus.Successfull, i.ToString(), i.ToString(), i + 1000.1);
                this.chainblock.Add(dummyTransation);
            }

            int queryId = 0;
            this.chainblock.RemoveTransactionById(queryId);

            Assert.That(
                this.chainblock.Count,
                Is.EqualTo(99));
            Assert.Throws<InvalidOperationException>(
                () => this.chainblock.GetById(queryId));
        }

        [Test]
        public void RemoveMultipleExistingTransactionShouldBeValid()
        {
            for (int i = 0; i < 100; i++)
            {
                ITransaction dummyTransation = new Transaction(i, TransactionStatus.Successfull, i.ToString(), i.ToString(), i + 1000.1);
                this.chainblock.Add(dummyTransation);
            }

            this.chainblock.RemoveTransactionById(0);
            this.chainblock.RemoveTransactionById(1);
            this.chainblock.RemoveTransactionById(2);
            this.chainblock.RemoveTransactionById(3);
            this.chainblock.RemoveTransactionById(4);
            this.chainblock.RemoveTransactionById(5);

            Assert.That(
                this.chainblock.Count,
                Is.EqualTo(94));

            for (int i = 0; i < 6; i++)
            {
                Assert.Throws<InvalidOperationException>(
                    () => this.chainblock.GetById(i));
            }
        }

        [Test]
        public void RemoveTransactionWithZeroTransactionsShouldThrowException()
        {
            Assert.Throws<InvalidOperationException>(
                () => this.chainblock.RemoveTransactionById(0));

            Assert.That(
                this.chainblock.Count,
                Is.EqualTo(0));
        }

        [Test]
        public void RemoveNonExistingIdWithMultipleTransactionsShouldThrowException()
        {
            for (int i = 0; i < 5; i++)
            {
                ITransaction dummyTransation = new Transaction(i, TransactionStatus.Successfull, i.ToString(), i.ToString(), i + 1000.1);
                this.chainblock.Add(dummyTransation);
            }

            Assert.Throws<InvalidOperationException>(
                () => this.chainblock.RemoveTransactionById(5));

            Assert.That(
                this.chainblock.Count,
                Is.EqualTo(5));
        }

        [Test]
        public void GetByTransactionStatusWithExistingTransactionShouldReturnTransactionWithGivenStatusOrderedByAmountInDescending()
        {
            for (int i = 0; i < 100; i++)
            {
                TransactionStatus status = (TransactionStatus)(i % 4) + 1;

                ITransaction dummyTransation = new Transaction(i, status, i.ToString(), i.ToString(), i);

                this.chainblock.Add(dummyTransation);
            }

            var filterTransactionStatus = TransactionStatus.Successfull;

            var filteredTransactions = this.chainblock
                .GetByTransactionStatus(TransactionStatus.Successfull)
                .ToArray();

            double amount = filteredTransactions[0].Amount;

            Assert.That(
                    filteredTransactions[0].Status,
                    Is.LessThanOrEqualTo(filterTransactionStatus));

            for (int i = 0; i < filteredTransactions.Length; i++)
            {
                var currentTransaction = filteredTransactions[i];

                Assert.That(
                    currentTransaction.Amount,
                    Is.LessThanOrEqualTo(amount));

                Assert.That(
                    currentTransaction.Status,
                    Is.LessThanOrEqualTo(filterTransactionStatus));

                amount = currentTransaction.Amount;
            }
        }

        [Test]
        public void GetByTransactionsStatusWithNonExistingTransactionsStatusShouldThrowException()
        {
            for (int i = 0; i < 100; i++)
            {
                ITransaction dummyTransation = new Transaction(i, TransactionStatus.Aborted, i.ToString(), i.ToString(), i);

                this.chainblock.Add(dummyTransation);
            }

            Assert.Throws<InvalidOperationException>(
                () => this.chainblock.GetByTransactionStatus(TransactionStatus.Unauthorized));
        }
        
        [Test]
        public void GetByReceiverAndAmountRangeWithInvalidReceiverShouldThrowException()
        {
            string receiverName = "Peter";
            for (int i = 0; i < 100; i++)
            {
                ITransaction dummyTransation = new Transaction(i, TransactionStatus.Aborted, i.ToString(), i.ToString(), i + 50);

                this.chainblock.Add(dummyTransation);
            }

            Assert.Throws<InvalidOperationException>(
                () => this.chainblock.GetByReceiverAndAmountRange(receiverName, 60, 90));
        }

        [Test]
        public void GetByReceiverAndAmountRangeWithInvalidRangeShouldThrowException()
        {
            string receiverName = "Peter";
            for (int i = 0; i < 100; i++)
            {
                ITransaction dummyTransation = new Transaction(i, TransactionStatus.Aborted, i.ToString(), i.ToString(), i + 50);

                this.chainblock.Add(dummyTransation);
            }

            Assert.Throws<InvalidOperationException>(
                () => this.chainblock.GetByReceiverAndAmountRange(receiverName, int.MinValue, 49));

            Assert.Throws<InvalidOperationException>(
                () => this.chainblock.GetByReceiverAndAmountRange(receiverName, 150, int.MaxValue));
        }

        [Test]
        public void GetByReceiverAndAmountRangeWithEqualAmountsShouldOrderTransactionsInAscendingOrderById()
        {
            Chainblock chainBlock = new Chainblock();
            string receiverName = "Peter";
            for (int i = 0; i <= 100; i++)
            {
                TransactionStatus status = (TransactionStatus)(i % 4) + 1;

                var receiver = i % 2 == 0
                    ? receiverName
                    : i.ToString();

                int transactionAmount = i % 2 == 0
                    ? 50
                    : i + 50;

                ITransaction dummyTransation = new Transaction(i, status, string.Empty, receiver, transactionAmount);

                chainblock.Add(dummyTransation);
            }

            double lo = 50;
            double hi = 90;
            var filtered = this.chainblock.GetByReceiverAndAmountRange(receiverName, lo, hi)
                .Where(tx => tx.Amount == 50)
                .ToArray();

            int id = int.MinValue;
            foreach (var transaction in filtered)
            {
                Assert.That(
                    transaction.Id,
                    Is.GreaterThan(id));

                Assert.That(
                    transaction.To,
                    Is.EqualTo(receiverName),
                    "Transactions should be filtered by receiver name.");                

                id = transaction.Id;
            }
        }

        [Test]
        public void GetAllSendersWithTransactionStatusShouldThrowExceptionWhenStatusIsNotPresent()
        {
            for (int i = 1; i <= 100; i++)
            {            
                ITransaction dummyTransation = new Transaction(i, TransactionStatus.Successfull, i.ToString(), i.ToString(), i);

                this.chainblock.Add(dummyTransation);
            }     

            Assert.Throws<InvalidOperationException>(
              () => this.chainblock.GetAllSendersWithTransactionStatus(TransactionStatus.Unauthorized));
        }

        [Test]
        public void GetAllSendersWithTransactionStatusShouldReturnOnlySenderNamesWhenStatusIsPresent()
        {
            List<ITransaction> addedTransactions = new List<ITransaction>();

            for (int i = 1; i <= 100; i++)
            {
                TransactionStatus status = (TransactionStatus)(i % 4) + 1;

                ITransaction dummyTransation = new Transaction(i, status, i.ToString(), i.ToString(), i);

                this.chainblock.Add(dummyTransation);
                addedTransactions.Add(dummyTransation);
            }

            var actualResult = this.chainblock
                .GetAllSendersWithTransactionStatus(TransactionStatus.Successfull)
                .ToList();

            var expectedResult = addedTransactions
                .Where(t => t.Status == TransactionStatus.Successfull)
                .OrderByDescending(t => t.Amount)
                .Select(t => t.From)
                .ToList();
            
            Assert.That(
                expectedResult.Count,
                Is.EqualTo(actualResult.Count));

            for (int i = 0; i < actualResult.Count; i++)
            {
                Assert.That(
                expectedResult[i],
                Is.EqualTo(actualResult[i]));
            }
        }
    }
}
