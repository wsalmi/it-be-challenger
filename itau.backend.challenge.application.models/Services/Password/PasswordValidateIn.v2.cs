using Itau.Backend.Challenge.Application.Models.Controllers.Password;

namespace Itau.Backend.Challenge.Application.Models.Services.Password
{
    public class PasswordValidateIn_v2
    {
        public string Password { get; set; }

        public static implicit operator PasswordValidateIn_v2(PasswordPostIn_v2 v)
        {
            return new PasswordValidateIn_v2
            {
                Password = v.Password
            };
        }
    }
}
