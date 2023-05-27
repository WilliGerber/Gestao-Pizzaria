using System.Data;
using System.Data.Common;
namespace PizzariaDoZe.DAO;
public class ClienteDAO
{
    private readonly DbProviderFactory factory;
    private string Provider { get; set; }
    private string StringConexao { get; set; }
    public ClienteDAO(string provider, string stringConexao)
    {
        Provider = provider;
        StringConexao = stringConexao;
        factory = DbProviderFactories.GetFactory(Provider);
    }
    // MÉTODO INSERIR AQUI
    public int Inserir(Cliente cliente)
    {
        using var conexao = factory.CreateConnection(); //Cria conexão
        conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
        using var comando = factory.CreateCommand(); //Cria comando
        comando!.Connection = conexao; //Atribui conexão
                                       //Adiciona parâmetro (@campo e valor)
        var nome = comando.CreateParameter(); nome.ParameterName = "@nome";
        nome.Value = cliente.Nome; comando.Parameters.Add(nome);
        var cpf = comando.CreateParameter(); cpf.ParameterName = "@cpf";
        cpf.Value = cliente.Cpf; comando.Parameters.Add(cpf);
        var telefone = comando.CreateParameter(); telefone.ParameterName = "@telefone";
        telefone.Value = cliente.Telefone; comando.Parameters.Add(telefone);
        var email = comando.CreateParameter(); email.ParameterName = "@email";
        email.Value = cliente.Email; comando.Parameters.Add(email);
        var endereco_id = comando.CreateParameter(); endereco_id.ParameterName = "@endereco_id";
        endereco_id.Value = cliente.EnderecoId; comando.Parameters.Add(endereco_id);
        var numero = comando.CreateParameter(); numero.ParameterName = "@numero";
        numero.Value = cliente.Numero; comando.Parameters.Add(numero);
        var complemento = comando.CreateParameter(); complemento.ParameterName = "@complemento";
        complemento.Value = cliente.Complemento; comando.Parameters.Add(complemento);
        conexao.Open();
        //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
        string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";
        //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
        comando.CommandText = @"INSERT INTO tb_clientes (nome_cliente, cpf, telefone, email, endereco_id, numero, complemento)
                                VALUES(@nome, @cpf, @telefone, @email, @endereco_id, @numero, @complemento);" + auxSQL_ID;
        //executa o comando no banco de dados e captura o ID gerado
        var IdGerado = comando.ExecuteScalar();
        return Convert.ToInt32(IdGerado);
    }
}
