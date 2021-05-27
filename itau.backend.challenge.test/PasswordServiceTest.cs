using Itau.Backend.Challenge.Application.Models.Services.Password;
using Itau.Backend.Challenge.Application.Services;
using System;
using Xunit;

namespace Itau.Backend.Challenge.test
{
    public class PasswordServiceTest
    {
        [Theory(DisplayName = "Senhas com valores corretos")]
        [InlineData("AbTp9!fok")]
        [InlineData("BcTp9@foG")]
        public void ValidateV1SucessTest(string password)
        {
            PasswordService service = new PasswordService();

            var result = service.Validate(new PasswordValidateIn_v1 { Password = password });

            Assert.True(result.IsValid);
        }


        [Theory(DisplayName = "Senhas com valores incorretos")]
        [InlineData("")]
        [InlineData("aa")]
        [InlineData("ab")]
        [InlineData("Ab9!k")]
        [InlineData("AAAbbbCc")]
        [InlineData("AbTp9!foo")]
        [InlineData("AbTp9!foA")]
        [InlineData("AbTp9 fok")]
        [InlineData("Ab9    !k")]
        [InlineData("AbkTp9@fok")]
        public void ValidateV1FailTest(string password)
        {
            PasswordService service = new PasswordService();

            var result = service.Validate(new PasswordValidateIn_v1 { Password = password });

            Assert.False(result.IsValid);
        }


        [Theory(DisplayName = "Senhas com valores corretos")]
        [InlineData("AbTp9!fok")]
        [InlineData("BcTp9@foG")]
        public void ValidateV2SucessTest(string password)
        {
            PasswordService service = new PasswordService();

            var result = service.Validate(new PasswordValidateIn_v2 { Password = password });

            Assert.True(result.IsValid);
        }


        [Theory(DisplayName = "Senhas com valores incorretos")]
        [InlineData("")]
        [InlineData("aa")]
        [InlineData("ab")]
        [InlineData("Ab9!k")]
        [InlineData("AAAbbbCc")]
        [InlineData("AbTp9!foo")]
        [InlineData("AbTp9!foA")]
        [InlineData("AbTp9 fok")]
        [InlineData("Ab9    !k")]
        [InlineData("AbkTp9@fok")]
        public void ValidateV2FailTest(string password)
        {
            PasswordService service = new PasswordService();

            var result = service.Validate(new PasswordValidateIn_v2 { Password = password });

            Assert.False(result.IsValid);
        }
    }
}
