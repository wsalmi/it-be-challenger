using Itau.Backend.Challenge.Application.Models.Services.Password;
using Itau.Backend.Challenge.Interfaces.Application.Services;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Itau.Backend.Challenge.Application.Services
{
    public partial class PasswordService : IPasswordService
    {
        public async Task<PasswordValidateOut_v2> ValidateAsync(PasswordValidateIn_v2 input)
        {
            return await Task.Run(() => Validate(input));
        }

        public PasswordValidateOut_v2 Validate(PasswordValidateIn_v2 input)
        {
            return new PasswordValidateOut_v2(
                hasCorrectSize: HasCorrectSize(input.Password),
                hasOneDigit: HasOneDigit(input.Password),
                hasUperCase: HasUperCase(input.Password),
                hasLowerCase: HasLowerCase(input.Password),
                hasSpecialChar: HasSpecialChar(input.Password),
                noRepetChar: NoRepetChars(input.Password)
            );
        }
    }
}
