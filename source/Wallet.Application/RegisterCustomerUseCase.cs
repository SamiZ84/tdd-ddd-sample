using System;
using Wallet.Domain;

namespace Wallet.Application
{
    public sealed class RegisterCustomerUseCase : IRegisterCustomerUseCase
    {
        public CustomerResult Register(string name, string phoneNumber, DateTime birthDate)
        {
            Customer customer = new Customer(name, phoneNumber, birthDate);
            return new CustomerResult(customer);
        }
    }
}