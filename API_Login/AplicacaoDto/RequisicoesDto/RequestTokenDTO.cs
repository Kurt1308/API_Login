using System.ComponentModel.DataAnnotations;

namespace ApplicationDTO.RequestDTO
{
    /// <summary>
    /// Requisição para busca do token de login
    /// </summary>
    public class RequestTokenDTO
    {
        /// <summary>
        ///  Usuário
        /// </summary>
        /// <example>lucas@gmail.com</example>
        ///
        [Required]
        public string username { get; set; }
        /// <summary>
        ///  Senha
        /// </summary>
        /// <example>1234</example>
        ///
        [Required]
        public string password { get; set; }
    }
}
