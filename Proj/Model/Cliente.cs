using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj.Model
{
    public class Cliente
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }

        public Cliente(string id, string name, string cpf)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
        }
    }
}
