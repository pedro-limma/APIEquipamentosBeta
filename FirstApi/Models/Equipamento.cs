using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.Models
{
    public class Equipamento
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Tipo { get; set; }
    }
}
