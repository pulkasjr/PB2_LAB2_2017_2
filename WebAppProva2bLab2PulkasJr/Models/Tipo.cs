﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2PulkasJr.Models
{
    public class Tipo
    {
        public int TipoId { get; set; }
        public string Descricao { get; set; }

        public virtual List<Tipo > Tipos { get; set; }
        public virtual Clube Clubes { get; set; }


    }
}