using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidade
{
    public class authusuario
    {
        /// <summary>
        ///  Id do usuário
        /// </summary>
        /// <example>565</example>
        ///
        [Key]
        [Required]
        public long Id { get; set; }
        /// <summary>
        ///  Usuário
        /// </summary>
        /// <example>harry.potter</example>
        ///
        [Required]
        [StringLength(50)]
        public string usuario { get; set; }
        /// <summary>
        ///  Senha do usuário
        /// </summary>
        /// <example>chrissucodefrutas</example>
        ///
        [Required]
        [StringLength(500)]
        public string senha { get; set; }
        /// <summary>
        ///  Data do último acesso - Formato: YYYY-MM-DD HH:mm:ss
        /// </summary>
        /// <example>2022-10-21 19:05:00</example>
        /// 
        [StringLength(50)]
        public string ultimoAcesso { get; set; }
        /// <summary>
        ///  E-mail
        /// </summary>
        /// <example>harry.potter@b2card.com</example>
        ///
        [StringLength(50)]
        public string email { get; set; }
        /// <summary>
        ///  Situação do acesso. Modelo: 0 para INATIVO e 1 para ATIVO.
        /// </summary>
        /// <example>1</example>
        ///
        [Required]
        public int situacao { get; set; }
        /// <summary>
        ///  Id do administrador do usuário
        /// </summary>
        /// <example>65</example>
        ///
        [Required]
        public int administrador { get; set; }
        /// <summary>
        ///  Id do do grupo
        /// </summary>
        /// <example>445</example>
        ///
        public long? grupo { get; set; }
        /// <summary>
        ///  Data de criação - Formato: YYYY-MM-DD HH:mm:ss
        /// </summary>
        /// <example>2022-10-21 19:05:00</example>
        /// 
        public DateTime? dataDeCriacao { get; set; }
        /// <summary>
        ///  Token do usuário para acesso da API
        /// </summary>
        /// <example>fjiodfjjdfsdfFSFSDFSDFsdfsdfSDFSDFWRqeaskAOPJSKOPas233</example>
        /// 
        [StringLength(50)]
        public string apiPass { get; set; }
        /// <summary>
        ///  CPF do usuário. Modelo: 000-000-000-00 ou 000.000.000.00 ou 00000000000.
        /// </summary>
        /// <example>123-456-789-12</example>
        ///
        [StringLength(50)]
        public string Cpf { get; set; }
    }
}
