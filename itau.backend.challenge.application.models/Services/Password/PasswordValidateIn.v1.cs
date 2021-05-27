using Itau.Backend.Challenge.Application.Models.Controllers.Password;

namespace Itau.Backend.Challenge.Application.Models.Services.Password
{
    public class PasswordValidateIn_v1
    {
        public string Password { get; set; }

        public static implicit operator PasswordValidateIn_v1(PasswordPostIn_v1 v)
        {
            return new PasswordValidateIn_v1
            {
                Password = v.Password
            };
        }
    }
}
