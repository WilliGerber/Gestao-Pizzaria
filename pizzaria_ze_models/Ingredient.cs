using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;
namespace PizzariaDoZe.DAO;
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

