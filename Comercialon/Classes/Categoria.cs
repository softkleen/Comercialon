using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercialon.Classes
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public Categoria(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

        public Categoria(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        public Categoria(int id)
        {
            Id = id;
        }
        public Categoria()
        {

        }
        public static List<Categoria> ObterListaCategoria()
        {
            List<Categoria> lista = new List<Categoria>();

            return lista;
        }
        public void Inserir()
        {

        }


    }
}
