﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_EFWRK_6_10
{
    class Contexto : DbContext
    {

        public Contexto() : base("conexao")
        {

        }

        public DbSet<Agenda> ObjetoAgenda { get; set ; }
        public DbSet<SalaAula> ObjetoSalaAula { get; set ; }
        
        
        
    }
}