using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Cargo
    {
        public Cargo(int iD, string nome)
        {
            ID = iD;
            Nome = nome;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
    }
}
