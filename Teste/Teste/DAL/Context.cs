﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Model;

namespace Teste.DAL
{
      class Context : DbContext
        {
            //Opcional: Nomear o arquivo do banco de dados
            public Context() : base("Banco")
            {

            }

            //Mapear classes que vão virar tabelas no banco
            public DbSet<Cliente> Cliente { get; set; }
        }
}
