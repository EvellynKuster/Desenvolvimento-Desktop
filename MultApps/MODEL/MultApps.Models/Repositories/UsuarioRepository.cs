using Dapper;
using MultApps.Models.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Repositories
{
    public class UsuarioRepository
    {
        public string ConnectionString = "Server=localhost; Database=multapps_dev; Uid=root; Pwd=root";

        public bool CadastrarUsuario(Usuario usuario)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO usuario(nome, status, cpf, email, senha)
                                   VALUES(@Nome, @Status, @Cpf, @Email, @Senha)";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", usuario.Nome);
                parametros.Add("@Status", usuario.Status.ToString());
                parametros.Add("@Cpf", usuario.Cpf.ToString());
                parametros.Add("@Email", usuario.Email.ToString());
                parametros.Add("@Senha", usuario.Senha.ToString());


                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }

        public List<Usuario> ListarTodosUsuarios()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT * FROM usuario";
                var resultado = db.Query<Usuario>(comandoSql).ToList();
                return resultado;
            }
        }

        public Usuario MostrarUsuarioPorId(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, nome, data_criacao, data_ultimo_acesso, status, cpf, email, senha
                                    FROM usuario WHERE id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);
                var resultado = db.Query<Usuario>(comandoSql, parametros).FirstOrDefault();
                return resultado;
            }
        }

        public bool AtualizarUsuario(Usuario usuario)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"UPDATE usuario
                                    SET nome = @Nome, status = @Status, cpf = @Cpf, email = @Email, senha = @Senha
                                    WHERE id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", usuario.Id);
                parametros.Add("@Nome", usuario.Nome);
                parametros.Add("@Status", usuario.Status.ToString().ToLower());
                parametros.Add("@Cpf", usuario.Cpf);
                parametros.Add("@Email", usuario.Email);
                parametros.Add("@Senha", usuario.Senha);

                var resposta = db.Execute(comandoSql, parametros);

                return resposta > 0;
            }
        }

        public bool DeletarUsuario(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"DELETE FROM usuario WHERE id = @Id";
                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }

    }
}
