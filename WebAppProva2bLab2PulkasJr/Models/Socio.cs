using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2PulkasJr.Models
{
    public class Socio
    {
        public int SocioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public virtual Clube Clube { get; set; }
        public virtual List <Enderco> Enderecos { get; set; }
        public virtual Enderco  Enderco { get; set; }
    }
}