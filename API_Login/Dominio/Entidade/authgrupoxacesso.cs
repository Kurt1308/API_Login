using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidade
{
    public class authgrupoxacesso
    {
        [Key]
        [Required]
        public long Id { get; set; }
        [Required]
        public long grupo { get; set; }
        [Required]
        public long acessopermissao { get; set; }
        [StringLength(500)]
        public string descricao { get; set; }
    }
}
