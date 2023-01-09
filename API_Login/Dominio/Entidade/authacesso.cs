using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidade
{
    public class authacesso
    {
        /// <summary>
        ///  Id do acesso
        /// </summary>
        /// <example>35</example>
        ///
        [Key]
        [Required]
        public long Id { get; set; }
        /// <summary>
        ///  Tela/aba a ser permitida o acesso
        /// </summary>
        /// <example>MasterCredito/agenda</example>
        ///
        [Required]
        [StringLength(500)]
        public string acessoPermissao { get; set; }
        /// <summary>
        ///  Situação do acesso. Modelo: 0 para INATIVO e 1 para ATIVO.
        /// </summary>
        /// <example>1</example>
        ///
        [Required]
        public int situacao { get; set; }
        /// <summary>
        ///  Descrição da permissão definida pelo usuário
        /// </summary>
        /// <example>Master Crédito - Agenda Financeira</example>
        ///
        [StringLength(500)]
        public string descricaoPermissao { get; set; }
        /// <summary>
        ///  Ordem de exibição da aba na tela principal (Ex: MasterCredito) ou na tela do componente pai (Ex: MasterCredito/agenda).
        /// </summary>
        /// <example>2</example>
        ///
        public int ordemExibicao { get; set; }
        /// <summary>
        ///  Nome de exibição a ser mostrado na tela do usuário final
        /// </summary>
        /// <example>Agenda Financeira</example>
        ///
        [StringLength(500)]
        public string NomeExibicao { get; set; }
        /// <summary>
        ///  Nome composto do usuário
        /// </summary>
        /// <example>Harry Potter</example>
        ///
        [NotMapped]
        public virtual string NomeComposto { get; set; }
    }
}
