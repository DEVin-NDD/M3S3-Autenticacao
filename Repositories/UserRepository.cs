using autenticacao.Dtos;
using autenticacao.Models;

namespace autenticacao.Repositories
{
    public static class UserRepository
    {

        private static List<UserModel> usuarios = new List<UserModel>{

            new UserModel{
                Id = 1,
                Email = "vitor@gmail.com",
                Name = "Vitor",
                Password = "123",
                Role = "admin"
            },

            new UserModel{
                Id = 2,
                Email = "joao@gmail.com",
                Name = "Joao",
                Password = "123",
                Role = "usuario"
            }
       };

        public static UserModel? VerificarUsuarioESenha(UserDto dto)
        {
            var user = usuarios.FirstOrDefault
            (x => x.Email == dto.Email && x.Password == dto.Password);

            return user;
        }
    }
}