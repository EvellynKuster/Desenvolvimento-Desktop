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
    public class CategoriaRepository
    {
        public string ConectionString = "Server=localhost; Database=multapps_dev; Uid=root; Pwd=root";

        public bool CadastrarCategoria(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(ConectionString))
            {
                var comandoSql = @"INSER INTO categoria(nome, status)
                                   VALUES(@Nome, @Status)";

                var parametro = new DynamicParameters();
                parametro.Add("@Nome",categoria.Nome);
                parametro.Add("@Status", categoria.Status);

                var resultado = db.Execute(comandoSql, parametro);
                return resultado > 0;
            }          
        }
    }
}
