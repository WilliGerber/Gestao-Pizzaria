namespace PizzariaDoZe.DAO;
public class Pizza
{
    public int Id { get; set; }
    public char Tamanho { get; set; }
    public char Borda { get; set; }
    public string Observacao { get; set; }
    public double Valor { get; set; }
    public double ValorBorda { get; set; }
    public List<Sabor> Sabores { get; set; }


    public Pizza(int id = 0, char tamanho = ' ', List<Sabor> sabores = null, char borda = ' ', string observacao = "", double valor = 0, double valorBorda = 0)
    {
        //Id = id;
        Tamanho = tamanho;
        this.Sabores = sabores;
        Borda = borda;
        Observacao = observacao;
        Valor = valor;
        ValorBorda = valorBorda;
    }
}

