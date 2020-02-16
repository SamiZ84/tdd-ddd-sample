using Xunit;
using Wallet.Domain;
using Wallet.Application;
using System;

namespace Wallet.UnitTests
{
    public class CustomerTests
    {
        [Fact]
        public void RegisterCustomer__Return_Customer__When_Details_Are_Valid()
        {
            //
            // Arrange
            string expectName = "John Doe";
            string expectedPhoneNumber = "+76 1 400 180 66";
            DateTime expectedBirthDate = new DateTime(1999, 11, 20);
            IRegisterCustomerUseCase registerUC = new RegisterCustomerUseCase();

            // Act
            CustomerResult actualCustomerResult = registerUC.Register(expectName, expectedPhoneNumber, expectedBirthDate);

            // Assert
            Assert.NotNull(actualCustomerResult);
            Assert.NotEqual(Guid.Empty, actualCustomerResult.Id);
            Assert.Equal(expectName, actualCustomerResult.Name);
            Assert.Equal(expectedPhoneNumber, actualCustomerResult.PhoneNumber);
            Assert.Equal(expectedBirthDate, actualCustomerResult.BirthDate);
        }

        [Fact]
        public void CustomerCreate__Returns_Customer()
        {
            // Arrange
            string expectName = "John Doe";
            string expectedPhoneNumber = "+76 1 400 180 66";
            DateTime expectedBirthDate = new DateTime(1999, 11, 20);

            // Act
            Customer actualCustomer = new Customer(expectName, expectedPhoneNumber, expectedBirthDate);

            // Assert
            Assert.NotNull(actualCustomer);
            Assert.NotEqual(Guid.Empty, actualCustomer.Id);
            Assert.Equal(expectName, actualCustomer.Name);
            Assert.Equal(expectedPhoneNumber, actualCustomer.PhoneNumber);
            Assert.Equal(expectedBirthDate, actualCustomer.BirthDate);
        }
    }
}