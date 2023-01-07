using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class authconfigemail
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [StringLength(128)]
        public string host { get; set; }
        [StringLength(8)]
        public string port { get; set; }
        [StringLength(128)]
        public string your_security_email { get; set; }
        [StringLength(64)]
        public string your_security_email_pssw { get; set; }
        public int? situacao { get; set; }

    }
}
