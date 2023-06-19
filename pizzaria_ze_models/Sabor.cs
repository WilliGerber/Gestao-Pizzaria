using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO;
public class Sabor
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public byte[] Foto { get; set; }
    public char Categoria { get; set; }
    public char Tipo { get; set; }
    public List<Ingredient> SaborIngredientes { get; set; }
    public Sabor(int id = 0, string descricao = "", char categoria = ' ', byte[] foto = null, char tipo = ' ', List<Ingredient> saborIngredientes = null)
    {
        Id = id;
        Descricao = descricao;
        Categoria = categoria;
        Foto = foto;
        Tipo = tipo;
        this.SaborIngredientes = saborIngredientes;
    }
}
