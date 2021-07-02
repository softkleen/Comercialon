using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercialon.Classes
{
    public class Marca
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public Marca(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        public Marca(int id)
        {
            Id = id;
        }
        public Marca()
        {

        }
        public void Inserir() 
        {
            
            var cmd = Banco.Abrir();

        }
        public static List<Marca> ObterListaMarcas(int id) 
        {
            List<Marca> lista = new List<Marca>();
   
            return lista;
        }

    }
}
