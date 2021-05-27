using Itau.Backend.Challenge.Application.Models.Services.Password;
using System;
using System.Runtime.Serialization;

namespace Itau.Backend.Challenge.Application.Models.Controllers.Password
{
    [DataContract]
    public struct PasswordPostOut_v2
    {
        [DataMember(Name = "isValid", Order = 0)]
        public bool IsValid { get; set; }

        [DataMember(Name = "summary", Order = 1)]
        public string Summary { get; internal set; }

        [DataMember(Name = "details", Order = 2)]
        public Details Detail { get; internal set; }


        public struct Details
        {
            [DataMember(Name = "hasOneDigit")]
            public bool HasOneDigit { get; internal set; }
            
            [DataMember(Name = "hasUperCase")]
            public bool HasUperCase { get; internal set; }

            [DataMember(Name = "hasLowerCase")]
            public bool HasLowerCase { get; internal set; }
            
            [DataMember(Name = "hasSpecialChar")]
            public bool HasSpecialChar { get; internal set; }
            
            [DataMember(Name = "noRepetChar")]
            public bool NoRepetChar { get; internal set; }
        }
    }
}
