﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.Infrastructure.EntityConfig
{
    public class ProfissaoClienteMap : IEntityTypeConfiguration<ProfissaoCliente>
    {
        public void Configure(EntityTypeBuilder<ProfissaoCliente> builder)
        {
            builder.HasKey(pc => pc.Id);

            builder.HasOne(pc => pc.Cliente)
                .WithMany(c => c.ProfissoesClientes)
                .HasForeignKey(pc => pc.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pc => pc.Profissao)
                .WithMany(p => p.ProfissoesClientes)
                .HasForeignKey(pc => pc.ProfissaoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
