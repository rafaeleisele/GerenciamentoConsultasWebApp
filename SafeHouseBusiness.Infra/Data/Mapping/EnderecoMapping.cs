using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeHouseBusiness.Domain.Entidades;

namespace SafeHouseBusiness.Infra.Data.Mapping
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("enderecos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.DataCadastro).HasColumnName("data_cadastro");
            builder.Property(x => x.Guid).HasColumnName("guid");
            builder.Property(x => x.Estado).HasColumnName("estado").IsRequired(false);
            builder.Property(x => x.Cidade).HasColumnName("cidade").IsRequired(false);
            builder.Property(x => x.Cep).HasColumnName("cep").IsRequired(false);
            builder.Property(x => x.Bairro).HasColumnName("bairro").IsRequired(false);
            builder.Property(x => x.Logradouro).HasColumnName("logradouro").IsRequired(false);
            builder.Property(x => x.Numero).HasColumnName("numero").IsRequired(false);
            builder.Property(x => x.Complemento).HasColumnName("complemento").IsRequired(false);

        }
    }
}