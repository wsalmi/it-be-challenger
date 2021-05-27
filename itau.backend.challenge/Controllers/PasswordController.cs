using Itau.Backend.Challenge.Controllers.Base;
using Itau.Backend.Challenge.Interfaces.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Itau.Backend.Challenge.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public partial class PasswordController : BaseController<PasswordController>
    {
        private readonly IPasswordService _passwordService;

        public PasswordController(ILogger<PasswordController> logger, IPasswordService passwordService) : base(logger)
        {
            _passwordService = passwordService;
        }
    }
}
    