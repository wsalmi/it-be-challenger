using Itau.Backend.Challenge.Application.Models.Controllers.Password;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Backend.Challenge.Application.Models.Services.Password
{
    public class PasswordValidateOut_v2
    {
        public PasswordValidateOut_v2(bool hasCorrectSize, bool hasOneDigit, bool hasUperCase, bool hasLowerCase, bool hasSpecialChar, bool noRepetChar)
        {
            HasCorrectSize = hasCorrectSize;
            HasOneDigit = hasOneDigit;
            HasUperCase = hasUperCase;
            HasLowerCase = hasLowerCase;
            HasSpecialChar = hasSpecialChar;
            NoRepetChar = noRepetChar;
        }

        /// <summary>
        /// Indica se a string validada está de acordo com as regras previstas
        /// </summary>
        public bool IsValid { get => HasCorrectSize && HasOneDigit && HasUperCase && HasLowerCase && HasSpecialChar && NoRepetChar; }
        /// <summary>
        /// Comtém a quantidade minima de caracteres, ignorando espaços
        /// </summary>
        public bool HasCorrectSize { get; }
        /// <summary>
        /// Contém pelo menos um dígito numérico (0-9)
        /// </summary>
        public bool HasOneDigit { get; private set; }
        /// <summary>
        /// Contém pelo menos um dígito em caixa alta (A-Z)
        /// </summary>
        public bool HasUperCase { get; private set; }
        /// <summary>
        /// Contém pelo menos um dígito em caixa baixa (a-z)
        /// </summary>
        public bool HasLowerCase { get; private set; }
        /// <summary>
        /// Contém pelo menos um dígito com caracter especial (!@#$%^&*()-+)
        /// </summary>
        public bool HasSpecialChar { get; private set; }
        /// <summary>
        /// Não existem caracteres repetidos dentro da string
        /// </summary>
        public bool NoRepetChar { get; private set; }

        public override string ToString()
        {
            if (IsValid)
            {
                return "A senha está de acordo com todas as regras previstas.";
            }
            else
            {
                var summary = new StringBuilder("A senha informada é inválida.").AppendLine("Resumo:");

                if (!HasCorrectSize) summary.AppendLine("- Não contém pelo menos 9 caractere, sem contar espaços");
                if (!HasOneDigit) summary.AppendLine("- Não contém pelo menos um digito numérico");
                if (!HasUperCase) summary.AppendLine("- Não contém pelo menos um caracter maiúsculo");
                if (!HasLowerCase) summary.AppendLine("- Não contém pelo menos um caracter minúsculo");
                if (!HasSpecialChar) summary.AppendLine("- Não contém pelo menos um caracter especial");
                if (!NoRepetChar) summary.AppendLine("- Não podem existir caracteres repetidos");

                return summary.ToString();
            }
        }

        public static implicit operator PasswordPostOut_v2(PasswordValidateOut_v2 v) => new PasswordPostOut_v2
        {
            IsValid = v.IsValid,
            Summary = v.ToString(),
            Detail = new PasswordPostOut_v2.Details
            {
                HasOneDigit = v.HasOneDigit,
                HasUperCase = v.HasUperCase,
                HasLowerCase = v.HasLowerCase,
                HasSpecialChar = v.HasSpecialChar,
                NoRepetChar = v.NoRepetChar
            }
        };
    }
}
