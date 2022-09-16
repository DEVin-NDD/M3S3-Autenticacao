using M3S3_Autenticacao.Enums;

namespace autenticacao.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Permissoes Role { get; set; }
    }
}