using Itau.Backend.Challenge.Application.Models.Controllers.Password;
using Microsoft.AspNetCore.Mvc;

namespace Itau.Backend.Challenge.Controllers
{
    [ApiVersion("1", Deprecated = true)]
    public partial class PasswordController
    {
        [HttpPost]
        [MapToApiVersion("1")]
        public PasswordPostOut_v1 Post_V1(PasswordPostIn_v1 input)
        {
            return _passwordService.Validate(input);
        }
    }
}
