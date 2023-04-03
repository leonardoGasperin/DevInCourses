using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    internal class UserModel : _BaseEntety
    {
        [Column("nome")]
        public string Name { get; set; }
        [Column("cpf")]
        public string CPF { get; set; }
        [Column("data_de_nascimento")]
        public DateTime BirthDate { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("usuario")]
        public string UserName { get; set; }
        [Column("senha")]
        public string Password { get; set; }
        [Column("foto")]
        public string Picture { get; set; }

    }
}
