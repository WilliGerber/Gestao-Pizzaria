using System.Data.Common;

namespace PizzariaZeDAO
{
    public class Ingredient
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Ingredient(int id = 0, string name = "")
        {
            Id = id;
            Name = name;
        }

    }

    public class IngredientDAO
    {
        /// <summary>
        /// Utilização de mais do que um provider com o mesmo script (MySQL, SQLServer, Firebird...)
        /// </summary>
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }

        public IngredientDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public void InserirDbProvider(Ingredient ingredient)
        {
            using var conn = factory.CreateConnection(); //Cria conexão
            conn!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conn; //Atribui conexão

            //Adiciona parâmetro (@campo e valor)
            var name = comando.CreateParameter(); name.ParameterName = "@name";
            name.Value = ingredient.Name; comando.Parameters.Add(name);
            
            conn.Open();

            comando.CommandText = @"INSERT INTO tb_ingredient(ingredient_name) VALUES (@name)";

            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
            //using faz o Close() automático quando fecha o seu escopo
        }
    }



}
