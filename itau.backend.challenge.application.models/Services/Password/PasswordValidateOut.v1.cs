using Itau.Backend.Challenge.Application.Models.Controllers.Password;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Backend.Challenge.Application.Models.Services.Password
{
    public class PasswordValidateOut_v1
    {
        public bool IsValid { get; set; }

        public static implicit operator PasswordPostOut_v1(PasswordValidateOut_v1 v)
        {
            return new PasswordPostOut_v1
            {
                IsValid = v.IsValid
            };
        }
    }
}
