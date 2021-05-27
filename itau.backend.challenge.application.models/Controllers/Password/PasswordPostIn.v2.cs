using System.Runtime.Serialization;

namespace Itau.Backend.Challenge.Application.Models.Controllers.Password
{
    [DataContract]
    public struct PasswordPostIn_v2
    {
        [DataMember(Name = "password", IsRequired = true)]
        public string Password { get; set; }
    }
}
