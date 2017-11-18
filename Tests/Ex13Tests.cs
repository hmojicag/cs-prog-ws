using System;
using System.Reflection;
using Xunit;
using Ex13;

namespace Tests
{
    public class Ex13Tests
    {
        [Fact]
        public void TestBankAccountClass() {
            if (!Ex13.Program.ENABLED) {
                return;
            }
            Console.WriteLine("Testing Ex13");

            Type bankAccountType = Type.GetType("Ex13.BankAccount, Ex13");

            Assert.True(bankAccountType != null,
            "You need to create a class called BankAccount inside " +
            "the namespace Ex13.");

            PropertyInfo nameProperty = bankAccountType.GetProperty("Name");
            Assert.True(nameProperty != null,
            "The class BankAccount must have a property called 'Name'");
            Assert.True(nameProperty.PropertyType == typeof(string), 
            "The property 'Name' should be string");

            PropertyInfo accountNumberProperty = bankAccountType.GetProperty("AccountNumber");
            Assert.True(accountNumberProperty != null,
            "The class AccountNumber must have a property called 'AccountNumber'");
            Assert.True(accountNumberProperty.PropertyType == typeof(long), 
            "The property 'AccountNumber' should be long");

            PropertyInfo totalBalanceProperty = bankAccountType.GetProperty("TotalBalance");
            Assert.True(totalBalanceProperty != null,
            "The class TotalBalance must have a property called 'TotalBalance'");
            Assert.True(totalBalanceProperty.PropertyType == typeof(double), 
            "The property 'TotalBalance' should be double");

            ConstructorInfo[] constructorInfo = bankAccountType.GetConstructors();
            Assert.True(constructorInfo != null && constructorInfo.Length > 0,
            "You need to declare at least one constructor");

            ConstructorInfo mainConstructor = constructorInfo[0];
            Assert.True(mainConstructor.IsPublic,
            "The constructor should be declared public");

            MethodInfo accountAsStringMethod = bankAccountType.GetMethod("AccountAsString");
            Assert.True(accountAsStringMethod != null,
            "The sould be a method called 'AccountAsString'");

            Assert.True(accountAsStringMethod.IsPublic,
            "The method AccountAsString shoul be public");

        }

    }
}
