using Itau.Backend.Challenge.Application.Models.Controllers.Password;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Itau.Backend.Challenge.Controllers
{
    [ApiVersion("2")]
    public partial class PasswordController
    {
        [HttpPost]
        [MapToApiVersion("2")]
        public async Task<PasswordPostOut_v2> Post_V2(PasswordPostIn_v2 input)
        {
            var output = await _passwordService.ValidateAsync(input);

            return output;
        }
    }
}
