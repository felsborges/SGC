﻿using SGC.ApplicationCore.Entity;
using SGC.ApplicationCore.Intefaces.Repository;
using SGC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.Infrastructure.Repository
{
    public class ContatoRepository : EFRepository<Contato>, IContatoRepository
    {
        public ContatoRepository(ClienteContext dbContext) : base(dbContext)
        {

        }
    }
}
