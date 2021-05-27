using Itau.Backend.Challenge.Application.Models.Services.Password;
using System.Threading.Tasks;

namespace Itau.Backend.Challenge.Interfaces.Application.Services
{
    public interface IPasswordService
    {
        #region V1
        /// <summary>
        /// Valida a senha está de acordo com as regras previstas
        /// </summary>
        /// <param name="input"><see cref="PasswordValidateIn_v1"/></param>
        /// <returns><see cref="PasswordValidateOut_v1"/></returns>
        PasswordValidateOut_v1 Validate(PasswordValidateIn_v1 input);
        /// <summary>
        /// Valida a senha está de acordo com as regras previstas
        /// </summary>
        /// <param name="input"><see cref="PasswordValidateIn_v1"/></param>
        /// <returns><see cref="PasswordValidateOut_v1"/></returns>
        Task<PasswordValidateOut_v1> ValidateAsync(PasswordValidateIn_v1 input);
        #endregion

        #region V2
        /// <summary>
        /// Valida a senha está de acordo com as regras previstas e detalha as validações
        /// </summary>
        /// <param name="input"><see cref="PasswordValidateIn_v2"/></param>
        /// <returns><see cref="PasswordValidateOut_v2"/></returns>
        PasswordValidateOut_v2 Validate(PasswordValidateIn_v2 input);
        /// <summary>
        /// Valida a senha está de acordo com as regras previstas e detalha as validações
        /// </summary>
        /// <param name="input"><see cref="PasswordValidateIn_v2"/></param>
        /// <returns><see cref="PasswordValidateOut_v2"/></returns>
        Task<PasswordValidateOut_v2> ValidateAsync(PasswordValidateIn_v2 input);
        #endregion
    }
}
