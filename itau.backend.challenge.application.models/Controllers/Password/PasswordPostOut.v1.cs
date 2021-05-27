using System.Runtime.Serialization;

namespace Itau.Backend.Challenge.Application.Models.Controllers.Password
{
    [DataContract]
    public struct PasswordPostOut_v1
    {
        [DataMember(Name = "isValid")]
        public bool IsValid { get; set; }
    }
}
