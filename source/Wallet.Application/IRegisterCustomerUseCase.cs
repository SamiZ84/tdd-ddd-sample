using System;

namespace Wallet.Application
{
    public interface IRegisterCustomerUseCase
    {
        CustomerResult Register(string name, string phoneNumber, DateTime birthDate);
    }
}