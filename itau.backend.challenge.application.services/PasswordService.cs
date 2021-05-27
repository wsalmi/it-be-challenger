using Itau.Backend.Challenge.Application.Models.Services.Password;
using Itau.Backend.Challenge.Interfaces.Application.Services;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Itau.Backend.Challenge.Application.Services
{
    public partial class PasswordService : IPasswordService
    {
        const byte MIN_PASSWORD_SIZE = 9;

        /// <summary>
        /// Valida se a <paramref name="password"/> contém 9 ou mais caracteres, ignorando espaços
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        protected virtual bool HasCorrectSize(string password) => new Regex(@"(\S){" + MIN_PASSWORD_SIZE + @",}", RegexOptions.Compiled).IsMatch(password);
        /// <summary>
        /// Valida se a <paramref name="password"/> contém no mínimo um digito (0-9)
        /// <code>HasOneDigit("aaa1") // true</code>
        /// <code>HasOneDigit("aaab") // false</code>
        /// </summary>
        /// <param name="password">String analisada</param>
        /// <returns>true | false</returns>
        protected virtual bool HasOneDigit(string password) => new Regex(@"\d", RegexOptions.Compiled).IsMatch(password);
        /// <summary>
        /// Valida se a <paramref name="password"/> contém no mínimo um caracter em caixa alta
        /// <code>HasUperCase("aaAa") // true</code>
        /// <code>HasUperCase("aaaa") // false</code>
        /// </summary>
        /// <param name="password">String analisada</param>
        /// <returns>true | false</returns>
        protected virtual bool HasUperCase(string password) => new Regex(@"[A-Z]", RegexOptions.Compiled).IsMatch(password);
        /// <summary>
        /// Valida se a <paramref name="password"/> contém no mínimo um caracter em caixa baixa
        /// <code>HasLowerCase("AAaA") // true</code>
        /// <code>HasLowerCase("AAAA") // false</code>
        /// </summary>
        /// <param name="password">String analisada</param>
        /// <returns>true | false</returns>
        protected virtual bool HasLowerCase(string password) => new Regex(@"[a-z]", RegexOptions.Compiled).IsMatch(password);
        /// <summary>
        /// Valida se a <paramref name="password"/> contém no mínimo um caracter especial (!@#$%^&*()-+)
        /// <code>HasSpecialChar("Ab!9") // true</code>
        /// <code>HasSpecialChar("Abb9") // false</code>
        /// </summary>
        /// <param name="password">String analisada</param>
        /// <returns>true | false</returns>
        protected virtual bool HasSpecialChar(string password) => new Regex(@"[!@#$%^&*()\-+]", RegexOptions.Compiled).IsMatch(password);
        /// <summary>
        /// Valida se a <paramref name="password"/> não contém caracteres repetidos
        /// <code>NoRepetChars("Ab!9") // true</code>
        /// <code>NoRepetChars("Abb9") // false</code>
        /// </summary>
        /// <param name="password">String analisada</param>
        /// <returns>true | false</returns>
        protected virtual bool NoRepetChars(string password) => !new Regex(@"(\w)(?=.*\1)", RegexOptions.Compiled | RegexOptions.IgnoreCase).IsMatch(password);
    }
}
