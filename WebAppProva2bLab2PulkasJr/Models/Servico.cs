﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2PulkasJr.Models
{
    public class Servico
    {
        public int SevicoId { get; set; }
        public string Descricao { get; set; }

        public virtual  List<Socio> Socios { get; set; }
        public virtual List<Clube> Clubes { get; set; }



    }
}