using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WindowsApp.TarefaModule
{
    public class PrioridadeCb : Object
    {      

        public PrioridadeCb(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
