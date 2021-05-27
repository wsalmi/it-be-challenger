using Itau.Backend.Challenge.Application.Models.Services.Password;
using System;
using System.Runtime.Serialization;

namespace Itau.Backend.Challenge.Application.Models.Controllers.Password
{
    [DataContract]
    public struct PasswordPostIn_v1
    {
        [DataMember(Name = "password", IsRequired = true)]
        public string Password { get; set; }

    }
}
