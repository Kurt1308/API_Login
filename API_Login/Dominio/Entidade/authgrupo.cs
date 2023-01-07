using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class authgrupo
    {
        /// <summary>
        ///  Id do grupo
        /// </summary>
        /// <example>565</example>
        ///
        [Key]
        [Required]
        public long Id { get; set; }
        /// <summary>
        ///  Nome do grupo
        /// </summary>
        /// <example>Contabilidade - Banco do Tio Patinhas</example>
        ///
        [StringLength(150)]
        public string nomeGrupo { get; set; }
        /// <summary>
        ///  Descrição
        /// </summary>
        /// <example>Lorem ipsum</example>
        ///
        [StringLength(500)]
        public string descricao { get; set; }
        /// <summary>
        ///  Data de criação - Formato: YYYY-MM-DD HH:mm:ss
        /// </summary>
        /// <example>2022-10-21 19:05:00</example>
        ///
        public DateTime? dataDeCriacao { get; set; }
    }
}
