using Itau.Backend.Challenge.Application.Models.Services.Password;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Itau.Backend.Challenge.Application.Services
{
    public partial class PasswordService
    {
        public async Task<PasswordValidateOut_v1> ValidateAsync(PasswordValidateIn_v1 input)
        {
            return await Task.Run(() => Validate(input));
        }

        public PasswordValidateOut_v1 Validate(PasswordValidateIn_v1 input)
        {
            return new PasswordValidateOut_v1
            {
                IsValid = HasCorrectSize(input.Password) &&
                          HasOneDigit(input.Password) &&
                          HasUperCase(input.Password) &&
                          HasLowerCase(input.Password) &&
                          HasSpecialChar(input.Password) &&
                          NoRepetChars(input.Password)
            };
        }


    }
}
