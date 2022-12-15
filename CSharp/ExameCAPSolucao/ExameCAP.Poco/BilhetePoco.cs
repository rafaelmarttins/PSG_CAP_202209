using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExameCAP.Poco
{
    public class BilhetePoco
    {
        public int CodigoBilhete { get; set; }
        public int NumeroBilhete { get; set; }
        public string Assento { get; set; } = null!;

        public BilhetePoco()
        { }
    }
}
