using SGC.ApplicationCore.Entity;
using SGC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.Infrastructure.Repository
{
    public class ProfissaoRepository : EFRepository<Profissao>, IProfissasoRepository
    {
        public ProfissaoRepository(ClienteContext dbContext) : base(dbContext)
        {

        }
    }
}
