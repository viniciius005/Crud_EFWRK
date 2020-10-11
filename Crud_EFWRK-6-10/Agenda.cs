using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_EFWRK_6_10
{
    class Agenda
    {
        public int id { get; set; }
        public string nome{ get; set; }
        public string telefone{ get; set; }
        public string CPF{ get; set; }
    }
}
