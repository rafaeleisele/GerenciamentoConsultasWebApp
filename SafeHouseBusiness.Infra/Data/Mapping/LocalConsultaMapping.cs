using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;

namespace SafeHouseBusiness.Infra.Data.Mapping
{
    public class LocalConsultaMapping : IEntityTypeConfiguration<LocalConsulta>
    {
        public void Configure(EntityTypeBuilder<LocalConsulta> builder)
        {
            builder.ToTable("local_consulta");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.IdContato).HasColumnName("id_contato");
            builder.Property(x => x.IdEndereco).HasColumnName("id_endereco");
            builder.Property(x => x.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(x => x.Guid).HasColumnName("guid");
            builder.Property(x => x.TipoLocalConsulta).HasColumnName("tipo_local_consulta");

            builder.HasOne(x => x.Contato).WithOne(x => x.LocalConsulta).HasForeignKey<LocalConsulta>(x => x.IdContato);
            builder.HasOne(x => x.Endereco).WithOne(x => x.LocalConsulta).HasForeignKey<LocalConsulta>(x => x.IdEndereco);
            builder.HasMany(x => x.Documentos).WithOne(x => x.LocalConsulta).HasForeignKey(x => x.IdLocalConsulta);
            builder.HasMany(x => x.Reunioes).WithOne(x => x.LocalConsulta).HasForeignKey(x => x.IdLocalConsulta);
            builder.HasMany(x => x.Unidades).WithOne(x => x.LocalConsulta).HasForeignKey(x => x.IdLocalConsulta);
        }
    }
}