using CalculadoraCumBLO.DTOS;
using CalculadoraCumBLO.Interfaces;
using CalculadoraCumBLO.Models;
using CalculadoraCumBLO.Models.AccountModel;
using CalculadoraCumBLO.Services;
using Moq;
using NUnit.Framework;

namespace CalculadoraCum.Tests
{
    public class AccountServiceTest
    {
        private LoginRequest model = new LoginRequest();
        [SetUp]
        public void Setup()
        {
            //model.Email = "usuario@hotmail.com";
            //model.Password = "123456";
        }

        [Test]
        public void Status_Code_Is_Equal_Advertencia_When_Password_IsNullOrEmpty()
        {
            var mock = new Mock<IAccountService>();
            mock.Setup(p => p.Login(model)).Returns(new Result());
            AccountService service = new AccountService();
            var result = service.Login(model);
            Assert.AreEqual(StatusCode.Advertencia, result.Status);
        }

        [Test]
        public void Status_Code_Is_Equal_Advertencia_When_Email_IsNullOrEmpty()
        {
            var mock = new Mock<IAccountService>();
            mock.Setup(p => p.Login(model)).Returns(new Result());
            AccountService service = new AccountService();
            var result = service.Login(model);
            Assert.AreEqual(StatusCode.Advertencia, result.Status);
        }
    }
}