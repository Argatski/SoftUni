using Chainblock.Contracts;
using Chainblock.Models;
using NUnit.Framework;
using System;

namespace Chainblock.Tests
{

    [TestFixture]
    public class ChainblockTests
    {
        public IChainblock Chainblock { get; set; }
        public ITransaction Transaction { get; set; }
        [SetUp]
        public void SetUp()
        {
            this.Transaction = new Transaction()
            {
                Id = 1,
                From = "Fillep",
                To = "Victor",
                Status = TransactionStatus.Successfull,
                Amount = 1
            };

            this.Chainblock = new ChainBlock();
        }

        [Test]
        [Category("[Add method]")]
        public void GivenTransactionIsValid_WhenAddTransactionCalled_ThenTransactionCountIncrease()
        {
            this.Chainblock.Add(Transaction);

            //Assert
            Assert.AreEqual(1, this.Chainblock.Count);
        }
        [Test]
        [Category("[Add method]")]
        public void GivenDublicatedTransaction_WhenAddTransactionCalled_ThenThrowInvalidOperationExceptionIs()
        {
            //Action
            Chainblock.Add(Transaction);

            //Assert
            Assert.Throws<InvalidOperationException>(() => Chainblock.Add(Transaction));
        }

        [Test]
        [Category("[Count property]")]
        public void GivenPropertyCountValue_WhenCountGetterIsCalled_ThenPropertyCountIsReturned()
        {
            //Assert
            Assert.AreEqual(0, this.Chainblock.Count);
        }

        [Test]
        [Category("[Contains]-->Id method")]
        public void GevenExistingId_WhenContainsByIdCalled_ThenReturnTrue
            ()
        {
            //Action
            this.Chainblock.Add(this.Transaction);
            bool result = this.Chainblock.Contains(this.Transaction.Id);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        [Category("[Contains]-->Id method")]
        public void GevenNonExistingId_WhenContainsByIdCalled_ThenReturnFalse
           ()
        {
            //Assert
            Assert.That(this.Chainblock.Contains(this.Transaction.Id), Is.False);
        }
        [Test]
        [Category("[Contains]-->Id method")]
        public void GevenNegativeId_WhenContainsByIdCalled_ThenThrowInvalidArgumentException()
        {
            //Assert
            Assert.Throws<ArgumentException>(() => this.Chainblock.Contains(-1));
        }
        [Test]
        [Category("[Contains]-->Transaction method")]
        public void GevenExistingTransaction_WhenContainsByTransactionCalled_ThenReturnTrue()
        {
            this.Chainblock.Add(this.Transaction);

            //Assert
            Assert.That(this.Chainblock.Contains(Transaction), Is.True);
        }
        [Test]
        [Category("[Contains]-->Transaction method")]
        public void GevenNonExistingTransaction_WhenContainsByTransactionCalled_ThenReturnFals()
        {
            //Assert
            Assert.IsFalse(this.Chainblock.Contains(this.Transaction.Id));
        }

        [Test]
        [Category("[ChageTransactionsStatus] method")]
        public void GivenValidIdAndStatus_WhenChangeTransactionStatusIsCalled_ThenStatusChanged()
        {
            //Action
            this.Transaction.Status = TransactionStatus.Successfull;

            this.Chainblock.Add(this.Transaction);

            var newStatus = TransactionStatus.Aborted;
            this.Chainblock.ChangeTransactionStatus(this.Transaction.Id, newStatus);

            //Assert
            Assert.AreEqual(newStatus, this.Transaction.Status);
        }

        [Test]
        [Category("[ChageTransactionsStatus] method")]
        public void GivenValidIdAndIvalidStatus_WhenChangeTransactionStatusIsCalled_ThenThrowInvalidOperationException()
        {
            this.Chainblock.Add(this.Transaction);

            var newStatus = TransactionStatus.Successfull;

            //Assert
            Assert.Throws<InvalidOperationException>(() => this.Chainblock.ChangeTransactionStatus(this.Transaction.Id, newStatus));
        }

        [Test]
        [Category("[ChageTransactionsStatus] method")]
        public void GivenInvalidIdAndStatus_WhenChangeTransactionStatusIsCalled_ThenThrowArgumentException()
        {
            //Action
            this.Chainblock.Add(this.Transaction);
            int invalidId = 3;

            //Assert
            Assert.Throws<ArgumentException>(() => this.Chainblock.ChangeTransactionStatus(invalidId, TransactionStatus.Successfull));
        }
        [Test]
        [Category("[ChageTransactionsStatus] method")]
        public void GivenValidIdAndNonExsistingStatus_WhenChangeTransactionStatusIsCalled_ThenThrowInvalidOperationException()
        {

            int newInvalidStatus = 15;
            //Assert
            Assert.Throws<InvalidOperationException>(() => this.Chainblock.ChangeTransactionStatus(this.Transaction.Id, (TransactionStatus)newInvalidStatus));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [Category("[ChageTransactionsStatus] method")]
        public void GivenInvalidIdAndValidStatus_WhenChangeTransactionStatusIsCalled_ThenThrowInvalidOperationException(int invalidId)
        {
            string expectedErrorMessage = "Id cannot be less or queal to 0";
            ArgumentException ex = Assert.Throws<ArgumentException>
                (
                delegate
                {
                    this.Chainblock.ChangeTransactionStatus(invalidId, TransactionStatus.Successfull);
                }
                );

            //Assert
            Assert.That(ex.Message, Is.EqualTo(expectedErrorMessage));
        }
    }
}
