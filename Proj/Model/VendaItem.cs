using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj.Model
{

    public class VendaItem
    {

            public int IdProduto { get; set; }
            public string NomeProduto { get; set; }
            public int QuantidadeVenda { get; set; }
            public double PrecoVenda { get; set; }
            public DateTime SaleTime { get; set; }

    }


}