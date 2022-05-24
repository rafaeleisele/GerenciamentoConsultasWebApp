using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;

namespace SafeHouseBusiness.Infra.Data.Mapping
{
    public class UnidadeMapping : IEntityTypeConfiguration<Unidade>
    {
        public void Configure(EntityTypeBuilder<Unidade> builder)
        {
            builder.ToTable("unidade");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.Guid).HasColumnName("guid");
            builder.Property(x => x.Numero).HasColumnName("numero");
            builder.Property(x => x.Nome).HasColumnName("nome");
            builder.Property(x => x.Aluguel).HasColumnName("aluguel").HasColumnType("decimal(2,2)");
            builder.Property(x => x.Tamanho).HasColumnName("tamanho");

            builder.HasOne(x => x.LocalConsulta).WithMany(x => x.Unidades).HasForeignKey(x => x.IdLocalConsulta);
        }
    }
}
